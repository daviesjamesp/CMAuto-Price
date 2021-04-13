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
    public partial class AddSettingForm : Form
    {
        public bool IsTwoProp { get; set; }
        public bool Valid { get; set; }
        public string Prop1 { get; set; }
        public string Prop2 { get; set; }

        public AddSettingForm(bool two)
        {
            InitializeComponent();
            if (!two) { groupBox2.Visible = false; groupBox2.Enabled = false; }
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            if (IsTwoProp && !ValidatePrice())
            {
                MessageBox.Show("The entered price must be a whole number and end in 0 or 5",
                                "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (textBox1.Text == "")
            {
                Valid = false;
                this.Close();
                return;
            }
            else
            {
                if (IsTwoProp && textBox2.Text == "")
                {
                    Valid = false;
                    this.Close();
                    return;
                }
                else
                {
                    Valid = true;
                    this.Close();
                }
            }
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            Valid = false;
            this.Close();
        }

        private void AddSettingForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Prop1 = textBox1.Text;
            Prop2 = textBox2.Text;
        }

        private bool ValidatePrice()
        {
            int i;
            var b = int.TryParse(textBox2.Text, out i);
            if (!b) { return false; }
            if (i % 5 != 0) { return false; }
            else { return true; }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)) { e.Handled = true; }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) { e.Handled = true; }
        }

        private void AddSettingForm_Load(object sender, EventArgs e)
        {
            if (this.Tag != null)
            {
                groupBox1.Text = "Yard to exclude:";
                textBox1.MaxLength = 20;
                textBox1.KeyPress -= textBox1_KeyPress;
            }
        }
    }
}
