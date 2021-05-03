using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using DataAccess.DAO;
using DataAccess.Entities;
using static DataAccess.Struct;

namespace Öğrenci_İşleri
{
    
    public partial class AcademicianScreen : Form
    {
        Akademisyen LoggedAcademician = new Akademisyen();
        public LoginScreen LoginScreen;
        DataTable ScoreTable = new DataTable();
        public AcademicianScreen()
        {
            InitializeComponent();
        }
        public void LoginInfo(Akademisyen akademisyen)
        {
            LoggedAcademician = akademisyen;
        }

        private void HeadOfDepartmentBtn_Click(object sender, EventArgs e)
        {
            if (LoggedAcademician.Yetki == 1)
            {
                HeadOfDepartmentScreen HOD = new HeadOfDepartmentScreen();
                HOD.LoginInfo(LoggedAcademician);
                HOD.ShowDialog();
            }
            else
                MessageBox.Show("Bu sayfaya erişim yetkiniz yoktur !", "Yetersiz Yetki !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void AcademicianScreen_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            Welcome.Text = "Hoşgeldin " + LoggedAcademician.Ad + " " + LoggedAcademician.Soyad;
            List<Ders> Dersler = DersDAO.FillComboBox(LoggedAcademician.Id);
            ChooseLesson.DisplayMember = "Ad";
            ChooseLesson.ValueMember = "Id";
            foreach (Ders ders in Dersler)
                ChooseLesson.Items.Add(new ComboBoxDbItem { Ad = ders.Ad,Id = ders.Id });
        }

        private void ChooseLesson_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadTheGrid();
        }
        public void LoadTheGrid()
        {
            ScoreSetterGrid.DataSource = NotlarDAO.GetScoresForAcademician(((ComboBoxDbItem)ChooseLesson.Items[ChooseLesson.SelectedIndex]).Id, LoggedAcademician.Id);
            ScoreTable = ScoreSetterGrid.DataSource as DataTable;
            ScoreSetterGrid.AutoResizeColumns();
            for (int i = 1; i < ScoreSetterGrid.ColumnCount; i++)
                ScoreSetterGrid.Columns[i].ReadOnly = true;

            ScoreSetterGrid.Columns[6].ReadOnly = false;
            ScoreSetterGrid.Columns[7].ReadOnly = false;
        }
        private void ScoreSetterGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(ScoreSetterGrid.CurrentCell.ColumnIndex == 0)
            {
                DataGridViewRow row = ScoreSetterGrid.CurrentRow;
                Ogrenci ogrenci = new Ogrenci
                {
                    Id = Convert.ToInt32(ScoreTable.Rows[row.Index]["OgrenciId"])
                };
                ShowStudent SS = new ShowStudent();
                SS.GetInfo(ogrenci);
                SS.ShowDialog();
            }
        }


        private void ScoreSetterGrid_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = ScoreSetterGrid.CurrentRow;
            Notlar notlar = new Notlar();
            bool Result;
            notlar.Id = Convert.ToInt32(ScoreTable.Rows[row.Index]["Id"]);
            
            if (ScoreSetterGrid.CurrentCell.ColumnIndex == 6)
            {
                notlar.Vize = Convert.ToInt32(row.Cells["Vize"].Value);
                Result = NotlarDAO.UpdateScore(notlar, true);
                if (Result == true)
                {
                    MessageBox.Show("İşlem Başarı ile tamamlandı !", "Tamamlandı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadTheGrid();
                }
                else
                    MessageBox.Show("Bir Hata oluştu", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(ScoreSetterGrid.CurrentCell.ColumnIndex == 7)
            {
                notlar.Vize = Convert.ToInt32(row.Cells["Final"].Value);
                Result = NotlarDAO.UpdateScore(notlar, false);
                if (Result == true)
                {
                    MessageBox.Show("İşlem Başarı ile tamamlandı !", "Tamamlandı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadTheGrid();
                }
                else
                    MessageBox.Show("Bir Hata oluştu", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Change_Click(object sender, EventArgs e)
        {
            PasswordChangeScreen PCS = new PasswordChangeScreen();
            PCS.GetInfo(LoggedAcademician.Id,LoggedAcademician.KullaniciAdi,true);
            PCS.ShowDialog();
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            LoggedAcademician = null;
            LoginScreen LS = new LoginScreen();
            this.Close();
            LS.Show();
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Alt | Keys.F4))
            {
                if (MessageBox.Show("Programdan Çıkılsın Mı ?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    Application.Exit();
                else
                    return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
