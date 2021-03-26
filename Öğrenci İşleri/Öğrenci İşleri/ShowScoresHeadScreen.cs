using DataAccess.DAO;
using System;
using System.Windows.Forms;

namespace Öğrenci_İşleri
{
    public partial class ShowScoresHeadScreen : Form
    {
        int Id, OgrenciId;
        public ShowScoresHeadScreen()
        {
            InitializeComponent();
        }
        public void GetInfo(int Id, int OgrenciId)
        {
            this.Id = Id;
            this.OgrenciId = OgrenciId;
        }
        private void ShowScoresHeadScreen_Load(object sender, EventArgs e)
        {
            ScoresGridView.DataSource = NotlarDAO.GetScoresForHead(Id, OgrenciId);
            ScoresGridView.AutoResizeColumns();
            ScoresGridView.ReadOnly = true;
        }
    }
}
