
namespace AutoPrice
{
    partial class AutomatedEntryForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.terminal = new WalburySoftware.TerminalControl();
            this.SuspendLayout();
            // 
            // terminal
            // 
            this.terminal.AuthType = Poderosa.ConnectionParam.AuthType.Password;
            this.terminal.Host = "";
            this.terminal.IdentifyFile = "";
            this.terminal.Location = new System.Drawing.Point(12, 12);
            this.terminal.Method = WalburySoftware.ConnectionMethod.Telnet;
            this.terminal.Name = "terminal";
            this.terminal.Password = "";
            this.terminal.Size = new System.Drawing.Size(572, 526);
            this.terminal.TabIndex = 0;
            this.terminal.Text = "terminal";
            this.terminal.UserName = "";
            // 
            // AutomatedEntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 550);
            this.Controls.Add(this.terminal);
            this.Name = "AutomatedEntryForm";
            this.Text = "AutomatedEntryForm";
            this.Load += new System.EventHandler(this.AutomatedEntryForm_Load);
            this.Shown += new System.EventHandler(this.AutomatedEntryForm_Shown);
            this.ResumeLayout(false);

        }

        #endregion

        private WalburySoftware.TerminalControl terminal;
    }
}