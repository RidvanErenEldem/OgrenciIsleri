namespace Öğrenci_İşleri
{
    partial class PasswordChangeScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PasswordChangeScreen));
            this.Cancel = new System.Windows.Forms.Button();
            this.OK = new System.Windows.Forms.Button();
            this.OldPass = new System.Windows.Forms.TextBox();
            this.NewPass = new System.Windows.Forms.TextBox();
            this.ConfirmNewPass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ShowPassOld = new System.Windows.Forms.Button();
            this.ShopPassCon = new System.Windows.Forms.Button();
            this.ShowPassNew = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(15, 111);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(110, 55);
            this.Cancel.TabIndex = 6;
            this.Cancel.Text = "Vazgeç";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(189, 111);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(110, 55);
            this.OK.TabIndex = 7;
            this.OK.Text = "Onayla";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // OldPass
            // 
            this.OldPass.Location = new System.Drawing.Point(107, 14);
            this.OldPass.Name = "OldPass";
            this.OldPass.Size = new System.Drawing.Size(148, 20);
            this.OldPass.TabIndex = 0;
            this.OldPass.UseSystemPasswordChar = true;
            // 
            // NewPass
            // 
            this.NewPass.Location = new System.Drawing.Point(107, 44);
            this.NewPass.Name = "NewPass";
            this.NewPass.Size = new System.Drawing.Size(148, 20);
            this.NewPass.TabIndex = 2;
            this.NewPass.UseSystemPasswordChar = true;
            // 
            // ConfirmNewPass
            // 
            this.ConfirmNewPass.Location = new System.Drawing.Point(107, 74);
            this.ConfirmNewPass.Name = "ConfirmNewPass";
            this.ConfirmNewPass.Size = new System.Drawing.Size(148, 20);
            this.ConfirmNewPass.TabIndex = 4;
            this.ConfirmNewPass.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Eski Şifre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Yeni Şifre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Yeni Şifre Tekrar:";
            // 
            // ShowPassOld
            // 
            this.ShowPassOld.Image = global::Öğrenci_İşleri.Properties.Resources.eye_38x201;
            this.ShowPassOld.Location = new System.Drawing.Point(261, 14);
            this.ShowPassOld.Name = "ShowPassOld";
            this.ShowPassOld.Size = new System.Drawing.Size(38, 20);
            this.ShowPassOld.TabIndex = 1;
            this.ShowPassOld.UseVisualStyleBackColor = true;
            this.ShowPassOld.Click += new System.EventHandler(this.ShowPassOld_Click);
            // 
            // ShopPassCon
            // 
            this.ShopPassCon.Image = global::Öğrenci_İşleri.Properties.Resources.eye_38x201;
            this.ShopPassCon.Location = new System.Drawing.Point(261, 74);
            this.ShopPassCon.Name = "ShopPassCon";
            this.ShopPassCon.Size = new System.Drawing.Size(38, 20);
            this.ShopPassCon.TabIndex = 5;
            this.ShopPassCon.UseVisualStyleBackColor = true;
            this.ShopPassCon.Click += new System.EventHandler(this.ShopPassCon_Click);
            // 
            // ShowPassNew
            // 
            this.ShowPassNew.Image = global::Öğrenci_İşleri.Properties.Resources.eye_38x201;
            this.ShowPassNew.Location = new System.Drawing.Point(261, 44);
            this.ShowPassNew.Name = "ShowPassNew";
            this.ShowPassNew.Size = new System.Drawing.Size(38, 20);
            this.ShowPassNew.TabIndex = 3;
            this.ShowPassNew.UseVisualStyleBackColor = true;
            this.ShowPassNew.Click += new System.EventHandler(this.ShowPassNew_Click);
            // 
            // PasswordChangeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 183);
            this.Controls.Add(this.ShowPassNew);
            this.Controls.Add(this.ShopPassCon);
            this.Controls.Add(this.ShowPassOld);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ConfirmNewPass);
            this.Controls.Add(this.NewPass);
            this.Controls.Add(this.OldPass);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.Cancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PasswordChangeScreen";
            this.Text = "Şifre Değiştirme";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.TextBox OldPass;
        private System.Windows.Forms.TextBox NewPass;
        private System.Windows.Forms.TextBox ConfirmNewPass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ShowPassOld;
        private System.Windows.Forms.Button ShopPassCon;
        private System.Windows.Forms.Button ShowPassNew;
    }
}