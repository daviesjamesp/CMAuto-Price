using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoPrice
{
    public partial class SettingsForm : Form
    {
        public SettingData EditedSettings;

        public SettingsForm(SettingData s)
        {
            InitializeComponent();
            EditedSettings = s;
        }

        private void buttonSetURL_Click(object sender, EventArgs e)
        {
            var txt = Clipboard.GetText();
            if (PageProcessor.Validate(txt))
            {
                EditedSettings.MyBaseURL = StripURL(txt);
            }
            else
            {
                //messagebox error goes here
            }
            UpdateFields();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            UpdateFields();
        }

        private string StripURL(string u)
        {
            string newURL = "";
            var i = u.IndexOf('?');
            newURL = u.Substring(0, i + 1) + "userPreference=price&uPart=%P&uSide=%S&uInterchange=%I&";
            i = u.IndexOf("uID");
            newURL += u.Substring(i);
            return newURL;
        }

        private void UpdateFields()
        {
            listExclude.Items.Clear();
            listMin.Items.Clear();
            listExYards.Items.Clear();
            textURL.Text = EditedSettings.MyBaseURL;
            textFilePath.Text = EditedSettings.ExportPath;
            foreach (string i in EditedSettings.AlwaysSkip)
            {
                listExclude.Items.Add(i);
            }
            if (EditedSettings.ExcludeYards == null) { EditedSettings.ExcludeYards = new List<string>(); }
            foreach (string i in EditedSettings.ExcludeYards)
            {
                listExYards.Items.Add(i);
            }
            foreach (SerializableKVP kvp in EditedSettings.NoICKVP)
            {
                if (string.IsNullOrEmpty(kvp.index)) { continue; }
                var nlv = new ListViewItem(new string[] { kvp.index, kvp.value });
                listMin.Items.Add(nlv);
            }
            if (EditedSettings.IncludeGrades.Contains("A")) { cA.Checked = true; }
            if (EditedSettings.IncludeGrades.Contains("B")) { cB.Checked = true; }
            if (EditedSettings.IncludeGrades.Contains("C")) { cC.Checked = true; }
            if (EditedSettings.IncludeGrades.Contains("X")) { cX.Checked = true; }
            comboDist.SelectedIndex = EditedSettings.MaxDist / 100;
            numMinData.Value = EditedSettings.MinimumDataPoints;
        }

        private void buttonSetPath_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            EditedSettings.ExportPath = folderBrowserDialog1.SelectedPath + "\\";
            UpdateFields();
        }

        private void listExclude_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listExclude.SelectedItems.Count == 0)
            {
                bexDelete.Enabled = false;
            }
            else
            {
                bexDelete.Enabled = true;
            }
        }

        private void listMin_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listMin.SelectedItems.Count == 0)
            {
                bminDelete.Enabled = false;
            }
            else
            {
                bminDelete.Enabled = true;
            }
        }

        private void bexDelete_Click(object sender, EventArgs e)
        {
            var i = listExclude.SelectedIndex;
            EditedSettings.AlwaysSkip.RemoveAt(i);
            bexDelete.Enabled = false;
            UpdateFields();
        }

        private void bminDelete_Click(object sender, EventArgs e)
        {
            var i = listMin.SelectedIndices[0];
            EditedSettings.NoICKVP.RemoveAt(i);
            bminDelete.Enabled = false;
            UpdateFields();
        }

        private void bexAdd_Click(object sender, EventArgs e)
        {
            var af = new AddSettingForm(false);
            af.ShowDialog();
            if (!af.Valid) { return; }
            EditedSettings.AlwaysSkip.Add(af.Prop1);
            UpdateFields();
        }

        private void bminAdd_Click(object sender, EventArgs e)
        {
            var af = new AddSettingForm(true);
            af.ShowDialog();
            if (!af.Valid) { return; }
            var k = new SerializableKVP();
            k.Set(af.Prop1, af.Prop2);
            EditedSettings.NoICKVP.Add(k);
            UpdateFields();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (EditedSettings.MyBaseURL == "")
            {
                MessageBox.Show("URL cannot be left empty!", "Warning",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!cA.Checked && !cB.Checked && !cC.Checked && !cX.Checked)
            {
                MessageBox.Show("At least one grade must be included!", "Warning",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            EditedSettings.MaxDist = comboDist.SelectedIndex * 100;
            EditedSettings.IncludeGrades.Clear();
            EditedSettings.MinimumDataPoints = (int)numMinData.Value;
            if (cA.Checked) { EditedSettings.IncludeGrades.Add("A"); }
            if (cB.Checked) { EditedSettings.IncludeGrades.Add("B"); }
            if (cC.Checked) { EditedSettings.IncludeGrades.Add("C"); }
            if (cX.Checked) { EditedSettings.IncludeGrades.Add("X"); }
            EditedSettings.UpdateDictionary();
            this.Close();
        }

        private void bURLHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Use your hotkey (F2) to search any part from Checkmate.\n" +
                "Copy the full URL to your clipboard and press the \"Set\" button.",
                "Help",MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void bPathHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Use the browser dialog to select where the Excel" +
                "spreadsheets will be saved.", "Help",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void beyAdd_Click(object sender, EventArgs e)
        {
            var af = new AddSettingForm(false);
            af.Tag = "Yard";
            af.ShowDialog();
            if (!af.Valid) { return; }
            EditedSettings.ExcludeYards.Add(af.Prop1.ToUpper());
            UpdateFields();
        }

        private void beyDelete_Click(object sender, EventArgs e)
        {
            var i = listExYards.SelectedIndices[0];
            EditedSettings.ExcludeYards.RemoveAt(i);
            beyDelete.Enabled = false;
            UpdateFields();
        }

        private void listExYards_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listExYards.SelectedItems.Count == 0)
            {
                beyDelete.Enabled = false;
            }
            else
            {
                beyDelete.Enabled = true;
            }
        }
    }
}
