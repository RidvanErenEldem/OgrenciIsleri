using DataAccess.DAO;
using DataAccess.DTO;
using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static DataAccess.Struct;

namespace Öğrenci_İşleri
{
    public partial class UpdateLessonScreen : Form
    {
        DersDTO dersDTO = new DersDTO();
        public UpdateLessonScreen()
        {
            InitializeComponent();
        }

        public void GetInfo(DersDTO Info)
        {
            dersDTO = Info;
        }

        private void UpdateLessonScreen_Load(object sender, EventArgs e)
        {
            EditedLessonName.Text = dersDTO.Ad;
            List<Akademisyen> Akademisyenler = DataAccess.DAO.AkademisyenDAO.FillComboBox(dersDTO.BolumId);
            EditedAcademicanPicker.DisplayMember = "Ad";
            EditedAcademicanPicker.ValueMember = "Id";
            foreach (Akademisyen akademisyen in Akademisyenler)
                EditedAcademicanPicker.Items.Add(new ComboBoxDbItem { Ad = akademisyen.Ad, Id = akademisyen.Id });
            EditedAcademicanPicker.SelectedItem = new ComboBoxDbItem { Ad = dersDTO.AkademisyenAd, Id = dersDTO.AkademisyenId };
        }

        private void OK_Click(object sender, EventArgs e)
        {
            try
            {
                if(!String.IsNullOrEmpty(EditedAcademicanPicker.Text) && !String.IsNullOrEmpty(EditedLessonName.Text))
                {
                    Ders ders = new Ders
                    {
                        Id = dersDTO.Id,
                        Ad = EditedLessonName.Text,
                        AkademisyenId = ((ComboBoxDbItem)EditedAcademicanPicker.Items[EditedAcademicanPicker.SelectedIndex]).Id,
                        Aktif = true,
                        Donem = Convert.ToByte(dersDTO.Donem)
                    };
                    bool Result = DersDAO.AddUpdateDeleteLesson(ders, 1);
                    if (Result == true)
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
    }
}
