namespace Öğrenci_İşleri
{
    partial class AcademicianScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AcademicianScreen));
            this.HeadOfDepartmentBtn = new System.Windows.Forms.Button();
            this.ChooseLesson = new System.Windows.Forms.ComboBox();
            this.ScoreSetterGrid = new System.Windows.Forms.DataGridView();
            this.StudentShow = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Logout = new System.Windows.Forms.Button();
            this.Change = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Welcome = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ScoreSetterGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // HeadOfDepartmentBtn
            // 
            this.HeadOfDepartmentBtn.Location = new System.Drawing.Point(16, 693);
            this.HeadOfDepartmentBtn.Name = "HeadOfDepartmentBtn";
            this.HeadOfDepartmentBtn.Size = new System.Drawing.Size(270, 40);
            this.HeadOfDepartmentBtn.TabIndex = 2;
            this.HeadOfDepartmentBtn.Text = "Bölüm Başkanı Paneli";
            this.HeadOfDepartmentBtn.UseVisualStyleBackColor = true;
            this.HeadOfDepartmentBtn.Click += new System.EventHandler(this.HeadOfDepartmentBtn_Click);
            // 
            // ChooseLesson
            // 
            this.ChooseLesson.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ChooseLesson.FormattingEnabled = true;
            this.ChooseLesson.Location = new System.Drawing.Point(299, 40);
            this.ChooseLesson.Name = "ChooseLesson";
            this.ChooseLesson.Size = new System.Drawing.Size(550, 21);
            this.ChooseLesson.TabIndex = 0;
            this.ChooseLesson.SelectedIndexChanged += new System.EventHandler(this.ChooseLesson_SelectedIndexChanged);
            // 
            // ScoreSetterGrid
            // 
            this.ScoreSetterGrid.AllowUserToAddRows = false;
            this.ScoreSetterGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.ScoreSetterGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ScoreSetterGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StudentShow});
            this.ScoreSetterGrid.Location = new System.Drawing.Point(16, 67);
            this.ScoreSetterGrid.Name = "ScoreSetterGrid";
            this.ScoreSetterGrid.Size = new System.Drawing.Size(832, 620);
            this.ScoreSetterGrid.TabIndex = 1;
            this.ScoreSetterGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ScoreSetterGrid_CellContentClick);
            this.ScoreSetterGrid.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.ScoreSetterGrid_CellEndEdit);
            // 
            // StudentShow
            // 
            this.StudentShow.HeaderText = "Öğrenci Bilgilerini Göster";
            this.StudentShow.Name = "StudentShow";
            this.StudentShow.Text = "Öğrenci Bilgilerini Göster";
            this.StudentShow.UseColumnTextForButtonValue = true;
            this.StudentShow.Width = 70;
            // 
            // Logout
            // 
            this.Logout.Location = new System.Drawing.Point(579, 693);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(270, 40);
            this.Logout.TabIndex = 4;
            this.Logout.Text = "Güvenli Çıkış";
            this.Logout.UseVisualStyleBackColor = true;
            this.Logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // Change
            // 
            this.Change.Location = new System.Drawing.Point(296, 693);
            this.Change.Name = "Change";
            this.Change.Size = new System.Drawing.Size(270, 40);
            this.Change.TabIndex = 3;
            this.Change.Text = "Şifremi Değiştir";
            this.Change.UseVisualStyleBackColor = true;
            this.Change.Click += new System.EventHandler(this.Change_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Not Girişi Yapılacak Olan Dersi Seçiniz:";
            // 
            // Welcome
            // 
            this.Welcome.AutoSize = true;
            this.Welcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Welcome.Location = new System.Drawing.Point(13, 9);
            this.Welcome.Name = "Welcome";
            this.Welcome.Size = new System.Drawing.Size(86, 18);
            this.Welcome.TabIndex = 6;
            this.Welcome.Text = "Hoş Geldin ";
            // 
            // AcademicianScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 743);
            this.Controls.Add(this.Welcome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ScoreSetterGrid);
            this.Controls.Add(this.ChooseLesson);
            this.Controls.Add(this.Logout);
            this.Controls.Add(this.Change);
            this.Controls.Add(this.HeadOfDepartmentBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AcademicianScreen";
            this.Text = "Akademisyen Ekranı";
            this.Load += new System.EventHandler(this.AcademicianScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ScoreSetterGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button HeadOfDepartmentBtn;
        private System.Windows.Forms.ComboBox ChooseLesson;
        private System.Windows.Forms.DataGridView ScoreSetterGrid;
        private System.Windows.Forms.DataGridViewButtonColumn StudentShow;
        private System.Windows.Forms.Button Logout;
        private System.Windows.Forms.Button Change;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Welcome;
    }
}