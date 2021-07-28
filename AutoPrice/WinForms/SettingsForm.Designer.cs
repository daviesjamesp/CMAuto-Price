
namespace AutoPrice
{
    partial class SettingsForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.buttonSetURL = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bURLHelp = new System.Windows.Forms.Button();
            this.textURL = new System.Windows.Forms.TextBox();
            this.listExclude = new System.Windows.Forms.ListBox();
            this.listMin = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bexDelete = new System.Windows.Forms.Button();
            this.bexAdd = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.bminDelete = new System.Windows.Forms.Button();
            this.bminAdd = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.bPathHelp = new System.Windows.Forms.Button();
            this.textFilePath = new System.Windows.Forms.TextBox();
            this.buttonSetPath = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.beyDelete = new System.Windows.Forms.Button();
            this.listExYards = new System.Windows.Forms.ListBox();
            this.beyAdd = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.numPPP = new System.Windows.Forms.NumericUpDown();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.numMinData = new System.Windows.Forms.NumericUpDown();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboDist = new System.Windows.Forms.ComboBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.cX = new System.Windows.Forms.CheckBox();
            this.cC = new System.Windows.Forms.CheckBox();
            this.cB = new System.Windows.Forms.CheckBox();
            this.cA = new System.Windows.Forms.CheckBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPPP)).BeginInit();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMinData)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonSetURL
            // 
            this.buttonSetURL.Location = new System.Drawing.Point(356, 17);
            this.buttonSetURL.Name = "buttonSetURL";
            this.buttonSetURL.Size = new System.Drawing.Size(75, 23);
            this.buttonSetURL.TabIndex = 0;
            this.buttonSetURL.Text = "Set URL";
            this.buttonSetURL.UseVisualStyleBackColor = true;
            this.buttonSetURL.Click += new System.EventHandler(this.buttonSetURL_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bURLHelp);
            this.groupBox1.Controls.Add(this.textURL);
            this.groupBox1.Controls.Add(this.buttonSetURL);
            this.groupBox1.Location = new System.Drawing.Point(6, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(469, 54);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hotkey URL";
            // 
            // bURLHelp
            // 
            this.bURLHelp.Location = new System.Drawing.Point(437, 17);
            this.bURLHelp.Name = "bURLHelp";
            this.bURLHelp.Size = new System.Drawing.Size(26, 23);
            this.bURLHelp.TabIndex = 4;
            this.bURLHelp.Text = "?";
            this.bURLHelp.UseVisualStyleBackColor = true;
            this.bURLHelp.Click += new System.EventHandler(this.bURLHelp_Click);
            // 
            // textURL
            // 
            this.textURL.Location = new System.Drawing.Point(6, 19);
            this.textURL.Name = "textURL";
            this.textURL.Size = new System.Drawing.Size(344, 20);
            this.textURL.TabIndex = 3;
            this.toolTip1.SetToolTip(this.textURL, "See the help button to the right");
            this.textURL.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxes_KeyPress);
            // 
            // listExclude
            // 
            this.listExclude.FormattingEnabled = true;
            this.listExclude.Location = new System.Drawing.Point(6, 21);
            this.listExclude.Name = "listExclude";
            this.listExclude.Size = new System.Drawing.Size(209, 186);
            this.listExclude.TabIndex = 0;
            this.listExclude.SelectedIndexChanged += new System.EventHandler(this.listExclude_SelectedIndexChanged);
            // 
            // listMin
            // 
            this.listMin.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listMin.FullRowSelect = true;
            this.listMin.HideSelection = false;
            this.listMin.Location = new System.Drawing.Point(6, 19);
            this.listMin.MultiSelect = false;
            this.listMin.Name = "listMin";
            this.listMin.Size = new System.Drawing.Size(209, 186);
            this.listMin.TabIndex = 1;
            this.listMin.UseCompatibleStateImageBehavior = false;
            this.listMin.View = System.Windows.Forms.View.Details;
            this.listMin.SelectedIndexChanged += new System.EventHandler(this.listMin_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Part";
            this.columnHeader1.Width = 103;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Price";
            this.columnHeader2.Width = 92;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bexDelete);
            this.groupBox2.Controls.Add(this.listExclude);
            this.groupBox2.Controls.Add(this.bexAdd);
            this.groupBox2.Location = new System.Drawing.Point(253, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(222, 244);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Always Skip:";
            this.toolTip1.SetToolTip(this.groupBox2, "Parts to always skip pricing");
            // 
            // bexDelete
            // 
            this.bexDelete.Enabled = false;
            this.bexDelete.Location = new System.Drawing.Point(6, 213);
            this.bexDelete.Name = "bexDelete";
            this.bexDelete.Size = new System.Drawing.Size(96, 23);
            this.bexDelete.TabIndex = 7;
            this.bexDelete.Text = "Delete";
            this.bexDelete.UseVisualStyleBackColor = true;
            this.bexDelete.Click += new System.EventHandler(this.bexDelete_Click);
            // 
            // bexAdd
            // 
            this.bexAdd.Location = new System.Drawing.Point(119, 213);
            this.bexAdd.Name = "bexAdd";
            this.bexAdd.Size = new System.Drawing.Size(96, 23);
            this.bexAdd.TabIndex = 6;
            this.bexAdd.Text = "Add";
            this.bexAdd.UseVisualStyleBackColor = true;
            this.bexAdd.Click += new System.EventHandler(this.bexAdd_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.bminDelete);
            this.groupBox3.Controls.Add(this.bminAdd);
            this.groupBox3.Controls.Add(this.listMin);
            this.groupBox3.Location = new System.Drawing.Point(6, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(222, 244);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "No IC Prices:";
            this.toolTip1.SetToolTip(this.groupBox3, "Prices to set for no-interchange parts");
            // 
            // bminDelete
            // 
            this.bminDelete.Enabled = false;
            this.bminDelete.Location = new System.Drawing.Point(6, 211);
            this.bminDelete.Name = "bminDelete";
            this.bminDelete.Size = new System.Drawing.Size(96, 23);
            this.bminDelete.TabIndex = 5;
            this.bminDelete.Text = "Delete";
            this.bminDelete.UseVisualStyleBackColor = true;
            this.bminDelete.Click += new System.EventHandler(this.bminDelete_Click);
            // 
            // bminAdd
            // 
            this.bminAdd.Location = new System.Drawing.Point(119, 211);
            this.bminAdd.Name = "bminAdd";
            this.bminAdd.Size = new System.Drawing.Size(96, 23);
            this.bminAdd.TabIndex = 4;
            this.bminAdd.Text = "Add";
            this.bminAdd.UseVisualStyleBackColor = true;
            this.bminAdd.Click += new System.EventHandler(this.bminAdd_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.bPathHelp);
            this.groupBox4.Controls.Add(this.textFilePath);
            this.groupBox4.Controls.Add(this.buttonSetPath);
            this.groupBox4.Location = new System.Drawing.Point(6, 76);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(469, 54);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Export Filepath";
            // 
            // bPathHelp
            // 
            this.bPathHelp.Location = new System.Drawing.Point(437, 17);
            this.bPathHelp.Name = "bPathHelp";
            this.bPathHelp.Size = new System.Drawing.Size(26, 23);
            this.bPathHelp.TabIndex = 4;
            this.bPathHelp.Text = "?";
            this.bPathHelp.UseVisualStyleBackColor = true;
            this.bPathHelp.Click += new System.EventHandler(this.bPathHelp_Click);
            // 
            // textFilePath
            // 
            this.textFilePath.Location = new System.Drawing.Point(6, 19);
            this.textFilePath.Name = "textFilePath";
            this.textFilePath.Size = new System.Drawing.Size(344, 20);
            this.textFilePath.TabIndex = 3;
            this.toolTip1.SetToolTip(this.textFilePath, "See the help button to the right");
            this.textFilePath.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxes_KeyPress);
            // 
            // buttonSetPath
            // 
            this.buttonSetPath.Location = new System.Drawing.Point(356, 17);
            this.buttonSetPath.Name = "buttonSetPath";
            this.buttonSetPath.Size = new System.Drawing.Size(75, 23);
            this.buttonSetPath.TabIndex = 0;
            this.buttonSetPath.Text = "Set Path";
            this.buttonSetPath.UseVisualStyleBackColor = true;
            this.buttonSetPath.Click += new System.EventHandler(this.buttonSetPath_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(28, 583);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(456, 23);
            this.buttonSave.TabIndex = 7;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.beyDelete);
            this.groupBox8.Controls.Add(this.listExYards);
            this.groupBox8.Controls.Add(this.beyAdd);
            this.groupBox8.Location = new System.Drawing.Point(6, 256);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(469, 176);
            this.groupBox8.TabIndex = 8;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Excluded Yards:";
            this.toolTip1.SetToolTip(this.groupBox8, "Yards to exclude from search");
            // 
            // beyDelete
            // 
            this.beyDelete.Enabled = false;
            this.beyDelete.Location = new System.Drawing.Point(6, 147);
            this.beyDelete.Name = "beyDelete";
            this.beyDelete.Size = new System.Drawing.Size(209, 23);
            this.beyDelete.TabIndex = 7;
            this.beyDelete.Text = "Delete";
            this.beyDelete.UseVisualStyleBackColor = true;
            this.beyDelete.Click += new System.EventHandler(this.beyDelete_Click);
            // 
            // listExYards
            // 
            this.listExYards.FormattingEnabled = true;
            this.listExYards.Location = new System.Drawing.Point(6, 21);
            this.listExYards.Name = "listExYards";
            this.listExYards.Size = new System.Drawing.Size(456, 121);
            this.listExYards.TabIndex = 0;
            this.listExYards.SelectedIndexChanged += new System.EventHandler(this.listExYards_SelectedIndexChanged);
            // 
            // beyAdd
            // 
            this.beyAdd.Location = new System.Drawing.Point(253, 147);
            this.beyAdd.Name = "beyAdd";
            this.beyAdd.Size = new System.Drawing.Size(209, 23);
            this.beyAdd.TabIndex = 6;
            this.beyAdd.Text = "Add";
            this.beyAdd.UseVisualStyleBackColor = true;
            this.beyAdd.Click += new System.EventHandler(this.beyAdd_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(489, 561);
            this.tabControl1.TabIndex = 9;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(481, 535);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Global";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.groupBox9);
            this.tabPage2.Controls.Add(this.groupBox7);
            this.tabPage2.Controls.Add(this.groupBox6);
            this.tabPage2.Controls.Add(this.groupBox5);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(481, 535);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Search Criteria";
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.numPPP);
            this.groupBox9.Location = new System.Drawing.Point(252, 71);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(223, 46);
            this.groupBox9.TabIndex = 13;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Search Pages per Part:";
            this.toolTip1.SetToolTip(this.groupBox9, "Pages to include in search");
            // 
            // numPPP
            // 
            this.numPPP.Enabled = false;
            this.numPPP.Location = new System.Drawing.Point(51, 19);
            this.numPPP.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numPPP.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numPPP.Name = "numPPP";
            this.numPPP.Size = new System.Drawing.Size(121, 20);
            this.numPPP.TabIndex = 0;
            this.numPPP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numPPP.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.numMinData);
            this.groupBox7.Location = new System.Drawing.Point(6, 71);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(223, 46);
            this.groupBox7.TabIndex = 12;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Minimum Data Points:";
            this.toolTip1.SetToolTip(this.groupBox7, "Number of data points needed to project a price");
            // 
            // numMinData
            // 
            this.numMinData.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numMinData.Location = new System.Drawing.Point(51, 19);
            this.numMinData.Maximum = new decimal(new int[] {
            45,
            0,
            0,
            0});
            this.numMinData.Name = "numMinData";
            this.numMinData.Size = new System.Drawing.Size(121, 20);
            this.numMinData.TabIndex = 0;
            this.numMinData.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label1);
            this.groupBox6.Controls.Add(this.comboDist);
            this.groupBox6.Location = new System.Drawing.Point(6, 6);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(469, 46);
            this.groupBox6.TabIndex = 11;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Maximum Distance:";
            this.toolTip1.SetToolTip(this.groupBox6, "Distance to include in search");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(282, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Miles";
            // 
            // comboDist
            // 
            this.comboDist.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboDist.FormattingEnabled = true;
            this.comboDist.Items.AddRange(new object[] {
            "All",
            "100",
            "200",
            "300",
            "400",
            "500",
            "600",
            "700",
            "800",
            "900",
            "1000"});
            this.comboDist.Location = new System.Drawing.Point(155, 16);
            this.comboDist.Name = "comboDist";
            this.comboDist.Size = new System.Drawing.Size(121, 21);
            this.comboDist.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.cX);
            this.groupBox5.Controls.Add(this.cC);
            this.groupBox5.Controls.Add(this.cB);
            this.groupBox5.Controls.Add(this.cA);
            this.groupBox5.Location = new System.Drawing.Point(6, 136);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(469, 46);
            this.groupBox5.TabIndex = 10;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Included Grades:";
            this.toolTip1.SetToolTip(this.groupBox5, "Grades to include in search");
            // 
            // cX
            // 
            this.cX.AutoSize = true;
            this.cX.Location = new System.Drawing.Point(312, 19);
            this.cX.Name = "cX";
            this.cX.Size = new System.Drawing.Size(33, 17);
            this.cX.TabIndex = 3;
            this.cX.Text = "X";
            this.cX.UseVisualStyleBackColor = true;
            // 
            // cC
            // 
            this.cC.AutoSize = true;
            this.cC.Location = new System.Drawing.Point(249, 19);
            this.cC.Name = "cC";
            this.cC.Size = new System.Drawing.Size(33, 17);
            this.cC.TabIndex = 2;
            this.cC.Text = "C";
            this.cC.UseVisualStyleBackColor = true;
            // 
            // cB
            // 
            this.cB.AutoSize = true;
            this.cB.Location = new System.Drawing.Point(186, 19);
            this.cB.Name = "cB";
            this.cB.Size = new System.Drawing.Size(33, 17);
            this.cB.TabIndex = 1;
            this.cB.Text = "B";
            this.cB.UseVisualStyleBackColor = true;
            // 
            // cA
            // 
            this.cA.AutoSize = true;
            this.cA.Location = new System.Drawing.Point(123, 19);
            this.cA.Name = "cA";
            this.cA.Size = new System.Drawing.Size(33, 17);
            this.cA.TabIndex = 0;
            this.cA.Text = "A";
            this.cA.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage3.Controls.Add(this.groupBox3);
            this.tabPage3.Controls.Add(this.groupBox8);
            this.tabPage3.Controls.Add(this.groupBox2);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(481, 535);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Modifiers";
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 618);
            this.ControlBox = false;
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.buttonSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SettingsForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numPPP)).EndInit();
            this.groupBox7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numMinData)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonSetURL;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listExclude;
        private System.Windows.Forms.ListView listMin;
        private System.Windows.Forms.TextBox textURL;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bexDelete;
        private System.Windows.Forms.Button bexAdd;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button bminDelete;
        private System.Windows.Forms.Button bminAdd;
        private System.Windows.Forms.Button bURLHelp;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button bPathHelp;
        private System.Windows.Forms.TextBox textFilePath;
        private System.Windows.Forms.Button buttonSetPath;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Button beyDelete;
        private System.Windows.Forms.ListBox listExYards;
        private System.Windows.Forms.Button beyAdd;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.NumericUpDown numPPP;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.NumericUpDown numMinData;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboDist;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.CheckBox cX;
        private System.Windows.Forms.CheckBox cC;
        private System.Windows.Forms.CheckBox cB;
        private System.Windows.Forms.CheckBox cA;
        private System.Windows.Forms.TabPage tabPage3;
    }
}