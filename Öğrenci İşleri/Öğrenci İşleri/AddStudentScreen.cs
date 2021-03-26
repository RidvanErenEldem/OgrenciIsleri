using DataAccess;
using DataAccess.DAO;
using DataAccess.Entities;
using System;
using System.Windows.Forms;

namespace Öğrenci_İşleri
{
    public partial class AddStudentScreen : Form
    {
        Akademisyen LoggedAcademican = new Akademisyen();
        public AddStudentScreen()
        {
            InitializeComponent();
        }

        public void GetInfo(Akademisyen LoggedAcademican)
        {
            this.LoggedAcademican = LoggedAcademican;
        }

        private void OK_Click(object sender, EventArgs e)
        {
            try
            {
                if(!String.IsNullOrEmpty(StudentName.Text) && !String.IsNullOrEmpty(StudentNumber.Text) && !String.IsNullOrEmpty(StudentSurname.Text) && !String.IsNullOrEmpty(StudentUserName.Text))
                {
                    Ogrenci ogrenci = new Ogrenci
                    {
                        Ad = StudentName.Text,
                        Soyad = StudentSurname.Text,
                        Numara = StudentNumber.Text,
                        Donem = 1,
                        AlinanDersler = DersDAO.GetFirst(LoggedAcademican.BolumId),
                        BolumId = LoggedAcademican.BolumId,
                        FakulteId = LoggedAcademican.FakulteId
                    };
                    if (Men.Checked == true)
                        ogrenci.Cinsiyet = true;
                    else
                        ogrenci.Cinsiyet = false;
                    ogrenci.KullaniciAdi = StudentUserName.Text;
                    ogrenci.Sifre = Password.Encrypt(ogrenci.Numara);
                    ogrenci.Aktif = true;
                    ogrenci.Onay = true;
                    ogrenci.OnceOnay = false;
                    bool Result = OgrenciDAO.AddUpdateDeleteStudent(ogrenci, 0);
                    if (Result == true)
                    {
                        MessageBox.Show("İşlem Başarı ile tamamlandı !", "Tamamlandı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                        MessageBox.Show("Bir Hata oluştu", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    MessageBox.Show("Hatalı Giriş Yaptınız Lütfen Tekrar Deneyiniz !", "HATA !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("İşlem İptal Edildi !", "İptal !", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void StudentNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
