namespace Öğrenci_İşleri
{
    partial class ShowScoresStudentScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowScoresStudentScreen));
            this.PeriodPicker = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.StudentScores = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.StudentScores)).BeginInit();
            this.SuspendLayout();
            // 
            // PeriodPicker
            // 
            this.PeriodPicker.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PeriodPicker.FormattingEnabled = true;
            this.PeriodPicker.Location = new System.Drawing.Point(109, 13);
            this.PeriodPicker.Name = "PeriodPicker";
            this.PeriodPicker.Size = new System.Drawing.Size(494, 21);
            this.PeriodPicker.TabIndex = 0;
            this.PeriodPicker.SelectedIndexChanged += new System.EventHandler(this.PeriodPicker_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dönem Seç:";
            // 
            // StudentScores
            // 
            this.StudentScores.AllowUserToAddRows = false;
            this.StudentScores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentScores.Location = new System.Drawing.Point(12, 40);
            this.StudentScores.Name = "StudentScores";
            this.StudentScores.Size = new System.Drawing.Size(591, 472);
            this.StudentScores.TabIndex = 1;
            // 
            // ShowScoresStudentScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 524);
            this.Controls.Add(this.StudentScores);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PeriodPicker);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ShowScoresStudentScreen";
            this.Text = "Notlar";
            this.Load += new System.EventHandler(this.ShowScoresStudentScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StudentScores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox PeriodPicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView StudentScores;
    }
}