using DataAccess.DAO;
using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Öğrenci_İşleri
{
    public partial class StudentLessonRegister : Form
    {
        Ogrenci LoggedStudent = new Ogrenci();
        DataTable RegisterLesson = new DataTable();
        public StudentLessonRegister()
        {
            InitializeComponent();
        }

        public void GetInfo(Ogrenci LoggedStudent)
        {
            this.LoggedStudent = LoggedStudent;
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("İşlem İptal Edildi !", "İptal !", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void OK_Click(object sender, EventArgs e)
        {
            List<string> Selected = new List<string>();
            for(int i = 0; i<RegisterGrid.Rows.Count;i++)
            {
                bool IsChecked = Convert.ToBoolean(RegisterGrid.Rows[i].Cells["Checker"].Value);
                if(IsChecked == true)
                {
                    int basamak = 0;
                    int dummy = Convert.ToInt32(RegisterLesson.Rows[i]["Id"]);
                    int real = dummy;
                    while(dummy >= 1)
                    {
                        dummy /= 10;
                        basamak++;
                    }
                    if (basamak == 1)
                    {
                        string Add = "0" + real.ToString();
                        Selected.Add(Add);
                    }
                    else
                        Selected.Add(RegisterLesson.Rows[i]["Id"].ToString());
                }
            }
            string Classes = string.Join("", Selected);
            bool Result = OgrenciDAO.AddLessons(LoggedStudent.Id, Classes);
            if(Result == true)
            {
                MessageBox.Show("İşlem başarılı !", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
                MessageBox.Show("Birşeyler Yanlış Gitti !", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void StudentLessonRegister_Load(object sender, EventArgs e)
        {
            RegisterGrid.DataSource = OgrenciDAO.GetLessons(LoggedStudent.Donem, LoggedStudent.BolumId);
            RegisterLesson = RegisterGrid.DataSource as DataTable;

            for (int i = 1; i < RegisterGrid.ColumnCount; i++)
                RegisterGrid.Columns[i].ReadOnly = true;
            RegisterGrid.AutoResizeColumns();
        }
    }
}
