namespace Öğrenci_İşleri
{
    partial class ShowScoresHeadScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowScoresHeadScreen));
            this.ScoresGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ScoresGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ScoresGridView
            // 
            this.ScoresGridView.AllowUserToAddRows = false;
            this.ScoresGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.ScoresGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ScoresGridView.Location = new System.Drawing.Point(13, 13);
            this.ScoresGridView.Name = "ScoresGridView";
            this.ScoresGridView.Size = new System.Drawing.Size(630, 480);
            this.ScoresGridView.TabIndex = 0;
            // 
            // ShowScoresHeadScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 505);
            this.Controls.Add(this.ScoresGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ShowScoresHeadScreen";
            this.Text = "Öğrenci Notları";
            this.Load += new System.EventHandler(this.ShowScoresHeadScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ScoresGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ScoresGridView;
    }
}