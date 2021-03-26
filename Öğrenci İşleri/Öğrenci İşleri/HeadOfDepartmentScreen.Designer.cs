namespace Öğrenci_İşleri
{
    partial class HeadOfDepartmentScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HeadOfDepartmentScreen));
            this.HeadOfDepartmentTabControl = new System.Windows.Forms.TabControl();
            this.LessonAdd = new System.Windows.Forms.TabPage();
            this.LessonGridView = new System.Windows.Forms.DataGridView();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.AddLesson = new System.Windows.Forms.Button();
            this.StudentAdd = new System.Windows.Forms.TabPage();
            this.AddStudentBtn = new System.Windows.Forms.Button();
            this.StudentGridView = new System.Windows.Forms.DataGridView();
            this.ShowScores = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ConfirmClass = new System.Windows.Forms.DataGridViewButtonColumn();
            this.DeleteStudent = new System.Windows.Forms.DataGridViewButtonColumn();
            this.EditStudent = new System.Windows.Forms.DataGridViewButtonColumn();
            this.HeadOfDepartmentTabControl.SuspendLayout();
            this.LessonAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LessonGridView)).BeginInit();
            this.StudentAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StudentGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // HeadOfDepartmentTabControl
            // 
            this.HeadOfDepartmentTabControl.Controls.Add(this.LessonAdd);
            this.HeadOfDepartmentTabControl.Controls.Add(this.StudentAdd);
            this.HeadOfDepartmentTabControl.Location = new System.Drawing.Point(13, 13);
            this.HeadOfDepartmentTabControl.Name = "HeadOfDepartmentTabControl";
            this.HeadOfDepartmentTabControl.SelectedIndex = 0;
            this.HeadOfDepartmentTabControl.Size = new System.Drawing.Size(894, 543);
            this.HeadOfDepartmentTabControl.TabIndex = 0;
            // 
            // LessonAdd
            // 
            this.LessonAdd.Controls.Add(this.LessonGridView);
            this.LessonAdd.Controls.Add(this.AddLesson);
            this.LessonAdd.Location = new System.Drawing.Point(4, 22);
            this.LessonAdd.Name = "LessonAdd";
            this.LessonAdd.Padding = new System.Windows.Forms.Padding(3);
            this.LessonAdd.Size = new System.Drawing.Size(886, 517);
            this.LessonAdd.TabIndex = 1;
            this.LessonAdd.Text = "Ders Sayfası";
            this.LessonAdd.UseVisualStyleBackColor = true;
            // 
            // LessonGridView
            // 
            this.LessonGridView.AllowUserToAddRows = false;
            this.LessonGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.LessonGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LessonGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Delete,
            this.Edit});
            this.LessonGridView.Location = new System.Drawing.Point(6, 6);
            this.LessonGridView.Name = "LessonGridView";
            this.LessonGridView.Size = new System.Drawing.Size(873, 431);
            this.LessonGridView.TabIndex = 6;
            this.LessonGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.LessonGridView_CellClick);
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Sil";
            this.Delete.Name = "Delete";
            this.Delete.Text = "Sil";
            this.Delete.UseColumnTextForButtonValue = true;
            this.Delete.Width = 60;
            // 
            // Edit
            // 
            this.Edit.HeaderText = "Düzenle";
            this.Edit.Name = "Edit";
            this.Edit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Edit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Edit.Text = "Düzenle";
            this.Edit.UseColumnTextForButtonValue = true;
            this.Edit.Width = 60;
            // 
            // AddLesson
            // 
            this.AddLesson.Location = new System.Drawing.Point(6, 440);
            this.AddLesson.Name = "AddLesson";
            this.AddLesson.Size = new System.Drawing.Size(873, 71);
            this.AddLesson.TabIndex = 1;
            this.AddLesson.Text = "Ders Ekleme";
            this.AddLesson.UseVisualStyleBackColor = true;
            this.AddLesson.Click += new System.EventHandler(this.AddLesson_Click);
            // 
            // StudentAdd
            // 
            this.StudentAdd.Controls.Add(this.AddStudentBtn);
            this.StudentAdd.Controls.Add(this.StudentGridView);
            this.StudentAdd.Location = new System.Drawing.Point(4, 22);
            this.StudentAdd.Name = "StudentAdd";
            this.StudentAdd.Padding = new System.Windows.Forms.Padding(3);
            this.StudentAdd.Size = new System.Drawing.Size(886, 517);
            this.StudentAdd.TabIndex = 3;
            this.StudentAdd.Text = "Öğrenci Sayfası";
            this.StudentAdd.UseVisualStyleBackColor = true;
            // 
            // AddStudentBtn
            // 
            this.AddStudentBtn.Location = new System.Drawing.Point(6, 440);
            this.AddStudentBtn.Name = "AddStudentBtn";
            this.AddStudentBtn.Size = new System.Drawing.Size(873, 71);
            this.AddStudentBtn.TabIndex = 1;
            this.AddStudentBtn.Text = "Öğrenci Ekle";
            this.AddStudentBtn.UseVisualStyleBackColor = true;
            this.AddStudentBtn.Click += new System.EventHandler(this.AddStudentBtn_Click);
            // 
            // StudentGridView
            // 
            this.StudentGridView.AllowUserToAddRows = false;
            this.StudentGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.StudentGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ShowScores,
            this.ConfirmClass,
            this.DeleteStudent,
            this.EditStudent});
            this.StudentGridView.Location = new System.Drawing.Point(6, 6);
            this.StudentGridView.Name = "StudentGridView";
            this.StudentGridView.Size = new System.Drawing.Size(873, 431);
            this.StudentGridView.TabIndex = 0;
            this.StudentGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StudentGridView_CellContentClick);
            // 
            // ShowScores
            // 
            this.ShowScores.HeaderText = "Notları Görüntüle";
            this.ShowScores.Name = "ShowScores";
            this.ShowScores.ReadOnly = true;
            this.ShowScores.Text = "Not Göster";
            this.ShowScores.UseColumnTextForButtonValue = true;
            this.ShowScores.Width = 80;
            // 
            // ConfirmClass
            // 
            this.ConfirmClass.HeaderText = "Ders Onayla";
            this.ConfirmClass.Name = "ConfirmClass";
            this.ConfirmClass.ReadOnly = true;
            this.ConfirmClass.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ConfirmClass.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ConfirmClass.Text = "Ders Onayla";
            this.ConfirmClass.UseColumnTextForButtonValue = true;
            this.ConfirmClass.Width = 70;
            // 
            // DeleteStudent
            // 
            this.DeleteStudent.HeaderText = "Sil";
            this.DeleteStudent.Name = "DeleteStudent";
            this.DeleteStudent.ReadOnly = true;
            this.DeleteStudent.Text = "Sil";
            this.DeleteStudent.UseColumnTextForButtonValue = true;
            this.DeleteStudent.Width = 50;
            // 
            // EditStudent
            // 
            this.EditStudent.HeaderText = "Düzenle";
            this.EditStudent.Name = "EditStudent";
            this.EditStudent.ReadOnly = true;
            this.EditStudent.Text = "Düzenle";
            this.EditStudent.UseColumnTextForButtonValue = true;
            this.EditStudent.Width = 60;
            // 
            // HeadOfDepartmentScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 568);
            this.Controls.Add(this.HeadOfDepartmentTabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "HeadOfDepartmentScreen";
            this.Text = "Bölüm Başkanı Ekranı";
            this.Load += new System.EventHandler(this.HeadOfDepartmentScreen_Load);
            this.HeadOfDepartmentTabControl.ResumeLayout(false);
            this.LessonAdd.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LessonGridView)).EndInit();
            this.StudentAdd.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.StudentGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl HeadOfDepartmentTabControl;
        private System.Windows.Forms.TabPage LessonAdd;
        private System.Windows.Forms.TabPage StudentAdd;
        private System.Windows.Forms.Button AddLesson;
        private System.Windows.Forms.DataGridView LessonGridView;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridView StudentGridView;
        private System.Windows.Forms.Button AddStudentBtn;
        private System.Windows.Forms.DataGridViewButtonColumn ShowScores;
        private System.Windows.Forms.DataGridViewButtonColumn ConfirmClass;
        private System.Windows.Forms.DataGridViewButtonColumn DeleteStudent;
        private System.Windows.Forms.DataGridViewButtonColumn EditStudent;
    }
}