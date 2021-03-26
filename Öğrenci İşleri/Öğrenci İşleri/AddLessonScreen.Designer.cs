namespace Öğrenci_İşleri
{
    partial class AddLessonScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddLessonScreen));
            this.LessonName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Credit = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.IsShared = new System.Windows.Forms.CheckBox();
            this.AcademicianPicker = new System.Windows.Forms.ComboBox();
            this.PeriodPicker = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CancelAddLesson = new System.Windows.Forms.Button();
            this.AddLessonBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LessonName
            // 
            this.LessonName.Location = new System.Drawing.Point(64, 15);
            this.LessonName.Name = "LessonName";
            this.LessonName.Size = new System.Drawing.Size(100, 20);
            this.LessonName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ders Adı:";
            // 
            // Credit
            // 
            this.Credit.Location = new System.Drawing.Point(255, 15);
            this.Credit.MaxLength = 1;
            this.Credit.Name = "Credit";
            this.Credit.Size = new System.Drawing.Size(40, 20);
            this.Credit.TabIndex = 1;
            this.Credit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Credit_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(184, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kredi Miktari:";
            // 
            // IsShared
            // 
            this.IsShared.AutoSize = true;
            this.IsShared.Location = new System.Drawing.Point(311, 18);
            this.IsShared.Name = "IsShared";
            this.IsShared.Size = new System.Drawing.Size(86, 17);
            this.IsShared.TabIndex = 2;
            this.IsShared.Text = "Ortak Ders ?";
            this.IsShared.UseVisualStyleBackColor = true;
            this.IsShared.CheckedChanged += new System.EventHandler(this.IsShared_CheckedChanged);
            // 
            // AcademicianPicker
            // 
            this.AcademicianPicker.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AcademicianPicker.FormattingEnabled = true;
            this.AcademicianPicker.Location = new System.Drawing.Point(88, 51);
            this.AcademicianPicker.Name = "AcademicianPicker";
            this.AcademicianPicker.Size = new System.Drawing.Size(100, 21);
            this.AcademicianPicker.TabIndex = 3;
            // 
            // PeriodPicker
            // 
            this.PeriodPicker.FormattingEnabled = true;
            this.PeriodPicker.Location = new System.Drawing.Point(267, 51);
            this.PeriodPicker.Name = "PeriodPicker";
            this.PeriodPicker.Size = new System.Drawing.Size(100, 21);
            this.PeriodPicker.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Akademisyen:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(217, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Dönem:";
            // 
            // CancelAddLesson
            // 
            this.CancelAddLesson.Location = new System.Drawing.Point(12, 87);
            this.CancelAddLesson.Name = "CancelAddLesson";
            this.CancelAddLesson.Size = new System.Drawing.Size(190, 69);
            this.CancelAddLesson.TabIndex = 6;
            this.CancelAddLesson.Text = "Vazgeç";
            this.CancelAddLesson.UseVisualStyleBackColor = true;
            this.CancelAddLesson.Click += new System.EventHandler(this.CancelAddLesson_Click);
            // 
            // AddLessonBtn
            // 
            this.AddLessonBtn.Location = new System.Drawing.Point(207, 87);
            this.AddLessonBtn.Name = "AddLessonBtn";
            this.AddLessonBtn.Size = new System.Drawing.Size(190, 69);
            this.AddLessonBtn.TabIndex = 5;
            this.AddLessonBtn.Text = "Ders Ekle";
            this.AddLessonBtn.UseVisualStyleBackColor = true;
            this.AddLessonBtn.Click += new System.EventHandler(this.AddLessonBtn_Click);
            // 
            // AddLessonScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 168);
            this.Controls.Add(this.AddLessonBtn);
            this.Controls.Add(this.CancelAddLesson);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PeriodPicker);
            this.Controls.Add(this.AcademicianPicker);
            this.Controls.Add(this.IsShared);
            this.Controls.Add(this.Credit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LessonName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AddLessonScreen";
            this.Text = "Ders Ekle";
            this.Load += new System.EventHandler(this.AddLessonScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox LessonName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Credit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox IsShared;
        private System.Windows.Forms.ComboBox AcademicianPicker;
        private System.Windows.Forms.ComboBox PeriodPicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button CancelAddLesson;
        private System.Windows.Forms.Button AddLessonBtn;
    }
}