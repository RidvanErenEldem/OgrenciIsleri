using DataAccess.DAO;
using System;
using System.Windows.Forms;

namespace Öğrenci_İşleri
{
    public partial class PasswordChangeScreen : Form
    {
        int Id;
        string UserName;
        bool Choose;
        public PasswordChangeScreen()
        {
            InitializeComponent();
        }

        public void GetInfo(int Id, string UserName, bool Choose)
        {
            this.Id = Id;
            this.UserName = UserName;
            this.Choose = Choose;
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("İşlem İptal Edildi !", "İptal !", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void OK_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(OldPass.Text) && !String.IsNullOrEmpty(NewPass.Text) && !String.IsNullOrEmpty(ConfirmNewPass.Text))
            {
                if (NewPass.Text == ConfirmNewPass.Text)
                {
                    bool Result = AkademisyenDAO.ChangePass(Id, OldPass.Text, NewPass.Text, UserName, Choose);
                    if (Result == true)
                    {
                        MessageBox.Show("İşlem Başarı İle Tamamlandı !", "Tamam", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                        MessageBox.Show("Hatalı şifre giridiniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    MessageBox.Show("Girilen Şifreler Uyuşmuyor", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Gerekli Alanlar Boş Bırakılamaz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ShowPassOld_Click(object sender, EventArgs e)
        {
            if (OldPass.UseSystemPasswordChar == true)
                OldPass.UseSystemPasswordChar = false;
            else
                OldPass.UseSystemPasswordChar = true;
        }

        private void ShowPassNew_Click(object sender, EventArgs e)
        {
            if (NewPass.UseSystemPasswordChar == true)
                NewPass.UseSystemPasswordChar = false;
            else
                NewPass.UseSystemPasswordChar = true;
        }

        private void ShopPassCon_Click(object sender, EventArgs e)
        {
            if (ConfirmNewPass.UseSystemPasswordChar == true)
                ConfirmNewPass.UseSystemPasswordChar = false;
            else
                ConfirmNewPass.UseSystemPasswordChar = true;
        }
    }
}
