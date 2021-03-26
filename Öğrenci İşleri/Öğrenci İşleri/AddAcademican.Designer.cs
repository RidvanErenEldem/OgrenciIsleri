namespace Öğrenci_İşleri
{
    partial class AddAcademican
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddAcademican));
            this.Cancel = new System.Windows.Forms.Button();
            this.OK = new System.Windows.Forms.Button();
            this.SurName = new System.Windows.Forms.TextBox();
            this.Names = new System.Windows.Forms.TextBox();
            this.Tc = new System.Windows.Forms.TextBox();
            this.UserName = new System.Windows.Forms.TextBox();
            this.Gender = new System.Windows.Forms.GroupBox();
            this.Men = new System.Windows.Forms.RadioButton();
            this.Women = new System.Windows.Forms.RadioButton();
            this.DepartmentPicker = new System.Windows.Forms.ComboBox();
            this.BolumPicker = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Yetki = new System.Windows.Forms.CheckBox();
            this.Gender.SuspendLayout();
            this.SuspendLayout();
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(14, 132);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(198, 89);
            this.Cancel.TabIndex = 10;
            this.Cancel.Text = "Vazgeç";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(350, 132);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(198, 89);
            this.OK.TabIndex = 9;
            this.OK.Text = "Onayla";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // SurName
            // 
            this.SurName.Location = new System.Drawing.Point(95, 42);
            this.SurName.Name = "SurName";
            this.SurName.Size = new System.Drawing.Size(143, 20);
            this.SurName.TabIndex = 1;
            // 
            // Names
            // 
            this.Names.Location = new System.Drawing.Point(95, 12);
            this.Names.Name = "Names";
            this.Names.Size = new System.Drawing.Size(143, 20);
            this.Names.TabIndex = 0;
            // 
            // Tc
            // 
            this.Tc.Location = new System.Drawing.Point(95, 72);
            this.Tc.MaxLength = 11;
            this.Tc.Name = "Tc";
            this.Tc.Size = new System.Drawing.Size(143, 20);
            this.Tc.TabIndex = 2;
            this.Tc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tc_KeyPress);
            // 
            // UserName
            // 
            this.UserName.Location = new System.Drawing.Point(95, 102);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(143, 20);
            this.UserName.TabIndex = 3;
            // 
            // Gender
            // 
            this.Gender.Controls.Add(this.Men);
            this.Gender.Controls.Add(this.Women);
            this.Gender.Location = new System.Drawing.Point(446, 5);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(103, 66);
            this.Gender.TabIndex = 6;
            this.Gender.TabStop = false;
            this.Gender.Text = "Cinsiyet";
            // 
            // Men
            // 
            this.Men.AutoSize = true;
            this.Men.Checked = true;
            this.Men.Location = new System.Drawing.Point(9, 19);
            this.Men.Name = "Men";
            this.Men.Size = new System.Drawing.Size(53, 17);
            this.Men.TabIndex = 7;
            this.Men.TabStop = true;
            this.Men.Text = "Erkek";
            this.Men.UseVisualStyleBackColor = true;
            // 
            // Women
            // 
            this.Women.AutoSize = true;
            this.Women.Location = new System.Drawing.Point(9, 42);
            this.Women.Name = "Women";
            this.Women.Size = new System.Drawing.Size(52, 17);
            this.Women.TabIndex = 8;
            this.Women.Text = "Kadın";
            this.Women.UseVisualStyleBackColor = true;
            // 
            // DepartmentPicker
            // 
            this.DepartmentPicker.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DepartmentPicker.FormattingEnabled = true;
            this.DepartmentPicker.Location = new System.Drawing.Point(299, 11);
            this.DepartmentPicker.Name = "DepartmentPicker";
            this.DepartmentPicker.Size = new System.Drawing.Size(140, 21);
            this.DepartmentPicker.TabIndex = 4;
            // 
            // BolumPicker
            // 
            this.BolumPicker.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BolumPicker.FormattingEnabled = true;
            this.BolumPicker.Location = new System.Drawing.Point(299, 46);
            this.BolumPicker.Name = "BolumPicker";
            this.BolumPicker.Size = new System.Drawing.Size(140, 21);
            this.BolumPicker.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Ad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Soyad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "T.C. Kimlik No:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(248, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Fakülte:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(254, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Bölüm:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Kullanıcı Adı";
            // 
            // Yetki
            // 
            this.Yetki.AutoSize = true;
            this.Yetki.Location = new System.Drawing.Point(251, 74);
            this.Yetki.Name = "Yetki";
            this.Yetki.Size = new System.Drawing.Size(59, 17);
            this.Yetki.TabIndex = 6;
            this.Yetki.Text = "Yetki ?";
            this.Yetki.UseVisualStyleBackColor = true;
            // 
            // AddAcademican
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 234);
            this.Controls.Add(this.Yetki);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DepartmentPicker);
            this.Controls.Add(this.BolumPicker);
            this.Controls.Add(this.Gender);
            this.Controls.Add(this.UserName);
            this.Controls.Add(this.Tc);
            this.Controls.Add(this.Names);
            this.Controls.Add(this.SurName);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.Cancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AddAcademican";
            this.Text = "Akademisyen Ekle";
            this.Load += new System.EventHandler(this.AddAcademican_Load);
            this.Gender.ResumeLayout(false);
            this.Gender.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.TextBox SurName;
        private System.Windows.Forms.TextBox Names;
        private System.Windows.Forms.TextBox Tc;
        private System.Windows.Forms.TextBox UserName;
        private System.Windows.Forms.GroupBox Gender;
        private System.Windows.Forms.RadioButton Men;
        private System.Windows.Forms.RadioButton Women;
        private System.Windows.Forms.ComboBox DepartmentPicker;
        private System.Windows.Forms.ComboBox BolumPicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox Yetki;
    }
}