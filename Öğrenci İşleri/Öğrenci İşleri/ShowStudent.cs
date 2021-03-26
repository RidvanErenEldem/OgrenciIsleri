using DataAccess.DAO;
using DataAccess.Entities;
using System;
using System.Data;
using System.Windows.Forms;

namespace Öğrenci_İşleri
{
    public partial class ShowStudent : Form
    {
        Ogrenci ogrenci = new Ogrenci();
        public ShowStudent()
        {
            InitializeComponent();
        }

        public void GetInfo(Ogrenci ogrenci)
        {
            this.ogrenci = ogrenci;
        }

        private void ShowStudent_Load(object sender, EventArgs e)
        {
            DataTable dt = OgrenciDAO.GetOneStudentData(ogrenci);

            Names.Text = dt.Rows[0]["Ad"].ToString();
            Surname.Text = dt.Rows[0]["Soyad"].ToString();
            Number.Text = dt.Rows[0]["Numara"].ToString();
            if (Convert.ToBoolean(dt.Rows[0]["Cinsiyet"]) == true)
                Gender.Text = "Erkek";
            else
                Gender.Text = "Kadın";
            Departman.Text = dt.Rows[0]["FakulteAd"].ToString();
            Bolum.Text = dt.Rows[0]["BolumAd"].ToString();
        }
    }
}
