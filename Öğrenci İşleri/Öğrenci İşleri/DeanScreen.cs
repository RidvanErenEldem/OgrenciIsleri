using DataAccess.Entities;
using System;
using System.Windows.Forms;

namespace Öğrenci_İşleri
{
    public partial class DeanScreen : Form
    {
        Dekan LoggedDean = new Dekan();
        public DeanScreen()
        {
            InitializeComponent();
        }
        public void GetInfo(Dekan LoggedDean)
        {
            this.LoggedDean = LoggedDean;
        }

        private void DeanScreen_Load(object sender, EventArgs e)
        {
            DeanWelcome.Text += " " + LoggedDean.Ad + " " + LoggedDean.Soyad;
            this.ControlBox = false;
        }

        private void AddDepartment_Click(object sender, EventArgs e)
        {
            AddDepartment AD = new AddDepartment();
            AD.ShowDialog();
        }

        private void AddDivision_Click(object sender, EventArgs e)
        {
            var AD = new AddDivision();
            AD.ShowDialog();
        }

        private void AddAcademican_Click(object sender, EventArgs e)
        {
            var AA = new AddAcademican();
            AA.ShowDialog();
        }

        private void SafeExit_Click(object sender, EventArgs e)
        {
            LoggedDean = null;
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
