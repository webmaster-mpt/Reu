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
    public partial class EditPassword : Form
    {
        public EditPassword()
        {
            InitializeComponent();
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=ASUS\\MSSQLSERVER01;Initial Catalog=Reu;Integrated Security=True");
            SqlCommand command = new SqlCommand();
            command.CommandText = $"select count(*) from [User] where login like '{LoginTxt.Text}' and password like '{Code.Text}'";
            command.Connection = con;
            con.Open();
            int strCount = Convert.ToInt16(command.ExecuteScalar());
            if (strCount == 0)
            {
                MessageBox.Show("Код или логин не верны!");
            }
            else
            {
                if (NewPassword.Text.Length < 10 && NewPassword.Text.Length > 4)
                {
                    command.CommandText = "UPDATE [User] set password = @password where login = @login"; // запрос на вставку
                    command.Parameters.AddWithValue("@login", LoginTxt.Text);
                    command.Parameters.AddWithValue("@password", NewPassword.Text);
                    command.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Пароль был изменен!Попробуйте войти");
                    this.Hide();
                    Auth auth = new Auth();
                    auth.Show();
                }
                else
                {
                    MessageBox.Show("Новый пароль содержит больше 10 символов или меньше 4!");
                }
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Reset res = new Reset();
            res.Show();
        }
    }
}
