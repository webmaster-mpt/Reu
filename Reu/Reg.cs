using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Reu
{
    public partial class Reg : Form
    {
        public Reg()
        {
            InitializeComponent();
        }
        private string role = "user";
        private void RegBtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=ASUS\\MSSQLSERVER01;Initial Catalog=Reu;Integrated Security=True");
            try
            {
                SqlCommand command = new SqlCommand();
                command.CommandText = $"select count(*) from [User] where login like '{LoginTxt.Text}'";
                command.Connection = con;
                con.Open();
                int strCount = Convert.ToInt16(command.ExecuteScalar());
                if (strCount == 0)
                {
                    if ((LoginTxt.Text.Length < 10 && LoginTxt.Text.Length > 4) 
                        && (PasswordTxt.Text.Length < 10 && PasswordTxt.Text.Length > 4))
                    {
                        SqlCommand insert = new SqlCommand();
                        insert.CommandText = "insert into [User] values (@login,@password,@role,@email)"; // запрос на вставку
                        insert.Connection = con;
                        insert.Parameters.AddWithValue("@login", LoginTxt.Text);
                        insert.Parameters.AddWithValue("@password", PasswordTxt.Text);
                        insert.Parameters.AddWithValue("@role", role);
                        insert.Parameters.AddWithValue("@email", Email.Text);

                        insert.ExecuteNonQuery();
                        con.Close();

                        MessageBox.Show("Регистрация прошла успешно! Авторизуйтесь!");
                        this.Hide();
                        Auth auth = new Auth();
                        auth.Show();
                    }
                    else 
                    {
                        MessageBox.Show("Проверить правильность заполнение полей");
                    } 
                }
                else
                {
                    MessageBox.Show("Такой логин уже занят " + LoginTxt.Text + "!)");
                    LoginTxt.Clear();
                    con.Close();
                }
            }
            catch
            {
                MessageBox.Show("Пароль и логин НЕ соответствуют требованиям");
            }
        }

        private void AuthLbl_Click(object sender, EventArgs e)
        {
            this.Hide();
            Auth auth = new Auth();
            auth.Show();
        }
    }
}
