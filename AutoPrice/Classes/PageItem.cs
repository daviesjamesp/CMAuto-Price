using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AutoPrice
{
    [Serializable]
    public class PageItem
    {
        public string Grade { get; private set; }
        public string Price { get; private set; }
        public float _Price { get; private set; }
        public string State { get; private set; }
        public string Yard { get; private set; }
        public string Distance { get; private set; }
        public bool Include { get; private set; }

        public PageItem()
        {
            //for serialization
        }

        public PageItem(List<string> item)
        {
            int hasGradeModifier = 0;
            if (item.Count == 8) { hasGradeModifier = 1; }

            SetGrade(item[2 + hasGradeModifier]);
            SetPrice(item[4 + hasGradeModifier]);
            SetState(item[5 + hasGradeModifier]);
            SetYard(item[5 + hasGradeModifier]);
            SetDist(item[6 + hasGradeModifier]);
            
            Include = Main.settings.Check(this);
        }

        private void SetGrade(string g)
        {
            var gradeStr = g.Replace("<td align=center>", "").Replace("</td>", "");
            Grade = gradeStr.Substring(0, 1);
        }

        private void SetPrice(string p)
        {
            var pString = p.Replace("<td align=center>$", "").Replace("</td>", "");
            if (pString.Contains("<"))
            {
                pString = pString.Substring(0, pString.IndexOf("<"));
            }
            float triedParse;
            bool success = float.TryParse(pString, out triedParse);
            if (success)
            {
                _Price = triedParse;
            }
            else
            {
                _Price = 0f;
            }
        }

        private void SetState(string s)
        {
            Regex re = new Regex(@"(USA\-..)");
            Match match = re.Match(s);
            if (match == null) { State = "ZZ"; }
            else { State = match.Value.Replace("USA-", ""); }
        }

        private void SetYard(string y)
        {
            Regex re = new Regex("top\"" + @">([\s\S]*?)</a>", RegexOptions.IgnoreCase);
            Match match = re.Match(y);
            if (match == null) { Yard = "No Yard"; }
            else
            {
                var s = match.Value.Replace("</A>", "");
                s = s.Replace("</a>", "");
                s = s.Replace("top\">", "");
                Yard = s;
            }
        }

        private void SetDist(string d)
        {
            var dist = d.Replace("<td align=center nowrap>", "");
            dist = dist.Replace("</td>", "");
            Distance = dist;
        }
    }
}
