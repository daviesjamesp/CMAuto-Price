using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoPrice
{
    class DependencyCheck
    {
        public static string PythonPath = "";
        public static string PyScriptPath = Application.StartupPath + "\\CSharpInputMacro.py";

        public static bool CheckPython()
        {
            var appdata = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            var path = appdata + "\\Programs\\Python\\";
            if (!Directory.Exists(path)) { return false; }
            if (GetHighestVersion(path) == 0) { return false; }
            PythonPath = path + "Python" + GetHighestVersion(path) + "\\python.exe";
            CheckPyAutoGUI();
            return true;
        }

        private static int GetHighestVersion(string path)
        {
            IEnumerable<string> dirs = Directory.EnumerateDirectories(path);
            List<int> versions = new List<int>();
            for (int i = 0; i < dirs.Count(); i++)
            {
                if (File.Exists(dirs.ElementAt(i) + "\\python.exe"))
                {
                    versions.Add(StripPath(dirs.ElementAt(i)));
                }
            }
            versions.Sort();
            versions.Reverse();
            return versions[0];
        }

        private static int StripPath(string path)
        {
            var folders = path.Split('\\');
            var folder = folders[folders.Length - 1];
            folder = folder.Replace("Python", "");
            int res;
            var b = int.TryParse(folder, out res);
            if (b) { return res; }
            else { return 0; }
        }

        private static void CheckPyAutoGUI()
        {
            var pyAutoDir = PythonPath.Replace("python.exe", "Lib\\site-packages\\pyautogui\\");
            if (!Directory.Exists(pyAutoDir)) { InstallPyAuto(); }
            pyAutoDir += "_pyautogui_win.py";
            if (!File.Exists(pyAutoDir)) { InstallPyAuto(); }
        }

        private static void InstallPyAuto()
        {
            string batFileName = Application.StartupPath + @"\" + Guid.NewGuid() + ".bat";
            using (StreamWriter batFile = new StreamWriter(batFileName))
            {
                batFile.WriteLine("py -m pip install pyautogui");
            }
            ProcessStartInfo processStartInfo = new ProcessStartInfo("cmd.exe", "/c " + batFileName);
            processStartInfo.UseShellExecute = false;
            processStartInfo.CreateNoWindow = true;
            Process p = new Process();
            p.StartInfo = processStartInfo;
            p.Start();
            p.WaitForExit();
            File.Delete(batFileName);
        }
    }
}
