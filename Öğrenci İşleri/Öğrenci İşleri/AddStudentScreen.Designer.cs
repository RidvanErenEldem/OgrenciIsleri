namespace Öğrenci_İşleri
{
    partial class AddStudentScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddStudentScreen));
            this.StudentName = new System.Windows.Forms.TextBox();
            this.StudentNumber = new System.Windows.Forms.TextBox();
            this.StudentSurname = new System.Windows.Forms.TextBox();
            this.StudentUserName = new System.Windows.Forms.TextBox();
            this.GenderSelect = new System.Windows.Forms.GroupBox();
            this.Women = new System.Windows.Forms.RadioButton();
            this.Men = new System.Windows.Forms.RadioButton();
            this.OK = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.GenderSelect.SuspendLayout();
            this.SuspendLayout();
            // 
            // StudentName
            // 
            this.StudentName.Location = new System.Drawing.Point(125, 42);
            this.StudentName.Name = "StudentName";
            this.StudentName.Size = new System.Drawing.Size(181, 20);
            this.StudentName.TabIndex = 1;
            // 
            // StudentNumber
            // 
            this.StudentNumber.Location = new System.Drawing.Point(127, 12);
            this.StudentNumber.MaxLength = 9;
            this.StudentNumber.Name = "StudentNumber";
            this.StudentNumber.Size = new System.Drawing.Size(181, 20);
            this.StudentNumber.TabIndex = 0;
            this.StudentNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.StudentNumber_KeyPress);
            // 
            // StudentSurname
            // 
            this.StudentSurname.Location = new System.Drawing.Point(125, 72);
            this.StudentSurname.Name = "StudentSurname";
            this.StudentSurname.Size = new System.Drawing.Size(181, 20);
            this.StudentSurname.TabIndex = 2;
            // 
            // StudentUserName
            // 
            this.StudentUserName.Location = new System.Drawing.Point(125, 102);
            this.StudentUserName.Name = "StudentUserName";
            this.StudentUserName.Size = new System.Drawing.Size(181, 20);
            this.StudentUserName.TabIndex = 3;
            // 
            // GenderSelect
            // 
            this.GenderSelect.Controls.Add(this.Women);
            this.GenderSelect.Controls.Add(this.Men);
            this.GenderSelect.Location = new System.Drawing.Point(314, 6);
            this.GenderSelect.Name = "GenderSelect";
            this.GenderSelect.Size = new System.Drawing.Size(74, 70);
            this.GenderSelect.TabIndex = 1;
            this.GenderSelect.TabStop = false;
            this.GenderSelect.Text = "Cinsiyet";
            // 
            // Women
            // 
            this.Women.AutoSize = true;
            this.Women.Location = new System.Drawing.Point(7, 42);
            this.Women.Name = "Women";
            this.Women.Size = new System.Drawing.Size(52, 17);
            this.Women.TabIndex = 5;
            this.Women.TabStop = true;
            this.Women.Text = "Kadın";
            this.Women.UseVisualStyleBackColor = true;
            // 
            // Men
            // 
            this.Men.AutoSize = true;
            this.Men.Checked = true;
            this.Men.Location = new System.Drawing.Point(6, 19);
            this.Men.Name = "Men";
            this.Men.Size = new System.Drawing.Size(53, 17);
            this.Men.TabIndex = 4;
            this.Men.TabStop = true;
            this.Men.Text = "Erkek";
            this.Men.UseVisualStyleBackColor = true;
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(236, 132);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(152, 69);
            this.OK.TabIndex = 6;
            this.OK.Text = "Ekle";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(12, 132);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(152, 69);
            this.Cancel.TabIndex = 7;
            this.Cancel.Text = "Vazgeç";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Öğrenci Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Öğrenci Soyadı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ögrenci Numarası:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Öğrenci Kullanıcı Adı:";
            // 
            // AddStudentScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 208);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.GenderSelect);
            this.Controls.Add(this.StudentUserName);
            this.Controls.Add(this.StudentSurname);
            this.Controls.Add(this.StudentNumber);
            this.Controls.Add(this.StudentName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AddStudentScreen";
            this.Text = "Öğrenci Ekle";
            this.GenderSelect.ResumeLayout(false);
            this.GenderSelect.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox StudentName;
        private System.Windows.Forms.TextBox StudentNumber;
        private System.Windows.Forms.TextBox StudentSurname;
        private System.Windows.Forms.TextBox StudentUserName;
        private System.Windows.Forms.GroupBox GenderSelect;
        private System.Windows.Forms.RadioButton Women;
        private System.Windows.Forms.RadioButton Men;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}