using DataAccess.DAO;
using DataAccess.DTO;
using DataAccess.Entities;
using System;
using System.Data;
using System.Windows.Forms;

namespace Öğrenci_İşleri
{
    public partial class HeadOfDepartmentScreen : Form
    {
        Akademisyen LoggedAcademician = new Akademisyen();

        public HeadOfDepartmentScreen()
        {
            InitializeComponent();
        }
        private void HeadOfDepartmentScreen_Load(object sender, EventArgs e)
        {
            LoadGrid();
            LoadStudentGrid();
        }
        public void LoginInfo(Akademisyen akademisyen)
        {
            LoggedAcademician = akademisyen;
        }
        #region Ders

        DataTable dt = new DataTable();
        private void LoadGrid()
        {
            LessonGridView.DataSource = DersDAO.GetGridData(LoggedAcademician.BolumId);

            for (int i = 2; i < LessonGridView.ColumnCount; i++)
                LessonGridView.Columns[i].ReadOnly = true;

            dt = LessonGridView.DataSource as DataTable;
            LessonGridView.AutoResizeColumns();
            var dataSet = new DataSet();
            dataSet.AddTable(myDataTable);

            // Write dataset to xml file or stream
            dataSet.WriteXml("filename.xml");
        }
        private void AddLesson_Click(object sender, EventArgs e)
        {
            AddLessonScreen ALS = new AddLessonScreen();
            ALS.LoginInfo(LoggedAcademician);
            ALS.ShowDialog();
        }

        private void LessonGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = LessonGridView.CurrentRow;
            if (LessonGridView.CurrentCell.ColumnIndex == 1)
            {
                DersDTO dersDTO = new DersDTO
                {
                    Ad = row.Cells["Ad"].Value.ToString(),
                    Id = Convert.ToInt32(dt.Rows[row.Index]["Id"]),
                    FakulteAd = row.Cells["FakulteAd"].Value.ToString(),
                    BolumAd = row.Cells["BolumAd"].Value.ToString(),
                    AkademisyenId = Convert.ToInt32(dt.Rows[row.Index]["AkademisyenId"]),
                    AkademisyenAd = row.Cells["AkademisyenAd"].Value.ToString(),
                    Kredi = Convert.ToByte(row.Cells["Kredi"].Value),
                    Donem = Convert.ToInt32(row.Cells["Donem"].Value),
                    BolumId = LoggedAcademician.BolumId
                };
                UpdateLessonScreen ULS = new UpdateLessonScreen();
                ULS.GetInfo(dersDTO);
                ULS.ShowDialog();
                LoadGrid();
            }
            else if (LessonGridView.CurrentCell.ColumnIndex == 0)
            {
                DialogResult dialogResult = MessageBox.Show(row.Cells["Ad"].Value.ToString() + " Adlı ders kalıcı olarak silinecek", "Emin Misin ?", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.OK)
                {
                    Ders ders = new Ders
                    {
                        Aktif = false,
                        Id = Convert.ToInt32(dt.Rows[row.Index]["Id"])
                    };
                    bool Result = DersDAO.AddUpdateDeleteLesson(ders, 2);
                    if (Result == true)
                    {
                        MessageBox.Show("Silme İşlemi Başarı İle Tamamlandı !", "GONE FOREVER (!)", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadGrid();
                    }
                    else
                        MessageBox.Show("Birşeyler Yanlış Gitti !", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("İptal Edildi !", "İptal", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion

        #region Ogrenci
        DataTable StudentTable = new DataTable();

        private void LoadStudentGrid()
        {
            StudentGridView.DataSource = OgrenciDAO.GetData(LoggedAcademician.Id);
            StudentTable = StudentGridView.DataSource as DataTable;

            for (int i = 4; i < StudentGridView.ColumnCount; i++)
                StudentGridView.Columns[i].ReadOnly = true;

            for (int i = 0; i < StudentGridView.ColumnCount; i++)
                StudentGridView.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            StudentGridView.AutoResizeColumns();
        }
        private void StudentGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = StudentGridView.CurrentRow;
            if(StudentGridView.CurrentCell.ColumnIndex == 0)
            {
                ShowScoresHeadScreen SSHS = new ShowScoresHeadScreen();
                SSHS.GetInfo(LoggedAcademician.BolumId, Convert.ToInt32(StudentTable.Rows[row.Index]["Id"]));
                SSHS.ShowDialog();
                LoadStudentGrid();
            }
            else if(StudentGridView.CurrentCell.ColumnIndex == 1)
            {
                if (Convert.ToBoolean(row.Cells["Onay"].Value) == true)
                    MessageBox.Show("Bu öğrencinin dersleri zaten onaylanmış", "Zaten", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    Ogrenci ogrenci = new Ogrenci
                    {
                        Id = Convert.ToInt32(StudentTable.Rows[row.Index]["Id"]),
                        Onay = true,
                        AlinanDersler = StudentTable.Rows[row.Index]["AlinanDersler"].ToString()
                    };
                    ApprovingScreen AS = new ApprovingScreen();
                    AS.GetInfo(ogrenci);
                    AS.ShowDialog();
                    LoadStudentGrid();
                }
            }
            else if(StudentGridView.CurrentCell.ColumnIndex == 2)
            {
                DialogResult dialogResult = MessageBox.Show(row.Cells["Ad"].Value.ToString() + " Adlı öğrenci kalıcı olarak silinecek", "Emin Misin ?", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.OK)
                {
                    Ogrenci ogrenci = new Ogrenci
                    {
                        Aktif = false,
                        Id = Convert.ToInt32(StudentTable.Rows[row.Index]["Id"])
                    };
                    bool Result = OgrenciDAO.AddUpdateDeleteStudent(ogrenci, 2);
                    if (Result == true)
                    {
                        MessageBox.Show("Silme İşlemi Başarı İle Tamamlandı !", "GONE FOREVER (!)", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadStudentGrid();
                    }
                    else
                        MessageBox.Show("Birşeyler Yanlış Gitti !", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("İptal Edildi !", "İptal", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if(StudentGridView.CurrentCell.ColumnIndex == 3)
            {
                OgrenciDTO ogrenciDTO = new OgrenciDTO
                {
                    Id = Convert.ToInt32(StudentTable.Rows[row.Index]["Id"]),
                    Ad = row.Cells["Ad"].Value.ToString(),
                    Soyad = row.Cells["Soyad"].Value.ToString(),
                    Numara = row.Cells["Numara"].Value.ToString(),
                    Cinsiyet = Convert.ToBoolean(row.Cells["Cinsiyet"].Value)
                };
                UpdateStudent US = new UpdateStudent();
                US.GetInfo(ogrenciDTO);
                US.ShowDialog();
                LoadStudentGrid();
            }
        }
        private void AddStudentBtn_Click(object sender, EventArgs e)
        {
            AddStudentScreen ASS = new AddStudentScreen();
            ASS.GetInfo(LoggedAcademician);
            ASS.ShowDialog();

        }
        #endregion
    }
}
