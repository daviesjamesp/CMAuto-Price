using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Poderosa.Terminal;

namespace AutoPrice
{
    public partial class AutomatedEntryForm : Form
    {
        private const int LOGIN_DELAY = 1500;
        private const int AFTER_LOGIN_DELAY = 3000;
        private const int COMMAND_DELAY = 750;
        private const char ENTER = (char)13;

        private readonly string password;

        public AutomatedEntryForm(string _host, string _password)
        {
            InitializeComponent();
            password = _password.ToUpper();
            terminal.Host = _host;
            terminal.Method = WalburySoftware.ConnectionMethod.Telnet;
        }

        private void AutomatedEntryForm_Load(object sender, EventArgs e)
        {
            // TODO add error check for failure to connect
            terminal.Connect();
            terminal.SetPaneColors(Color.White, Color.Black);
        }

        private void AutomatedEntryForm_Shown(object sender, EventArgs e)
        {
            LoginToCheckmate();
        }

        private async Task LoginToCheckmate()
        {
            await Task.Delay(LOGIN_DELAY);
            terminal.SendText(password + ENTER);
            await Task.Delay(AFTER_LOGIN_DELAY);
        }
    }
}
