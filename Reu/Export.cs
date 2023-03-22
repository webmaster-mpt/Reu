using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace Reu
{
    public partial class Export : Form
    {
        SqlConnection con = new SqlConnection("Data Source=ASUS\\MSSQLSERVER01;Initial Catalog=Reu;Integrated Security=True");

        public Export()
        {
            InitializeComponent();
            CboxRef();
            ViewRef();
        }
        /// <summary>
        /// Метод заполнения КомбоБокса всеми факультетами
        /// </summary>
        public void CboxRef()
        {
            con.Open();
            string s = "Select * from Received";
            SqlDataAdapter xa = new SqlDataAdapter(s, con);
            DataSet xs = new DataSet();
            xa.Fill(xs, "Received");
            //add
            xa.SelectCommand = new SqlCommand("Select * from Fakultet", con);
            xa.Fill(xs, "fakcb");
            this.FakultetCbox.DataSource = xs.Tables["fakcb"];
            FakultetCbox.DisplayMember = "name";
            FakultetCbox.ValueMember = "id";
            con.Close();
        }
        /// <summary>
        /// Метод обновления таблицы
        /// </summary>
        public void ViewRef()
        {
            con.Open();
            string a = "Select * from View_3";
            SqlDataAdapter da = new SqlDataAdapter(a, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            StAdminDataGrid.DataSource = ds.Tables[0];
            con.Close();
        }
        private void Export_Load(object sender, EventArgs e)
        {
            con.Open();
            string a = "Select * from View_3";
            SqlDataAdapter da = new SqlDataAdapter(a, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            StAdminDataGrid.DataSource = ds.Tables[0];
            con.Close();
        }
        /// <summary>
        /// Кнопка для Экспорта datagridview в Excel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExportBtn_Click(object sender, EventArgs e)
        {
            Excel.Application exApp = new Excel.Application();
            exApp.Workbooks.Add();
            Excel.Worksheet wsh = (Excel.Worksheet)exApp.ActiveSheet;
            int i, j;
            for (i = 0; i <= StAdminDataGrid.RowCount - 2; i++)
            {
                for (j = 0; j <= StAdminDataGrid.ColumnCount - 1; j++)
                {
                    wsh.Cells[i + 1, j + 1] = StAdminDataGrid[j, i].Value.ToString();
                }
            }
            exApp.Visible = true;
            MessageBox.Show("Файл экспортирован");
        }
        /// <summary>
        /// Метод для оторбражения принятых заявок
        /// </summary>
        public void StA_Otk()
        {
            con.Open();
            string a = $"Select * from View_3 where Статус = 'Отказано'";
            SqlDataAdapter da = new SqlDataAdapter(a, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            StAdminDataGrid.DataSource = ds.Tables[0];
            con.Close();
        }
        /// <summary>
        /// Метод для оторбражения принятых заявок
        /// </summary>
        public void StA_Acp()
        {
            con.Open();
            string a = $"Select * from View_3 where Статус = 'Принято'";
            SqlDataAdapter da = new SqlDataAdapter(a, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            StAdminDataGrid.DataSource = ds.Tables[0];
            con.Close();
        }
        /// <summary>
        /// Метод для отображения поданных заявок
        /// </summary>
        public void StA_Sub()
        {
            con.Open();
            string a = $"Select * from View_3 where Статус = 'подано'";
            SqlDataAdapter da = new SqlDataAdapter(a, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            StAdminDataGrid.DataSource = ds.Tables[0];
            con.Close();
        }
        /// <summary>
        /// Метод для отображения Всех заявок
        /// </summary>
        public void StA_All()
        {
            con.Open();
            string a = "Select * from View_3";
            SqlDataAdapter da = new SqlDataAdapter(a, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            StAdminDataGrid.DataSource = ds.Tables[0];
            con.Close();
        }
        /// <summary>
        /// Кнопка для отображения не принятых заявок
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Denied_Click(object sender, EventArgs e)
        {
            StA_Otk();
        }
        /// <summary>
        /// Кнопка для отображения принятых заявок
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Accepted_Click(object sender, EventArgs e)
        {
            StA_Acp();
        }
        /// <summary>
        /// Кнопка для отображения поданных заявок
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Submitted_Click(object sender, EventArgs e)
        {
            StA_Sub();
        }
        /// <summary>
        /// Кнопка для отображаения всех заявок
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void All_Click(object sender, EventArgs e)
        {
            StA_All();
        }
        /// <summary>
        /// Переход на предыдущую форму
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminPanel ap = new AdminPanel();
            ap.ShowDialog();
        }

        /// <summary>
        /// Кнопка для сортировки DataGridView по факультетам
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SortByFakBtn_Click(object sender, EventArgs e)
        {
            con.Open();
            string a = $"Select * from View_3 where Факультет = '{FakultetCbox.Text}'";
            SqlDataAdapter da = new SqlDataAdapter(a, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            StAdminDataGrid.DataSource = ds.Tables[0];
            con.Close();
        }
    }
}
