namespace Öğrenci_İşleri
{
    partial class StudentScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentScreen));
            this.Welcome = new System.Windows.Forms.Label();
            this.LessonRegister = new System.Windows.Forms.Button();
            this.ShowScores = new System.Windows.Forms.Button();
            this.ChangePass = new System.Windows.Forms.Button();
            this.Logout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Welcome
            // 
            this.Welcome.AutoSize = true;
            this.Welcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Welcome.Location = new System.Drawing.Point(12, 9);
            this.Welcome.Name = "Welcome";
            this.Welcome.Size = new System.Drawing.Size(86, 18);
            this.Welcome.TabIndex = 0;
            this.Welcome.Text = "Hoş Geldin ";
            // 
            // LessonRegister
            // 
            this.LessonRegister.Location = new System.Drawing.Point(12, 34);
            this.LessonRegister.Name = "LessonRegister";
            this.LessonRegister.Size = new System.Drawing.Size(238, 72);
            this.LessonRegister.TabIndex = 0;
            this.LessonRegister.Text = "Ders Kaydı";
            this.LessonRegister.UseVisualStyleBackColor = true;
            this.LessonRegister.Click += new System.EventHandler(this.LessonRegister_Click);
            // 
            // ShowScores
            // 
            this.ShowScores.Location = new System.Drawing.Point(12, 116);
            this.ShowScores.Name = "ShowScores";
            this.ShowScores.Size = new System.Drawing.Size(238, 72);
            this.ShowScores.TabIndex = 1;
            this.ShowScores.Text = "Notları Göster";
            this.ShowScores.UseVisualStyleBackColor = true;
            this.ShowScores.Click += new System.EventHandler(this.ShowScores_Click);
            // 
            // ChangePass
            // 
            this.ChangePass.Location = new System.Drawing.Point(12, 198);
            this.ChangePass.Name = "ChangePass";
            this.ChangePass.Size = new System.Drawing.Size(238, 72);
            this.ChangePass.TabIndex = 2;
            this.ChangePass.Text = "Şifre Değiştir";
            this.ChangePass.UseVisualStyleBackColor = true;
            this.ChangePass.Click += new System.EventHandler(this.ChangePass_Click);
            // 
            // Logout
            // 
            this.Logout.Location = new System.Drawing.Point(12, 280);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(238, 72);
            this.Logout.TabIndex = 3;
            this.Logout.Text = "Güvenli Çıkış";
            this.Logout.UseVisualStyleBackColor = true;
            this.Logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // StudentScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 366);
            this.Controls.Add(this.Logout);
            this.Controls.Add(this.ChangePass);
            this.Controls.Add(this.ShowScores);
            this.Controls.Add(this.LessonRegister);
            this.Controls.Add(this.Welcome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "StudentScreen";
            this.Text = "Öğrenci Ekranı";
            this.Load += new System.EventHandler(this.StudentScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Welcome;
        private System.Windows.Forms.Button LessonRegister;
        private System.Windows.Forms.Button ShowScores;
        private System.Windows.Forms.Button ChangePass;
        private System.Windows.Forms.Button Logout;
    }
}