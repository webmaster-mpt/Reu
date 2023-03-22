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
namespace Reu
{
    public partial class StAdmin : Form
    {
        SqlConnection con = new SqlConnection("Data Source=ASUS\\MSSQLSERVER01;Initial Catalog=Reu;Integrated Security=True");

        private string role;

        public StAdmin()
        {
            InitializeComponent();
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
            //add
            xa.SelectCommand = new SqlCommand("Select * from Cause", con);
            xa.Fill(xs, "causecb");
            this.CauseCbox.DataSource = xs.Tables["causecb"];
            CauseCbox.DisplayMember = "name";
            CauseCbox.ValueMember = "id";
            xa.SelectCommand = new SqlCommand("Select * from [User]", con);
            xa.Fill(xs, "usercb");
            this.Login.DataSource = xs.Tables["usercb"];
            Login.DisplayMember = "login";
            Login.ValueMember = "id";
            con.Close();
            StARef();
        }
        public void StARef()
        {
            con.Open();
            string a = "Select * from [View_2]";
            SqlDataAdapter da = new SqlDataAdapter(a, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            StAdminDataGrid.DataSource = ds.Tables[0];
            con.Close();
            con.Open();
            SqlCommand cout = con.CreateCommand();
            cout.CommandText = "select COUNT(*) as count from [View_2]"; // запрос на вставку
            SqlDataReader sqlDataReader = cout.ExecuteReader();
            string res = string.Empty;
            while (sqlDataReader.Read())
            {
                res += sqlDataReader["count"];
            }
            sqlDataReader.Close();
            con.Close();
            count.Text = res;
        }

        private void StAdminDataGrid_SelectionChanged(object sender, EventArgs e)
        {
            if (StAdminDataGrid.SelectedCells.Count == 0) return;
            id.Text = StAdminDataGrid.Rows[StAdminDataGrid.CurrentCell.RowIndex].Cells[0].Value.ToString();
            Login.Text = StAdminDataGrid.Rows[StAdminDataGrid.CurrentCell.RowIndex].Cells[1].Value.ToString();
            FNameTxt.Text = StAdminDataGrid.Rows[StAdminDataGrid.CurrentCell.RowIndex].Cells[2].Value.ToString();
            NameTxt.Text = StAdminDataGrid.Rows[StAdminDataGrid.CurrentCell.RowIndex].Cells[3].Value.ToString();
            SNameTxt.Text = StAdminDataGrid.Rows[StAdminDataGrid.CurrentCell.RowIndex].Cells[4].Value.ToString();
            GroupTxt.Text = StAdminDataGrid.Rows[StAdminDataGrid.CurrentCell.RowIndex].Cells[5].Value.ToString();
            FakultetCbox.Text = StAdminDataGrid.Rows[StAdminDataGrid.CurrentCell.RowIndex].Cells[6].Value.ToString();
            TelephoneTxt.Text = StAdminDataGrid.Rows[StAdminDataGrid.CurrentCell.RowIndex].Cells[7].Value.ToString();
            CauseCbox.Text = StAdminDataGrid.Rows[StAdminDataGrid.CurrentCell.RowIndex].Cells[8].Value.ToString();
            InfoTxt.Text = StAdminDataGrid.Rows[StAdminDataGrid.CurrentCell.RowIndex].Cells[9].Value.ToString();
            DateTxt.Text = StAdminDataGrid.Rows[StAdminDataGrid.CurrentCell.RowIndex].Cells[10].Value.ToString();
            StatusCl.Text = StAdminDataGrid.Rows[StAdminDataGrid.CurrentCell.RowIndex].Cells[11].Value.ToString();
            StatusNot.Text = StAdminDataGrid.Rows[StAdminDataGrid.CurrentCell.RowIndex].Cells[12].Value.ToString();
            StAdminDataGrid.Columns[0].Visible = false;
            StAdminDataGrid.Columns[1].HeaderText = "Пользователь";
            StAdminDataGrid.Columns[2].HeaderText = "Фамилия";
            StAdminDataGrid.Columns[3].HeaderText = "Имя";
            StAdminDataGrid.Columns[4].HeaderText = "Отчество";
            StAdminDataGrid.Columns[5].HeaderText = "Группа";
            StAdminDataGrid.Columns[6].HeaderText = "Факультет";
            StAdminDataGrid.Columns[7].HeaderText = "Телефон";
            StAdminDataGrid.Columns[8].HeaderText = "Причина";
            StAdminDataGrid.Columns[9].HeaderText = "Объяснительная";
            StAdminDataGrid.Columns[10].HeaderText = "Дата_Подачи";
            StAdminDataGrid.Columns[11].HeaderText = "Статус";
            StAdminDataGrid.Columns[12].HeaderText = "Причина_Отказа";
        }

        private void StatusCl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (StatusCl.SelectedItem == "Принято")
            {
                role = "Принято";
            }
            if (StatusCl.SelectedItem == "Отказано")
            {
                role = "Отказано";
            }
        }

        private void Send_Click(object sender, EventArgs e)
        {
            try
            {
                if (StatusCl.Text == "Принято")
                {
                    con.Open();
                    SqlCommand update = new SqlCommand();
                    update.CommandText = "UPDATE [Received] set user_id = @user_id,fname=@fname,name = @name," +
                        "sname = @sname,[group] = @group, fakultet_id = @fakultet_id," +
                        "telephone_number = @telephone_number,cause_id = @cause_id,info = @info, datecl = @datecl," +
                        "status = @status,whynot = @whynot WHERE id = @id"; // запрос на вставку
                    update.Connection = con;
                    update.Parameters.AddWithValue("@user_id", Login.SelectedValue);
                    update.Parameters.AddWithValue("@fname", FNameTxt.Text);
                    update.Parameters.AddWithValue("@name", NameTxt.Text);
                    update.Parameters.AddWithValue("@sname", SNameTxt.Text);
                    update.Parameters.AddWithValue("@group", GroupTxt.Text);
                    update.Parameters.AddWithValue("@fakultet_id", FakultetCbox.SelectedValue);
                    update.Parameters.AddWithValue("@telephone_number", TelephoneTxt.Text);
                    update.Parameters.AddWithValue("@cause_id", CauseCbox.SelectedValue);
                    update.Parameters.AddWithValue("@info", InfoTxt.Text);
                    update.Parameters.AddWithValue("@datecl", DateTxt.Text);
                    update.Parameters.AddWithValue("@status", role);
                    update.Parameters.AddWithValue("@whynot", StatusNot.Text);
                    update.Parameters.AddWithValue("@id", id.Text);
                    update.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Принято!)");
                    StARef();
                }
                else
                {
                    con.Open();
                    SqlCommand update = new SqlCommand();
                    update.CommandText = "UPDATE [Received] set user_id = @user_id,fname=@fname,name = @name," +
                        "sname = @sname,[group] = @group, fakultet_id = @fakultet_id," +
                        "telephone_number = @telephone_number,cause_id = @cause_id,info = @info, datecl = @datecl," +
                        "status = @status,whynot = @whynot WHERE id = @id"; // запрос на вставку
                    update.Connection = con;
                    update.Parameters.AddWithValue("@user_id", Login.SelectedValue);
                    update.Parameters.AddWithValue("@fname", FNameTxt.Text);
                    update.Parameters.AddWithValue("@name", NameTxt.Text);
                    update.Parameters.AddWithValue("@sname", SNameTxt.Text);
                    update.Parameters.AddWithValue("@group", GroupTxt.Text);
                    update.Parameters.AddWithValue("@fakultet_id", FakultetCbox.SelectedValue);
                    update.Parameters.AddWithValue("@telephone_number", TelephoneTxt.Text);
                    update.Parameters.AddWithValue("@cause_id", CauseCbox.SelectedValue);
                    update.Parameters.AddWithValue("@info", InfoTxt.Text);
                    update.Parameters.AddWithValue("@datecl", DateTxt.Text);
                    update.Parameters.AddWithValue("@status", role);
                    update.Parameters.AddWithValue("@whynot", StatusNot.Text);
                    update.Parameters.AddWithValue("@id", id.Text);
                    update.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Не принято!");
                    StARef();
                }
            }
            catch
            {
                MessageBox.Show("Неверные данные");
                con.Close();
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminPanel admin = new AdminPanel();
            admin.Show();
        }

        private void Del_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand delete = new SqlCommand();
                delete.CommandText = "Delete from [Received] WHERE id = @id"; // запрос на вставку
                delete.Connection = con;
                delete.Parameters.AddWithValue("@id", id.Text);
                delete.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Удалено!");
                StARef();
            }
            catch
            {
                MessageBox.Show("Чтото не то -_-");
            }
        }
    }
}
