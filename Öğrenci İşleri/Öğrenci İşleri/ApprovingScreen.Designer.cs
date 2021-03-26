namespace Öğrenci_İşleri
{
    partial class ApprovingScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ApprovingScreen));
            this.ApproveGrid = new System.Windows.Forms.DataGridView();
            this.Cancel = new System.Windows.Forms.Button();
            this.OK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ApproveGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // ApproveGrid
            // 
            this.ApproveGrid.AllowUserToAddRows = false;
            this.ApproveGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.ApproveGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ApproveGrid.Location = new System.Drawing.Point(13, 13);
            this.ApproveGrid.Name = "ApproveGrid";
            this.ApproveGrid.Size = new System.Drawing.Size(306, 350);
            this.ApproveGrid.TabIndex = 0;
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(12, 369);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(100, 49);
            this.Cancel.TabIndex = 2;
            this.Cancel.Text = "Vazgeç";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(219, 369);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(100, 49);
            this.OK.TabIndex = 1;
            this.OK.Text = "Onayla";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // ApprovingScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 429);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.ApproveGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ApprovingScreen";
            this.Text = "Ders Onaylama";
            this.Load += new System.EventHandler(this.ApprovingScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ApproveGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ApproveGrid;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button OK;
    }
}