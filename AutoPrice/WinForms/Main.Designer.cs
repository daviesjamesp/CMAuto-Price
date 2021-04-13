
namespace AutoPrice
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sessionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tryPyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oFD = new System.Windows.Forms.OpenFileDialog();
            this.sFD = new System.Windows.Forms.SaveFileDialog();
            this.dataSet1 = new System.Data.DataSet();
            this.partDataGrid = new System.Windows.Forms.DataGridView();
            this.cIndex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cInterchange = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cGrade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cIncluded = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cExcluded = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNotes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mainMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.exportToolStripMenuItem,
            this.importToolStripMenuItem,
            this.sessionToolStripMenuItem,
            this.tryPyToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mainMenuStrip.Size = new System.Drawing.Size(770, 24);
            this.mainMenuStrip.TabIndex = 4;
            this.mainMenuStrip.Text = "menuStrip1";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("settingsToolStripMenuItem.Image")));
            this.settingsToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("exportToolStripMenuItem.Image")));
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.exportToolStripMenuItem.Text = "Export";
            this.exportToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.exportToolStripMenuItem.Click += new System.EventHandler(this.exportToolStripMenuItem_Click);
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("importToolStripMenuItem.Image")));
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.importToolStripMenuItem.Text = "Import";
            this.importToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.importToolStripMenuItem.Click += new System.EventHandler(this.importToolStripMenuItem_Click);
            // 
            // sessionToolStripMenuItem
            // 
            this.sessionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.openToolStripMenuItem});
            this.sessionToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("sessionToolStripMenuItem.Image")));
            this.sessionToolStripMenuItem.Name = "sessionToolStripMenuItem";
            this.sessionToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.sessionToolStripMenuItem.Text = "Session";
            this.sessionToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // tryPyToolStripMenuItem
            // 
            this.tryPyToolStripMenuItem.Name = "tryPyToolStripMenuItem";
            this.tryPyToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.tryPyToolStripMenuItem.Text = "TryPy";
            this.tryPyToolStripMenuItem.Click += new System.EventHandler(this.tryPyToolStripMenuItem_Click);
            // 
            // oFD
            // 
            this.oFD.DefaultExt = "sess";
            this.oFD.FileName = "oFD";
            this.oFD.Filter = "Session|*.sess";
            this.oFD.Title = "Open Session";
            // 
            // sFD
            // 
            this.sFD.DefaultExt = "sess";
            this.sFD.Title = "Save Session";
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "NewDataSet";
            // 
            // partDataGrid
            // 
            this.partDataGrid.AllowUserToAddRows = false;
            this.partDataGrid.AllowUserToDeleteRows = false;
            this.partDataGrid.AllowUserToResizeColumns = false;
            this.partDataGrid.AllowUserToResizeRows = false;
            this.partDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.partDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.partDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cIndex,
            this.cPart,
            this.cInterchange,
            this.cGrade,
            this.cPrice,
            this.cIncluded,
            this.cExcluded,
            this.cNotes});
            this.partDataGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.partDataGrid.Location = new System.Drawing.Point(12, 63);
            this.partDataGrid.Name = "partDataGrid";
            this.partDataGrid.RowTemplate.ReadOnly = true;
            this.partDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.partDataGrid.Size = new System.Drawing.Size(746, 656);
            this.partDataGrid.TabIndex = 5;
            // 
            // cIndex
            // 
            this.cIndex.HeaderText = "Index";
            this.cIndex.Name = "cIndex";
            this.cIndex.ReadOnly = true;
            this.cIndex.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cIndex.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cIndex.Width = 50;
            // 
            // cPart
            // 
            this.cPart.HeaderText = "Part";
            this.cPart.Name = "cPart";
            this.cPart.ReadOnly = true;
            this.cPart.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cPart.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cPart.Width = 75;
            // 
            // cInterchange
            // 
            this.cInterchange.HeaderText = "Interchange";
            this.cInterchange.Name = "cInterchange";
            this.cInterchange.ReadOnly = true;
            this.cInterchange.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cInterchange.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cGrade
            // 
            this.cGrade.HeaderText = "Grade";
            this.cGrade.Name = "cGrade";
            this.cGrade.ReadOnly = true;
            this.cGrade.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cGrade.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cGrade.Width = 50;
            // 
            // cPrice
            // 
            this.cPrice.HeaderText = "Price";
            this.cPrice.Name = "cPrice";
            this.cPrice.ReadOnly = true;
            this.cPrice.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cPrice.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cPrice.Width = 75;
            // 
            // cIncluded
            // 
            this.cIncluded.HeaderText = "Inc.";
            this.cIncluded.Name = "cIncluded";
            this.cIncluded.ReadOnly = true;
            this.cIncluded.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cIncluded.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cIncluded.Width = 50;
            // 
            // cExcluded
            // 
            this.cExcluded.HeaderText = "Exc.";
            this.cExcluded.Name = "cExcluded";
            this.cExcluded.ReadOnly = true;
            this.cExcluded.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cExcluded.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cExcluded.Width = 50;
            // 
            // cNotes
            // 
            this.cNotes.HeaderText = "Notes";
            this.cNotes.Name = "cNotes";
            this.cNotes.ReadOnly = true;
            this.cNotes.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cNotes.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cNotes.Width = 250;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 731);
            this.Controls.Add(this.partDataGrid);
            this.Controls.Add(this.mainMenuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mainMenuStrip;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Auto-Price";
            this.Load += new System.EventHandler(this.Main_Load);
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tryPyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sessionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog oFD;
        private System.Windows.Forms.SaveFileDialog sFD;
        private System.Data.DataSet dataSet1;
        private System.Windows.Forms.DataGridView partDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIndex;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPart;
        private System.Windows.Forms.DataGridViewTextBoxColumn cInterchange;
        private System.Windows.Forms.DataGridViewTextBoxColumn cGrade;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIncluded;
        private System.Windows.Forms.DataGridViewTextBoxColumn cExcluded;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNotes;
    }
}

