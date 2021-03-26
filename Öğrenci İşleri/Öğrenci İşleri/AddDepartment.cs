using DataAccess.DAO;
using System;
using System.Windows.Forms;

namespace Öğrenci_İşleri
{
    public partial class AddDepartment : Form
    {
        public AddDepartment()
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
            if (!String.IsNullOrEmpty(DepartmentTxT.Text))
            {
                bool Result = FakulteDAO.AddFakulte(DepartmentTxT.Text);
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
