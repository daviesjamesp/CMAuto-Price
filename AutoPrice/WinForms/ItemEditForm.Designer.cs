
namespace AutoPrice
{
    partial class ItemEditForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.textIC = new System.Windows.Forms.TextBox();
            this.numPrice = new System.Windows.Forms.NumericUpDown();
            this.buttonBrowser = new System.Windows.Forms.Button();
            this.textGrade = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.skipCheck = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listPageItems = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Interchange:";
            // 
            // textIC
            // 
            this.textIC.Enabled = false;
            this.textIC.Location = new System.Drawing.Point(13, 65);
            this.textIC.Name = "textIC";
            this.textIC.Size = new System.Drawing.Size(100, 20);
            this.textIC.TabIndex = 1;
            this.textIC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numPrice
            // 
            this.numPrice.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numPrice.Location = new System.Drawing.Point(37, 113);
            this.numPrice.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numPrice.Name = "numPrice";
            this.numPrice.Size = new System.Drawing.Size(76, 20);
            this.numPrice.TabIndex = 2;
            this.numPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonBrowser
            // 
            this.buttonBrowser.Location = new System.Drawing.Point(134, 113);
            this.buttonBrowser.Name = "buttonBrowser";
            this.buttonBrowser.Size = new System.Drawing.Size(100, 20);
            this.buttonBrowser.TabIndex = 3;
            this.buttonBrowser.Text = "Browser";
            this.buttonBrowser.UseVisualStyleBackColor = true;
            this.buttonBrowser.Click += new System.EventHandler(this.buttonBrowser_Click);
            // 
            // textGrade
            // 
            this.textGrade.Enabled = false;
            this.textGrade.Location = new System.Drawing.Point(134, 65);
            this.textGrade.Name = "textGrade";
            this.textGrade.Size = new System.Drawing.Size(100, 20);
            this.textGrade.TabIndex = 5;
            this.textGrade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(131, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Grade:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Price:";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(12, 196);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(244, 23);
            this.buttonSave.TabIndex = 8;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // skipCheck
            // 
            this.skipCheck.AutoSize = true;
            this.skipCheck.Location = new System.Drawing.Point(13, 115);
            this.skipCheck.Name = "skipCheck";
            this.skipCheck.Size = new System.Drawing.Size(15, 14);
            this.skipCheck.TabIndex = 9;
            this.skipCheck.UseVisualStyleBackColor = true;
            this.skipCheck.CheckedChanged += new System.EventHandler(this.skipCheck_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listPageItems);
            this.groupBox1.Location = new System.Drawing.Point(262, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(414, 207);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Consulted Items";
            // 
            // listPageItems
            // 
            this.listPageItems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listPageItems.HideSelection = false;
            this.listPageItems.Location = new System.Drawing.Point(6, 19);
            this.listPageItems.Name = "listPageItems";
            this.listPageItems.Size = new System.Drawing.Size(402, 182);
            this.listPageItems.TabIndex = 0;
            this.listPageItems.UseCompatibleStateImageBehavior = false;
            this.listPageItems.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Price";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Grade";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Distance";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Yard";
            this.columnHeader4.Width = 159;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.skipCheck);
            this.groupBox2.Controls.Add(this.textIC);
            this.groupBox2.Controls.Add(this.numPrice);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.buttonBrowser);
            this.groupBox2.Controls.Add(this.textGrade);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(244, 178);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Direct Edit";
            // 
            // ItemEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 231);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ItemEditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ItemEditForm";
            this.Load += new System.EventHandler(this.ItemEditForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textIC;
        private System.Windows.Forms.NumericUpDown numPrice;
        private System.Windows.Forms.Button buttonBrowser;
        private System.Windows.Forms.TextBox textGrade;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.CheckBox skipCheck;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView listPageItems;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}