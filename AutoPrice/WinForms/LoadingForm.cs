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
    public partial class LoadingForm : Form
    {
        private int current = 0;
        private int total = 0;

        public LoadingForm(int t)
        {
            InitializeComponent();
            total = t;
            progressLoading.Maximum = total;
            BuildLabel();
        }

        private void BuildLabel()
        {
            countLabel.Text = current.ToString() + " out of " + total.ToString();
        }

        public void Step()
        {
            current++;
            progressLoading.PerformStep();
            BuildLabel();
            if (current == total)
            {
                Close();
            }
        }
    }
}
