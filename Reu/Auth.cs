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
    public partial class Auth : Form
    {
        public Auth()
        {
            InitializeComponent();
            this.FormClosing += Auth_FormClosing;//закрывает форму
        }

        private void AuthBtn_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=ASUS\\MSSQLSERVER01;Initial Catalog=Reu;Integrated Security=True");
                SqlDataAdapter sda = new SqlDataAdapter("Select role from [User] Where login=@login and password = @password", con);
                sda.SelectCommand.Parameters.AddWithValue("@login", LoginTxt.Text);    
                sda.SelectCommand.Parameters.AddWithValue("@password", PasswordTxt.Text);
                DataTable dt = new System.Data.DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "admin")
                {
                    this.Hide();
                    AdminPanel admin = new AdminPanel();
                    admin.Show();
                }
                if (dt.Rows[0][0].ToString() == "user")
                {
                    Get.id = LoginTxt.Text;
                    this.Hide();
                    PanelUser admin = new PanelUser();
                    admin.Show();
                }
            }
            catch
            {
                MessageBox.Show("Вы не зареганы, зарегайтесь! Или же проверьте правильность заполнение полей");
            }
        }

        private void RegLbl_Click(object sender, EventArgs e)
        {
            this.Hide();
            Reg reg = new Reg();
            reg.Show();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void RefreshPassword_Click(object sender, EventArgs e)
        {
            this.Hide();
            Reset reset = new Reset();
            reset.Show();
        }

        private void Auth_FormClosing(object sender, FormClosingEventArgs e)
        {
            //для закрытия формы
        }
    }
}
