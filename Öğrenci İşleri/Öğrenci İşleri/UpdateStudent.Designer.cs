namespace Öğrenci_İşleri
{
    partial class UpdateStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateStudent));
            this.EditedStudentName = new System.Windows.Forms.TextBox();
            this.EditedStudentSurname = new System.Windows.Forms.TextBox();
            this.EditedNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Cancel = new System.Windows.Forms.Button();
            this.OK = new System.Windows.Forms.Button();
            this.genderSelector = new System.Windows.Forms.GroupBox();
            this.Women = new System.Windows.Forms.RadioButton();
            this.Men = new System.Windows.Forms.RadioButton();
            this.genderSelector.SuspendLayout();
            this.SuspendLayout();
            // 
            // EditedStudentName
            // 
            this.EditedStudentName.Location = new System.Drawing.Point(121, 12);
            this.EditedStudentName.Name = "EditedStudentName";
            this.EditedStudentName.Size = new System.Drawing.Size(117, 20);
            this.EditedStudentName.TabIndex = 0;
            // 
            // EditedStudentSurname
            // 
            this.EditedStudentSurname.Location = new System.Drawing.Point(121, 49);
            this.EditedStudentSurname.Name = "EditedStudentSurname";
            this.EditedStudentSurname.Size = new System.Drawing.Size(117, 20);
            this.EditedStudentSurname.TabIndex = 1;
            // 
            // EditedNumber
            // 
            this.EditedNumber.Location = new System.Drawing.Point(121, 84);
            this.EditedNumber.MaxLength = 9;
            this.EditedNumber.Name = "EditedNumber";
            this.EditedNumber.Size = new System.Drawing.Size(117, 20);
            this.EditedNumber.TabIndex = 2;
            this.EditedNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EditedNumber_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Yeni Ad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Yeni Soyad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Yeni Okul Numarası:";
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(12, 121);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(151, 64);
            this.Cancel.TabIndex = 6;
            this.Cancel.Text = "Vazgeç";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(191, 121);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(151, 64);
            this.OK.TabIndex = 5;
            this.OK.Text = "Güncelle";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // genderSelector
            // 
            this.genderSelector.Controls.Add(this.Women);
            this.genderSelector.Controls.Add(this.Men);
            this.genderSelector.Location = new System.Drawing.Point(244, 12);
            this.genderSelector.Name = "genderSelector";
            this.genderSelector.Size = new System.Drawing.Size(98, 88);
            this.genderSelector.TabIndex = 6;
            this.genderSelector.TabStop = false;
            this.genderSelector.Text = "Yeni Cinsiyet";
            // 
            // Women
            // 
            this.Women.AutoSize = true;
            this.Women.Location = new System.Drawing.Point(6, 52);
            this.Women.Name = "Women";
            this.Women.Size = new System.Drawing.Size(52, 17);
            this.Women.TabIndex = 4;
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
            this.Men.TabIndex = 3;
            this.Men.TabStop = true;
            this.Men.Text = "Erkek";
            this.Men.UseVisualStyleBackColor = true;
            // 
            // UpdateStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 193);
            this.Controls.Add(this.genderSelector);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EditedNumber);
            this.Controls.Add(this.EditedStudentSurname);
            this.Controls.Add(this.EditedStudentName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "UpdateStudent";
            this.Text = "Öğrenci Güncelle";
            this.Load += new System.EventHandler(this.UpdateStudent_Load);
            this.genderSelector.ResumeLayout(false);
            this.genderSelector.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox EditedStudentName;
        private System.Windows.Forms.TextBox EditedStudentSurname;
        private System.Windows.Forms.TextBox EditedNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.GroupBox genderSelector;
        private System.Windows.Forms.RadioButton Women;
        private System.Windows.Forms.RadioButton Men;
    }
}