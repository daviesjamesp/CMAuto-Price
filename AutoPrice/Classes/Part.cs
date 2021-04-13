using System;
using System.Collections.Generic;
using System.Linq;

namespace AutoPrice
{
    [Serializable]
    public class Part
    {
        public int Index { get; private set; }
        public string Name { get; private set; }
        public string IC { get; private set; }
        public string Miles { get; private set; }
        public string Grade { get; private set; }
        public string Side { get; private set; }
        public bool Skip { get; set; }
        public List<PageItem> IncludedItems { get; private set; }
        public List<PageItem> ExcludedItems { get; private set; }
        public int ProjectedPrice { get; set; }

        public string url;
        private List<PageItem> pageItems = new List<PageItem>();


        public Part()
        {
            //for serialization
        }

        public Part(int index, string name, string ic, string miles, string grade)
        {
            Index = index;
            IncludedItems = new List<PageItem>();
            ExcludedItems = new List<PageItem>();
            if (name.Contains("-"))
            {
                var splitName = name.Split('-');
                Name = splitName[0];
                Side = splitName[1];
            }
            else
            {
                Name = name;
                Side = "";
            }
            if (ic == null || ic == "")
            {
                Skip = true;
                ProjectedPrice = 0;
            }
            else
            {
                Skip = false;
                IC = ic;
                Miles = miles;
                Grade = grade;
            }
        }

        public void Build()
        {
            if (Skip) { return; }
            BuildURL();
            GetPageItems();
            CrunchPrice();
            if (ProjectedPrice < float.Epsilon) { Skip = true; }
        }

        private void CrunchPrice()
        {
            float priceSum = 0f;
            IncludedItems = pageItems.Where(a => a.Include).ToList();
            ExcludedItems = pageItems.Where(a => !a.Include).ToList();
            foreach (PageItem p in IncludedItems)
            {
                priceSum += p._Price;
            }
            ProjectedPrice = Round(priceSum / IncludedItems.Count);
        }

        private int Round(float a)
        {
            double d = (double)a;
            d = Math.Round(d / 5) * 5;
            return (int)d;
        }

        private void GetPageItems()
        {
            pageItems = PageProcessor.Process(url);
        }

        private void BuildURL()
        {
            url = Main.settings.MyBaseURL;
            url = url.Replace("%P", Name);
            url = url.Replace("%S", Side);
            url = url.Replace("%I", IC);
            Console.WriteLine(url);
        }
    }
}
