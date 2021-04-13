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
    public partial class ImportForm : Form
    {
        public string ClipText { get; set; }

        public ImportForm()
        {
            InitializeComponent();
        }

        private void goButton_Click(object sender, EventArgs e)
        {
            ClipText = Clipboard.GetText();
            this.Close();
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            this.Tag = "cancel";
            this.Close();
        }
    }
}
