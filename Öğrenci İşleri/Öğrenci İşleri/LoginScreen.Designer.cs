namespace Öğrenci_İşleri
{
    partial class LoginScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginScreen));
            this.UserName = new System.Windows.Forms.TextBox();
            this.UserPass = new System.Windows.Forms.TextBox();
            this.StudentLogin = new System.Windows.Forms.Button();
            this.AcademicianLoginBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DeanLogin = new System.Windows.Forms.Button();
            this.Show = new System.Windows.Forms.Button();
            this.ShowPass = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UserName
            // 
            this.UserName.Location = new System.Drawing.Point(83, 12);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(246, 20);
            this.UserName.TabIndex = 0;
            // 
            // UserPass
            // 
            this.UserPass.Location = new System.Drawing.Point(83, 48);
            this.UserPass.Name = "UserPass";
            this.UserPass.Size = new System.Drawing.Size(198, 20);
            this.UserPass.TabIndex = 1;
            this.UserPass.UseSystemPasswordChar = true;
            // 
            // StudentLogin
            // 
            this.StudentLogin.Location = new System.Drawing.Point(16, 88);
            this.StudentLogin.Name = "StudentLogin";
            this.StudentLogin.Size = new System.Drawing.Size(86, 46);
            this.StudentLogin.TabIndex = 3;
            this.StudentLogin.Text = "Öğrenci Girişi";
            this.StudentLogin.UseVisualStyleBackColor = true;
            this.StudentLogin.Click += new System.EventHandler(this.StudentLogin_Click);
            // 
            // AcademicianLoginBtn
            // 
            this.AcademicianLoginBtn.Location = new System.Drawing.Point(243, 88);
            this.AcademicianLoginBtn.Name = "AcademicianLoginBtn";
            this.AcademicianLoginBtn.Size = new System.Drawing.Size(86, 46);
            this.AcademicianLoginBtn.TabIndex = 5;
            this.AcademicianLoginBtn.Text = "Akademisyen Girişi";
            this.AcademicianLoginBtn.UseVisualStyleBackColor = true;
            this.AcademicianLoginBtn.Click += new System.EventHandler(this.AcademicianLoginBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Şifre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kullanıcı Adı";
            // 
            // DeanLogin
            // 
            this.DeanLogin.Location = new System.Drawing.Point(133, 88);
            this.DeanLogin.Name = "DeanLogin";
            this.DeanLogin.Size = new System.Drawing.Size(86, 46);
            this.DeanLogin.TabIndex = 4;
            this.DeanLogin.Text = "Dekan Girişi";
            this.DeanLogin.UseVisualStyleBackColor = true;
            this.DeanLogin.Click += new System.EventHandler(this.DeanLogin_Click);
            // 
            // Show
            // 
            this.Show.Location = new System.Drawing.Point(291, 48);
            this.Show.Name = "Show";
            this.Show.Size = new System.Drawing.Size(38, 20);
            this.Show.TabIndex = 5;
            this.Show.UseVisualStyleBackColor = true;
            // 
            // ShowPass
            // 
            this.ShowPass.Image = global::Öğrenci_İşleri.Properties.Resources.eye_38x201;
            this.ShowPass.Location = new System.Drawing.Point(291, 48);
            this.ShowPass.Name = "ShowPass";
            this.ShowPass.Size = new System.Drawing.Size(38, 20);
            this.ShowPass.TabIndex = 2;
            this.ShowPass.UseVisualStyleBackColor = true;
            this.ShowPass.Click += new System.EventHandler(this.ShowPass_Click);
            // 
            // LoginScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 146);
            this.Controls.Add(this.ShowPass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AcademicianLoginBtn);
            this.Controls.Add(this.DeanLogin);
            this.Controls.Add(this.StudentLogin);
            this.Controls.Add(this.UserPass);
            this.Controls.Add(this.UserName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "LoginScreen";
            this.Text = "Giriş Ekranı";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoginScreen_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UserName;
        private System.Windows.Forms.TextBox UserPass;
        private System.Windows.Forms.Button StudentLogin;
        private System.Windows.Forms.Button AcademicianLoginBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button DeanLogin;
        private System.Windows.Forms.Button ShowPass;
        private System.Windows.Forms.Button Show;
    }
}