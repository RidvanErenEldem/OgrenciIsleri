using System;
using System.Windows.Forms;
using DataAccess.DAO;
using DataAccess.Entities;
namespace Öğrenci_İşleri
{
    public partial class LoginScreen : Form
    {
        public LoginScreen()
        {
            InitializeComponent();
        }
        private void AcademicianLoginBtn_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(UserName.Text) && !String.IsNullOrEmpty(UserPass.Text))
            {
                Akademisyen akademisyen = AkademisyenDAO.LoginChecker(UserName.Text, UserPass.Text);
                if (akademisyen != null)
                {
                    AcademicianScreen AS = new AcademicianScreen();
                    AS.LoginInfo(akademisyen);
                    AS.Show();
                    this.Hide();
                    akademisyen = null;
                }
                else
                    MessageBox.Show("Yanlış Kullanıcı Adı veya Şifre girdiniz !", "Hatalı Şifre !", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void StudentLogin_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(UserName.Text) && !String.IsNullOrEmpty(UserPass.Text))
            {
                Ogrenci ogrenci = OgrenciDAO.LoginChecker(UserName.Text, UserPass.Text);
                if (ogrenci != null)
                {
                    StudentScreen SS = new StudentScreen();
                    SS.LoginInfo(ogrenci);
                    SS.Show();
                    this.Hide();
                    ogrenci = null;
                }
                else
                    MessageBox.Show("Yanlış Kullanıcı Adı veya Şifre girdiniz !", "Hatalı Şifre !", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void DeanLogin_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(UserName.Text) && !String.IsNullOrEmpty(UserPass.Text))
            {
                Dekan dekan = DekanDAO.LoginChecker(UserName.Text, UserPass.Text);
                if (dekan != null)
                {
                    DeanScreen DS = new DeanScreen();
                    DS.GetInfo(dekan);
                    DS.Show();
                    this.Hide();
                    dekan = null;
                }
                else
                    MessageBox.Show("Yanlış Kullanıcı Adı veya Şifre girdiniz !", "Hatalı Şifre !", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void ShowPass_Click(object sender, EventArgs e)
        {
            if (UserPass.UseSystemPasswordChar == true)
                UserPass.UseSystemPasswordChar = false;
            else
                UserPass.UseSystemPasswordChar = true;
        }

        private void LoginScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
