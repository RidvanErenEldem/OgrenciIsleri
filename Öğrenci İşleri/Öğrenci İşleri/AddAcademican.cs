using DataAccess;
using DataAccess.DAO;
using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static DataAccess.Struct;

namespace Öğrenci_İşleri
{
    public partial class AddAcademican : Form
    {
        public AddAcademican()
        {
            InitializeComponent();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("İşlem İptal Edildi !", "İptal !", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void OK_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(Names.Text) && !String.IsNullOrEmpty(SurName.Text) && !String.IsNullOrEmpty(Tc.Text) && !String.IsNullOrEmpty(UserName.Text) && !String.IsNullOrEmpty(DepartmentPicker.Text) && !String.IsNullOrEmpty(BolumPicker.Text))
            {
                Akademisyen akademisyen = new Akademisyen
                {
                    Ad = Names.Text,
                    Soyad = SurName.Text,
                    Tcno = Tc.Text,
                    KullaniciAdi = UserName.Text,
                    FakulteId = ((ComboBoxDbItem)DepartmentPicker.Items[DepartmentPicker.SelectedIndex]).Id,
                    BolumId = ((ComboBoxDbItem)BolumPicker.Items[BolumPicker.SelectedIndex]).Id,
                    Aktif = true,
                    Sifre = Password.Encrypt(Tc.Text),
                    Cinsiyet = Men.Checked
                };
                if (Yetki.Checked == true)
                    akademisyen.Yetki = 1;
                else
                    akademisyen.Yetki = 0;
                bool Result = AkademisyenDAO.AddAcademican(akademisyen);
                if (Result == true)
                {
                    MessageBox.Show("İşlem Başarı ile tamamlandı !", "Tamamlandı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                    MessageBox.Show("Bir Hata oluştu", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Gereken Tüm Bilgileri Doldurunuz", "Eksik !", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void AddAcademican_Load(object sender, EventArgs e)
        {
            List<Fakulte> Fakulteler = FakulteDAO.FillComboBox();
            DepartmentPicker.DisplayMember = "Ad";
            DepartmentPicker.ValueMember = "Id";
            foreach (Fakulte fakulte in Fakulteler)
                DepartmentPicker.Items.Add(new ComboBoxDbItem { Ad = fakulte.Ad, Id = fakulte.Id });
            List<Bolum> Bolumler = BolumDAO.FillComboBox();
            BolumPicker.DisplayMember = "Ad";
            BolumPicker.ValueMember = "Id";
            foreach (Bolum bolum in Bolumler)
                BolumPicker.Items.Add(new ComboBoxDbItem { Ad = bolum.Ad, Id = bolum.Id });
        }

        private void Tc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
