using DataAccess.DAO;
using System;
using System.Windows.Forms;

namespace Öğrenci_İşleri
{
    public partial class AddDivision : Form
    {
        public AddDivision()
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
            if(!String.IsNullOrEmpty(DivisionTxT.Text))
            {
                bool Result = BolumDAO.AddBolum(DivisionTxT.Text);
                if (Result == true)
                {
                    MessageBox.Show("İşlem Başarı İle Tamamlandı!", "Başarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                    MessageBox.Show("Birşeyler Yanlış Gitti !", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
