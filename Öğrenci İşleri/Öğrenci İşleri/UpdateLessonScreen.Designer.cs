namespace Öğrenci_İşleri
{
    partial class UpdateLessonScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateLessonScreen));
            this.EditedLessonName = new System.Windows.Forms.TextBox();
            this.EditedAcademicanPicker = new System.Windows.Forms.ComboBox();
            this.Cancel = new System.Windows.Forms.Button();
            this.OK = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // EditedLessonName
            // 
            this.EditedLessonName.Location = new System.Drawing.Point(115, 12);
            this.EditedLessonName.Name = "EditedLessonName";
            this.EditedLessonName.Size = new System.Drawing.Size(237, 20);
            this.EditedLessonName.TabIndex = 0;
            // 
            // EditedAcademicanPicker
            // 
            this.EditedAcademicanPicker.FormattingEnabled = true;
            this.EditedAcademicanPicker.Location = new System.Drawing.Point(115, 42);
            this.EditedAcademicanPicker.Name = "EditedAcademicanPicker";
            this.EditedAcademicanPicker.Size = new System.Drawing.Size(237, 21);
            this.EditedAcademicanPicker.TabIndex = 1;
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(15, 72);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(137, 60);
            this.Cancel.TabIndex = 3;
            this.Cancel.Text = "Vazgeç";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(215, 72);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(137, 60);
            this.OK.TabIndex = 2;
            this.OK.Text = "Güncelle";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Yeni Ders Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Yeni Akademisyen:";
            // 
            // UpdateLessonScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 139);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.EditedAcademicanPicker);
            this.Controls.Add(this.EditedLessonName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "UpdateLessonScreen";
            this.Text = "Dersi Güncelle";
            this.Load += new System.EventHandler(this.UpdateLessonScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox EditedLessonName;
        private System.Windows.Forms.ComboBox EditedAcademicanPicker;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}