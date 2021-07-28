using System;
using System.Collections.Generic;

namespace AutoPrice
{
    [Serializable]
    public class VehicleDataSource
    {
        private Dictionary<string, int> columnIDs = new Dictionary<string, int>();
        public List<Part> Parts = new List<Part>();

        public string Stock { get; private set; }
        public string Year { get; private set; }
        public string Model { get; private set; }

        public VehicleDataSource(string rawText)
        {
            var lines = rawText.Split('\n');
            GetColumnIDs(lines[0]);
            SetGlobalAttributes(lines[1]);
            for (int i = 1; i < lines.Length; i++)
            {
                if (lines[i] == "") { continue; }
                var newPart = GetPart(i, lines[i]);
                Parts.Add(newPart);
            }
        }

        private Part GetPart(int index, string line)
        {
            var cells = SplitByTab(line);
            var name = cells[columnIDs["Part"]].Replace("\r", "");
            var ic = cells[columnIDs["Interchange"]].Replace("\r", "");
            var miles = cells[columnIDs["Miles"]].Replace("\r", "");
            var grade = cells[columnIDs["Grade"]].Replace("\r", "");
            return new Part(index, name, ic, miles, grade);
        }

        private void SetGlobalAttributes(string line)
        {
            var cells = SplitByTab(line);
            Stock = cells[columnIDs["Stock"]];
            Year = cells[columnIDs["Year"]];
            Model = cells[columnIDs["Model"]];
        }

        private void GetColumnIDs(string headerRow)
        {
            var columns = SplitByTab(headerRow);
            foreach (string column in columns)
            {
                var colIndex = FindColumnByName(column, columns);
                var name = column.Replace("\r", "");
                columnIDs.Add(name, colIndex);
            }
        }

        private int FindColumnByName(string name, string[] columns)
        {
            for (int i = 0; i < columns.Length; i++)
            {
                if (name == columns[i]) { return i; }
            }
            return -1;
        }

        private string[] SplitByTab(string row)
        {
            return row.Split('\t');
        }

        public string Display()
        {
            return Parts.Count.ToString();
        }
    }
}
