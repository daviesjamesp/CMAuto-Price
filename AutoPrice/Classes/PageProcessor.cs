using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;

namespace AutoPrice
{
    class PageProcessor
    {
        public static string htmlText;
        public static List<List<string>> pageItemList;

        public static List<PageItem> Process(string url)
        {
            pageItemList = new List<List<string>>();
            var pageItems = new List<PageItem>();
            GetHTML(url);
            Regex();
            for (int i = 0; i < pageItemList.Count; i++)
            {
                var newPageItem = new PageItem(pageItemList[i]);
                pageItems.Add(newPageItem);
            }
            return pageItems;
        }

        private static void GetHTML(string url)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            WebResponse response = request.GetResponse();
            StreamReader sr = new StreamReader(response.GetResponseStream(), Encoding.UTF8);
            htmlText = sr.ReadToEnd();
            sr.Close();
            response.Close();
        }

        private static void Regex()
        {
            var trList = new List<string>();
            Regex rx = new Regex(@"<tr>([\s\S]*?)<\/tr>");
            MatchCollection matches = rx.Matches(htmlText);
            foreach (Match match in matches)
            {
                if (match.Value.Contains("$"))
                {
                    trList.Add(match.Value.Replace('\n', ' '));
                }
            }
            Regex_TD(trList);
        }
        
        private static void Regex_TD(List<string> trList)
        {
            foreach (string str in trList)
            {
                var tdList = new List<string>();
                Regex rx = new Regex(@"<td([\s\S]*?)<\/td>");
                MatchCollection matches = rx.Matches(str);
                foreach (Match match in matches)
                {
                    tdList.Add(match.Value.Replace('\n', ' '));
                }
                pageItemList.Add(tdList);
            }
        }

        public static bool Validate(string testURL)
        {
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(testURL);
                request.Method = "GET";
                WebResponse response = request.GetResponse();
                if (response != null) { return true; }
                else { return false; }
            }
            catch (HttpListenerException)
            {
                return false;
            }
        }
    }
}
