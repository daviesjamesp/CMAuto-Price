using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IronPython.Hosting;
using Microsoft.Scripting.Hosting;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using Microsoft.Win32;

namespace AutoPrice
{
    class Exporter
    {
        public static string Stock { get; private set; }
        public static string FormattedText { get; set; }

        public static void FormatData(VehicleDataSource vds)
        {
            var sep = '-';
            Stock = vds.Stock;
            FormattedText = "";
            foreach (Part p in vds.Parts)
            {
                string priceStr;
                if (p.ProjectedPrice == 0 || p.Skip == true)
                {
                    priceStr = "None";
                }
                else
                {
                    priceStr = p.ProjectedPrice.ToString();
                }
                if (FormattedText == "")
                {
                    FormattedText += p.Name + sep + priceStr;
                }
                else
                {
                    FormattedText += '\n' + p.Name + sep + priceStr;
                }
            }
        }
        public static void FormatData(VehicleDataSource vds, bool forFile)
        {
            var sep = '\t';
            var titleLine = vds.Stock + " " + vds.Year + " " + vds.Model + ": " + vds.Parts.Count.ToString() + " parts" + '\n';
            FormattedText = "";
            foreach (Part p in vds.Parts)
            {
                var s = "";
                if (FormattedText == "") { s = "\n"; }
                var nameStr = p.Name;
                if (p.Side != "") { nameStr += "-" + p.Side; }
                else { nameStr += "  "; }
                var icStr = p.IC;
                if (string.IsNullOrWhiteSpace(icStr)) { icStr = "NoIC  "; }
                string priceStr;
                if (p.ProjectedPrice == 0)
                {
                    priceStr = "None ";
                }
                else
                {
                    priceStr = PriceToLength("$" + p.ProjectedPrice.ToString());
                }
                FormattedText += s + nameStr + sep + icStr + sep + " " + priceStr + sep + p.IncludedItems.Count.ToString() + "/" + p.ExcludedItems.Count.ToString() + "\n";
            }
            FormattedText = titleLine + FormattedText;
        }

        private static string PriceToLength(string p)
        {
            while (p.Length != 5)
            {
                p += " ";
            }
            return p;
        }

        public static void WriteToFile(string path = "")
        {
            string writePath = "";
            if (path == "")
            {
                writePath = Application.StartupPath + "\\" + Stock + ".txt";
            }
            else { writePath = path; }
            var sw = new StreamWriter(writePath, false);
            sw.Write(FormattedText);
            sw.Close();
        }

        public static void SaveSession(VehicleDataSource vds, string path)
        {
            using (var s = new FileStream(path, FileMode.Create, FileAccess.Write))
            {
                IFormatter formatter = new BinaryFormatter();
                formatter.Serialize(s, vds);
            }
        }

        public static VehicleDataSource OpenSession(string path)
        {
            VehicleDataSource vdsObj;
            using (var s = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                IFormatter formatter = new BinaryFormatter();
                vdsObj = (VehicleDataSource)formatter.Deserialize(s);
            }
            return vdsObj;
        }

        public static void RunPyScript(VehicleDataSource vds)
        {
            FormatData(vds);
            WriteToFile();

            string batFileName = Application.StartupPath + @"\" + Guid.NewGuid() + ".bat";

            using (StreamWriter batFile = new StreamWriter(batFileName))
            {
                batFile.WriteLine(DependencyCheck.PythonPath + " " + DependencyCheck.PyScriptPath + " " + Application.StartupPath + "\\" + Stock + ".txt" + " " + true.ToString());
            }

            ProcessStartInfo processStartInfo = new ProcessStartInfo("cmd.exe", "/c " + batFileName);
            processStartInfo.UseShellExecute = false;
            processStartInfo.CreateNoWindow = true;

            Process p = new Process();
            p.StartInfo = processStartInfo;
            p.Start();
            p.WaitForExit();

            File.Delete(batFileName);
            File.Delete(Application.StartupPath + "\\" + Stock + ".txt");
        }

        
    }
}
