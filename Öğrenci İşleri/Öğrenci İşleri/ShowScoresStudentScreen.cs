using DataAccess.DAO;
using DataAccess.Entities;
using System;
using System.Windows.Forms;

namespace Öğrenci_İşleri
{
    public partial class ShowScoresStudentScreen : Form
    {
        Ogrenci ogrenci = new Ogrenci();
        public ShowScoresStudentScreen()
        {
            InitializeComponent();
        }

        private void PeriodPicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            StudentScores.DataSource = OgrenciDAO.GetScoresForStudent(ogrenci.Id, Convert.ToInt32(PeriodPicker.Text));
            StudentScores.AutoResizeColumns();
            for (int i = 1; i < StudentScores.ColumnCount; i++)
                StudentScores.Columns[i].ReadOnly = true;
        }

        public void GetInfo(Ogrenci ogrenci)
        {
            this.ogrenci = ogrenci;
        }

        private void ShowScoresStudentScreen_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < ogrenci.Donem; i++)
                PeriodPicker.Items.Add(i+1);
        }
    }
}
