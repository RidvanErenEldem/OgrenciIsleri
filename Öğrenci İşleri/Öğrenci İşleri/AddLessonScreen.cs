using DataAccess.DAO;
using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static DataAccess.Struct;

namespace Öğrenci_İşleri
{
    public partial class AddLessonScreen : Form
    {
        Akademisyen LoggedAcademician = new Akademisyen();
        public AddLessonScreen()
        {
            InitializeComponent();
        }
        public void LoginInfo(Akademisyen akademisyen)
        {
            LoggedAcademician = akademisyen;
        }

        private void AddLessonBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty(LessonName.Text) && !String.IsNullOrEmpty(Credit.Text) && !String.IsNullOrEmpty(AcademicianPicker.Text) && !String.IsNullOrEmpty(PeriodPicker.Text))
                {
                    Ders ders = new Ders
                    {
                        Ad = LessonName.Text,
                        Aktif = true,
                        Donem = Convert.ToByte(PeriodPicker.Text),
                        FakulteId = LoggedAcademician.FakulteId
                    };
                    if (IsShared.Checked == true)
                        ders.BolumId = 1;
                    else
                        ders.BolumId = LoggedAcademician.BolumId;
                    ders.Kredi = Convert.ToByte(Credit.Text);
                    ders.AkademisyenId = ((ComboBoxDbItem)AcademicianPicker.Items[AcademicianPicker.SelectedIndex]).Id;
                    DialogResult Sure = MessageBox.Show(ders.Ad + " adlı ders eklenecek emin misiniz ?", "Emin Misin ?",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                    if (Sure == DialogResult.Yes)
                        DersDAO.AddUpdateDeleteLesson(ders,0);
                    else
                        MessageBox.Show("Ders Eklenmedi !", "Eklenmedi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Hatalı Giriş Yaptınız Lütfen Tekrar Deneyiniz !", "HATA !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message);
            }
            
        }

        private void CancelAddLesson_Click(object sender, EventArgs e)
        {
            MessageBox.Show("İşlem İptal Edildi !", "İptal !", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void AddLessonScreen_Load(object sender, EventArgs e)
        {
            AcademicianPickerLoad(1);
            for (int i = 1; i <= 8; i++)
                PeriodPicker.Items.Add(i);
        }
        private void AcademicianPickerLoad(int BolumId)
        {
            List<Akademisyen> Akademisyenler = DataAccess.DAO.AkademisyenDAO.FillComboBox(BolumId);
            AcademicianPicker.DisplayMember = "Ad";
            AcademicianPicker.ValueMember = "Id";
            foreach (Akademisyen akademisyen in Akademisyenler)
                AcademicianPicker.Items.Add( new ComboBoxDbItem  { Ad = akademisyen.Ad, Id = akademisyen.Id });
        }

        private void IsShared_CheckedChanged(object sender, EventArgs e)
        {
            AcademicianPicker.Items.Clear();
            AcademicianPicker.ResetText();
            if (IsShared.Checked == true)
                AcademicianPickerLoad(LoggedAcademician.BolumId);
            else
                AcademicianPickerLoad(1);
        }

        private void Credit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
