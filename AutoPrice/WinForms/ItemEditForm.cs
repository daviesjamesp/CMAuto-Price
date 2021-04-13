using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoPrice
{
    public partial class ItemEditForm : Form
    {
        public Part EditedPart { get; private set; }

        public ItemEditForm(Part part)
        {
            InitializeComponent();
            EditedPart = part;
            if (EditedPart.Side == "") { this.Text = EditedPart.Name; }
            else { this.Text = EditedPart.Name + "-" + EditedPart.Side; }
        }

        private void ItemEditForm_Load(object sender, EventArgs e)
        {
            textIC.Text = EditedPart.IC;
            textGrade.Text = EditedPart.Grade;
            skipCheck.Checked = EditedPart.Skip;
            foreach (PageItem pi in EditedPart.IncludedItems)
            {
                var nlv = new ListViewItem(new string[] { "$" + pi._Price.ToString(), pi.Grade, pi.Distance, pi.Yard });
                listPageItems.Items.Add(nlv);
            }
            PriceEval();
        }

        private void PriceEval()
        {
            if (skipCheck.Checked)
            {
                numPrice.Value = 0;
                numPrice.Enabled = false;
            }
            else
            {
                numPrice.Value = EditedPart.ProjectedPrice;
                numPrice.Enabled = true;
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (numPrice.Value == 0) { skipCheck.Checked = true; }
            EditedPart.Skip = skipCheck.Checked;
            if (skipCheck.Checked)
            {
                EditedPart.ProjectedPrice = 0;
            }
            else
            {
                EditedPart.ProjectedPrice = (int)numPrice.Value;
            }
            this.Close();
        }

        private void buttonBrowser_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(EditedPart.url);
        }

        private void skipCheck_CheckedChanged(object sender, EventArgs e)
        {
            PriceEval();
        }
    }
}
