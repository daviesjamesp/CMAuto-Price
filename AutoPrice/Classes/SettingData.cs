using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace AutoPrice
{
    [Serializable]
    public class SettingData
    {
        public readonly string SettingsFilepath = Application.StartupPath + "\\settings.bin";
        public string MyBaseURL = "";
        public string ExportPath = "";
        public List<string> AlwaysSkip = new List<string>();
        public Dictionary<string, int> NoICPrices = new Dictionary<string, int>();
        public bool IncludeOutOfState = true;
        public int MaxDist = 0;
        public List<string> IncludeGrades = new List<string>();
        public List<string> ExcludeYards = new List<string>();
        public int MinimumDataPoints = 0;

        public SettingData()
        {
            ExcludeYards = new List<string>();
        }

        public void LoadSettings()
        {
            using (var s = new FileStream(SettingsFilepath, FileMode.Open, FileAccess.Read))
            {
                IFormatter formatter = new BinaryFormatter();
                var dObj = (SettingData)formatter.Deserialize(s);
                MyBaseURL = dObj.MyBaseURL;
                ExportPath = dObj.ExportPath;
                AlwaysSkip = dObj.AlwaysSkip;
                MaxDist = dObj.MaxDist;
                IncludeGrades = dObj.IncludeGrades;
                ExcludeYards = dObj.ExcludeYards;
                MinimumDataPoints = dObj.MinimumDataPoints;
                NoICPrices = dObj.NoICPrices;
            }
        }

        public void SaveSettings()
        {
            using (var s = new FileStream(SettingsFilepath, FileMode.Create, FileAccess.Write))
            {
                IFormatter formatter = new BinaryFormatter();
                formatter.Serialize(s, this);
            }
        }

        public Part Check(Part p)
        {
            if (p.ProjectedPrice < 0) { p.ProjectedPrice = 0; }
            if (Main.settings.AlwaysSkip.Contains(p.Name))
            {
                p.ProjectedPrice = 0;
                p.Skip = true;
                return p;
            }
            if (NoICPrices.ContainsKey(p.Name) && string.IsNullOrEmpty(p.IC))
            {
                p.Skip = false;
                p.ProjectedPrice = NoICPrices[p.Name];
                return p;
            }
            if (p.IncludedItems.Count < Main.settings.MinimumDataPoints)
            {
                p.Skip = true;
                p.ProjectedPrice = 0;
                return p;
            }
            return p;
        }

        public bool Check(PageItem p)
        {
            if (ExcludedYard(p)) { return false; }
            if (!CheckDist(p)) { return false; }
            if (!CheckGrade(p)) { return false; }
            if (p._Price < float.Epsilon) { return false; }
            return true;
        }

        private bool ExcludedYard(PageItem p)
        {
            foreach (string y in Main.settings.ExcludeYards)
            {
                if (p.Yard.ToUpper().Contains(y)) { return true; }
            }
            return false;
        }

        private bool CheckDist(PageItem p)
        {
            if (Main.settings.MaxDist == 0) { return true; }
            int d;
            var b = int.TryParse(p.Distance, out d);
            if (!b) { return false; }
            if (d > Main.settings.MaxDist) { return false; }
            return true;
        }

        private bool CheckGrade(PageItem p)
        {
            if (Main.settings.IncludeGrades.Contains(p.Grade)) { return true; }
            else { return false; }
        }
    }
}
