using DataAccess.Entities;
using System;
using System.Windows.Forms;

namespace Öğrenci_İşleri
{
    public partial class StudentScreen : Form
    {
        Ogrenci LoggedStudent = new Ogrenci();
        public StudentScreen()
        {
            InitializeComponent();
        }


        public void LoginInfo(Ogrenci ogrenci)
        {
            LoggedStudent = ogrenci;
        }

        private void StudentScreen_Load(object sender, EventArgs e)
        {
            Welcome.Text = "Hoşgeldin " + LoggedStudent.Ad + " " + LoggedStudent.Soyad;
            this.ControlBox = false;
        }

        private void LessonRegister_Click(object sender, EventArgs e)
        {
            if (LoggedStudent.Onay == true || LoggedStudent.OnceOnay == true)
                MessageBox.Show("Ders Kaydınız Zaten Onaylanmış", "Zaten", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                StudentLessonRegister SLR = new StudentLessonRegister();
                SLR.GetInfo(LoggedStudent);
                SLR.ShowDialog();
            }
        }

        private void ShowScores_Click(object sender, EventArgs e)
        {
            ShowScoresStudentScreen SSSS = new ShowScoresStudentScreen();
            SSSS.GetInfo(LoggedStudent);
            SSSS.ShowDialog();
        }


        private void ChangePass_Click(object sender, EventArgs e)
        {
            PasswordChangeScreen PCS = new PasswordChangeScreen();
            PCS.GetInfo(LoggedStudent.Id, LoggedStudent.KullaniciAdi, false);
            PCS.ShowDialog();
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            LoggedStudent = null;
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
