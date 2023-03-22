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
    public partial class User : Form
    {
        SqlConnection con = new SqlConnection("Data Source=ASUS\\MSSQLSERVER01;Initial Catalog=Reu;Integrated Security=True");

        public User()
        {
            InitializeComponent();
            UserRef();
        }

        public void UserRef()
        {
            con.Open();
            string a = "Select * from [User]";
            SqlDataAdapter da = new SqlDataAdapter(a, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            UserDtGrid.DataSource = ds.Tables[0];
            con.Close();
        }

        private void Function_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (Function.SelectedItem == "Изменение")
            {
                EditPanel.Visible = true;
                DelPanel.Visible = false;
            }
            if (Function.SelectedItem == "Удаление")
            {
                EditPanel.Visible = false;
                DelPanel.Visible = true;
            }
        }

        private void EdUser_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand ed = new SqlCommand("User_Edit", con);
            ed.CommandType = System.Data.CommandType.StoredProcedure;
            ed.Parameters.AddWithValue("@login", login.Text);
            ed.Parameters.AddWithValue("@password", password.Text);
            ed.Parameters.AddWithValue("@role", RoleEditCbx.Text);
            ed.Parameters.AddWithValue("@id", UserDtGrid.Rows[UserDtGrid.SelectedCells[0].RowIndex].Cells[0].Value);
            ed.Connection = con;
            ed.ExecuteScalar();
            con.Close();
            MessageBox.Show("Вы изменили роль пользователю!)");
            UserRef();
        }

        private void DelUser_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand del = new SqlCommand("User_Del", con);
                del.CommandType = System.Data.CommandType.StoredProcedure;
                del.Parameters.AddWithValue("@id", UserDtGrid.Rows[UserDtGrid.SelectedCells[0].RowIndex].Cells[0].Value);
                del.ExecuteScalar();
                con.Close();
                MessageBox.Show("Вы удалили пользователя из списка!)");
                UserRef();
            }
            catch
            {
                MessageBox.Show("Данный пользователь оформил заявку. Удалите заявку затем повторно удалите пользователя");
            }
        }

        private void UserDtGrid_SelectionChanged(object sender, EventArgs e)
        {
            if (UserDtGrid.SelectedCells.Count == 0) return;
            //Изменить
            login.Text = UserDtGrid.Rows[UserDtGrid.CurrentCell.RowIndex].Cells[1].Value.ToString();
            password.Text = UserDtGrid.Rows[UserDtGrid.CurrentCell.RowIndex].Cells[2].Value.ToString();
            RoleEditCbx.Text = UserDtGrid.Rows[UserDtGrid.CurrentCell.RowIndex].Cells[3].Value.ToString();
            //Удалить
            login.Text = UserDtGrid.Rows[UserDtGrid.CurrentCell.RowIndex].Cells[1].Value.ToString();
            password.Text = UserDtGrid.Rows[UserDtGrid.CurrentCell.RowIndex].Cells[2].Value.ToString();
            RoleDelTxt.Text = UserDtGrid.Rows[UserDtGrid.CurrentCell.RowIndex].Cells[3].Value.ToString();
            UserDtGrid.Columns[0].Visible = false;
            UserDtGrid.Columns[1].HeaderText = "Логин";
            UserDtGrid.Columns[2].HeaderText = "Пароль";
            UserDtGrid.Columns[3].HeaderText = "Роль";

        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminPanel ap = new AdminPanel();
            ap.Show();
        }
    }
}
