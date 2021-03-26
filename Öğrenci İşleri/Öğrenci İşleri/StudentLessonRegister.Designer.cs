namespace Öğrenci_İşleri
{
    partial class StudentLessonRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentLessonRegister));
            this.OK = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.RegisterGrid = new System.Windows.Forms.DataGridView();
            this.Checker = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.RegisterGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(445, 474);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(166, 69);
            this.OK.TabIndex = 2;
            this.OK.Text = "Onayla";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(12, 474);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(166, 69);
            this.Cancel.TabIndex = 1;
            this.Cancel.Text = "Vazgeç";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // RegisterGrid
            // 
            this.RegisterGrid.AllowUserToAddRows = false;
            this.RegisterGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.RegisterGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RegisterGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Checker});
            this.RegisterGrid.Location = new System.Drawing.Point(12, 12);
            this.RegisterGrid.Name = "RegisterGrid";
            this.RegisterGrid.Size = new System.Drawing.Size(599, 456);
            this.RegisterGrid.TabIndex = 0;
            // 
            // Checker
            // 
            this.Checker.HeaderText = "Dersi Al";
            this.Checker.Name = "Checker";
            // 
            // StudentLessonRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 555);
            this.Controls.Add(this.RegisterGrid);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.OK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "StudentLessonRegister";
            this.Text = "Öğrenci Ders Kaydı";
            this.Load += new System.EventHandler(this.StudentLessonRegister_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RegisterGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.DataGridView RegisterGrid;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Checker;
    }
}