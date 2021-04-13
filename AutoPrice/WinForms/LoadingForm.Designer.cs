
namespace AutoPrice
{
    partial class LoadingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoadingForm));
            this.progressLoading = new System.Windows.Forms.ProgressBar();
            this.countLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // progressLoading
            // 
            this.progressLoading.Location = new System.Drawing.Point(12, 12);
            this.progressLoading.Name = "progressLoading";
            this.progressLoading.Size = new System.Drawing.Size(385, 23);
            this.progressLoading.Step = 1;
            this.progressLoading.TabIndex = 0;
            // 
            // countLabel
            // 
            this.countLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countLabel.Location = new System.Drawing.Point(303, 44);
            this.countLabel.Name = "countLabel";
            this.countLabel.Size = new System.Drawing.Size(94, 16);
            this.countLabel.TabIndex = 2;
            this.countLabel.Text = "000 out of 000";
            // 
            // LoadingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 69);
            this.ControlBox = false;
            this.Controls.Add(this.countLabel);
            this.Controls.Add(this.progressLoading);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoadingForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loading";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressLoading;
        private System.Windows.Forms.Label countLabel;
    }
}