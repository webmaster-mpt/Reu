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
    public partial class Fak : Form
    {
        SqlConnection con = new SqlConnection("Data Source=ASUS\\MSSQLSERVER01;Initial Catalog=Reu;Integrated Security=True");

        public Fak()
        {
            InitializeComponent();
            FakRef();
        }

        public void FakRef()
        {
            con.Open();
            string a = "Select * from Fakultet";
            SqlDataAdapter da = new SqlDataAdapter(a, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            FakDtGrid.DataSource = ds.Tables[0];
            con.Close();
        }

        private void Function_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Function.SelectedItem == "Добавления")
            {
                AddPanel.Visible = true;
                EditPanel.Visible = false;
                DelPanel.Visible = false;
            }
            if (Function.SelectedItem == "Изменение")
            {
                AddPanel.Visible = false;
                EditPanel.Visible = true;
                DelPanel.Visible = false;
            }
            if (Function.SelectedItem == "Удаление")
            {
                AddPanel.Visible = false;
                EditPanel.Visible = false;
                DelPanel.Visible = true;
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminPanel ap = new AdminPanel();
            ap.Show();
        }

        private void FakDtGrid_SelectionChanged(object sender, EventArgs e)
        {
            if (FakDtGrid.SelectedCells.Count == 0) return;
            //Изменить
            NameEdTxt.Text = FakDtGrid.Rows[FakDtGrid.CurrentCell.RowIndex].Cells[1].Value.ToString();
            //Удалить
            NameDelTxt.Text = FakDtGrid.Rows[FakDtGrid.CurrentCell.RowIndex].Cells[1].Value.ToString();
            FakDtGrid.Columns[0].Visible = false;
            FakDtGrid.Columns[1].HeaderText = "Наименование";
        }

        private void AddFak_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand command = new SqlCommand();
                command.CommandText = $"select count(*) from [Fakultet] where name like '{NameAddTxt.Text}'";
                command.Connection = con;
                con.Open();
                int strCount = Convert.ToInt16(command.ExecuteScalar());
                if (strCount == 0)
                {
                    if ((NameAddTxt.Text.Length < 50 && NameAddTxt.Text.Length > 1))
                    {
                        SqlCommand insert = new SqlCommand();
                        insert.CommandText = "insert into Fakultet values (@Name)"; // запрос на вставку
                        insert.Connection = con;
                        insert.Parameters.AddWithValue("@Name", NameAddTxt.Text);
                        insert.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Вы добавили новый факультет!)");
                        FakRef();
                    }
                    else
                    {
                        MessageBox.Show("Проверить правильность заполнение полей");
                    }
                }
                else
                {
                    MessageBox.Show("Такой Факультет уже есть!Проверьте и измените название факультета");
                    NameAddTxt.Clear();
                }
                con.Close();
            }
            catch
            {
                MessageBox.Show("Неверные данные");
            }
        }

        private void DelFak_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand del = new SqlCommand("Fakultet_Del", con);
                del.CommandType = System.Data.CommandType.StoredProcedure;
                del.Parameters.AddWithValue("@id", FakDtGrid.Rows[FakDtGrid.SelectedCells[0].RowIndex].Cells[0].Value);
                del.ExecuteScalar();
                con.Close();
                MessageBox.Show("Вы удалили факультет из списка!)");
                FakRef();
            }
            catch
            {
                MessageBox.Show("С данным факультетом оформлена заявка. Удалите все заявки с данным факультетом затем повторно удалите факультет");
            }
        }

        private void EdFak_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand command = new SqlCommand();
                command.CommandText = $"select count(*) from [Fakultet] where name like '{NameEdTxt.Text}'";
                command.Connection = con;
                con.Open();
                int strCount = Convert.ToInt16(command.ExecuteScalar());
                if (strCount == 0)
                {
                    if ((NameEdTxt.Text.Length < 50 && NameEdTxt.Text.Length > 1))
                    {
                        SqlCommand ed = new SqlCommand("Fakultet_Edit", con);
                        ed.CommandType = System.Data.CommandType.StoredProcedure;
                        ed.Parameters.AddWithValue("@Name", NameEdTxt.Text);
                        ed.Parameters.AddWithValue("@id", FakDtGrid.Rows[FakDtGrid.SelectedCells[0].RowIndex].Cells[0].Value);
                        ed.Connection = con;
                        ed.ExecuteScalar();
                        con.Close();
                        MessageBox.Show("Вы изменили название факультета!)");
                        FakRef();
                    }
                    else
                    {
                        MessageBox.Show("Проверить правильность заполнение полей");
                    }
                }
                else
                {
                    MessageBox.Show("Такой Факультет уже есть!Проверьте и измените название факультета");
                    NameEdTxt.Clear();
                }
                con.Close();
            }
            catch
            {
                MessageBox.Show("Неверные данные");
            }
        }
    }
}
