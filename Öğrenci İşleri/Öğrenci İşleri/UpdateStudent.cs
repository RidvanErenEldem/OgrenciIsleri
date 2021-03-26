using DataAccess.DAO;
using DataAccess.DTO;
using DataAccess.Entities;
using System;
using System.Windows.Forms;

namespace Öğrenci_İşleri
{
    public partial class UpdateStudent : Form
    {
        public UpdateStudent()
        {
            InitializeComponent();
        }
        OgrenciDTO ogrenciDTO = new OgrenciDTO();
        private void OK_Click(object sender, EventArgs e)
        {
            try
            {
                if(!String.IsNullOrEmpty(EditedNumber.Text) && !String.IsNullOrEmpty(EditedStudentName.Text) && !String.IsNullOrEmpty(EditedStudentSurname.Text))
                {
                    Ogrenci ogrenci = new Ogrenci
                    {
                        Id = ogrenciDTO.Id,
                        Ad = EditedStudentName.Text,
                        Soyad = EditedStudentSurname.Text,
                        Numara = EditedNumber.Text
                    };
                    if (Men.Checked == true)
                        ogrenci.Cinsiyet = true;
                    else
                        ogrenci.Cinsiyet = false;
                    bool Result = OgrenciDAO.AddUpdateDeleteStudent(ogrenci, 1);
                    if(Result == true)
                    {
                        MessageBox.Show("İşlem Başarı ile tamamlandı !", "Tamamlandı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                        MessageBox.Show("Bir Hata oluştu", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
        public void GetInfo(OgrenciDTO Info)
        {
            ogrenciDTO = Info;
        }
        private void UpdateStudent_Load(object sender, EventArgs e)
        {
            EditedNumber.Text = ogrenciDTO.Numara;
            EditedStudentSurname.Text = ogrenciDTO.Soyad;
            EditedStudentName.Text = ogrenciDTO.Ad;
            if (ogrenciDTO.Cinsiyet == true)
            {
                Men.Checked = true;
                Women.Checked = false;
            }
            else
            {
                Men.Checked = false;
                Women.Checked = true;
            }
        }

        private void EditedNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
