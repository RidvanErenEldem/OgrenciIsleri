namespace Öğrenci_İşleri
{
    partial class DeanScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeanScreen));
            this.AddDepartment = new System.Windows.Forms.Button();
            this.AddDivision = new System.Windows.Forms.Button();
            this.AddAcademican = new System.Windows.Forms.Button();
            this.SafeExit = new System.Windows.Forms.Button();
            this.DeanWelcome = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AddDepartment
            // 
            this.AddDepartment.Location = new System.Drawing.Point(12, 52);
            this.AddDepartment.Name = "AddDepartment";
            this.AddDepartment.Size = new System.Drawing.Size(238, 81);
            this.AddDepartment.TabIndex = 0;
            this.AddDepartment.Text = "Fakülte Ekle";
            this.AddDepartment.UseVisualStyleBackColor = true;
            this.AddDepartment.Click += new System.EventHandler(this.AddDepartment_Click);
            // 
            // AddDivision
            // 
            this.AddDivision.Location = new System.Drawing.Point(12, 147);
            this.AddDivision.Name = "AddDivision";
            this.AddDivision.Size = new System.Drawing.Size(238, 81);
            this.AddDivision.TabIndex = 1;
            this.AddDivision.Text = "Bölüm Ekle";
            this.AddDivision.UseVisualStyleBackColor = true;
            this.AddDivision.Click += new System.EventHandler(this.AddDivision_Click);
            // 
            // AddAcademican
            // 
            this.AddAcademican.Location = new System.Drawing.Point(12, 242);
            this.AddAcademican.Name = "AddAcademican";
            this.AddAcademican.Size = new System.Drawing.Size(238, 81);
            this.AddAcademican.TabIndex = 2;
            this.AddAcademican.Text = "Akademisyen Ekle";
            this.AddAcademican.UseVisualStyleBackColor = true;
            this.AddAcademican.Click += new System.EventHandler(this.AddAcademican_Click);
            // 
            // SafeExit
            // 
            this.SafeExit.Location = new System.Drawing.Point(15, 337);
            this.SafeExit.Name = "SafeExit";
            this.SafeExit.Size = new System.Drawing.Size(238, 81);
            this.SafeExit.TabIndex = 3;
            this.SafeExit.Text = "Güvenli Çıkış";
            this.SafeExit.UseVisualStyleBackColor = true;
            this.SafeExit.Click += new System.EventHandler(this.SafeExit_Click);
            // 
            // DeanWelcome
            // 
            this.DeanWelcome.AutoSize = true;
            this.DeanWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DeanWelcome.Location = new System.Drawing.Point(12, 9);
            this.DeanWelcome.Name = "DeanWelcome";
            this.DeanWelcome.Size = new System.Drawing.Size(89, 18);
            this.DeanWelcome.TabIndex = 4;
            this.DeanWelcome.Text = "Hoşgeldiniz ";
            // 
            // DeanScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 434);
            this.Controls.Add(this.DeanWelcome);
            this.Controls.Add(this.SafeExit);
            this.Controls.Add(this.AddAcademican);
            this.Controls.Add(this.AddDivision);
            this.Controls.Add(this.AddDepartment);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "DeanScreen";
            this.Text = "Dekan Ekranı";
            this.Load += new System.EventHandler(this.DeanScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddDepartment;
        private System.Windows.Forms.Button AddDivision;
        private System.Windows.Forms.Button AddAcademican;
        private System.Windows.Forms.Button SafeExit;
        private System.Windows.Forms.Label DeanWelcome;
    }
}