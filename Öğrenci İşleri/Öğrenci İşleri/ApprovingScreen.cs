using DataAccess.DAO;
using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Öğrenci_İşleri
{
    public partial class ApprovingScreen : Form
    {
        Ogrenci ogrenci = new Ogrenci();
        public ApprovingScreen()
        {
            InitializeComponent();
        }

        public void GetInfo(Ogrenci ogrenci)
        {
            this.ogrenci = ogrenci;
        }
        private void ApprovingScreen_Load(object sender, EventArgs e)
        {
            List<int> dersIds = new List<int>();
            for (int i= 0;i<ogrenci.AlinanDersler.Length; i+=2)
            {
                string dummy = ogrenci.AlinanDersler.Substring(i, 2);
                dersIds.Add(Convert.ToInt32(dummy));
            }
            ApproveGrid.DataSource = DersDAO.ApprovingList(dersIds);
            if(ApproveGrid.DataSource == null)
            {
                this.Close();
            }

            for (int i = 4; i < ApproveGrid.ColumnCount; i++)
                ApproveGrid.Columns[i].ReadOnly = true;

            ApproveGrid.AutoResizeColumns();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("İşlem İptal Edildi !", "İptal !", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void OK_Click(object sender, EventArgs e)
        {
            try
            {
                bool Result = OgrenciDAO.Approve(ogrenci);
                if(Result == true)
                {
                    MessageBox.Show("İşlem Başarı ile tamamlandı !", "Tamamlandı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                    MessageBox.Show("Bir Hata oluştu", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(Exception Err)
            {
                MessageBox.Show(Err.Message);
            }
        }
    }
}
