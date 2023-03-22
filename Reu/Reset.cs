using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reu
{
    public partial class Reset : Form
    {
        public Reset()
        {
            InitializeComponent();
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=ASUS\\MSSQLSERVER01;Initial Catalog=Reu;Integrated Security=True");
                SqlCommand command = new SqlCommand();
                command.CommandText = $"select count(*) from [User] where login like '{LoginTxt.Text}'";
                command.Connection = con;
                con.Open();
                int strCount = Convert.ToInt16(command.ExecuteScalar());
                if (strCount == 0)
                {
                    MessageBox.Show("Такого логина не существует! Введите верный логин или перезарегистрируйтесь(!)");
                }
                else
                { 
                    //Генерация кода
                    Random rand = new Random();
                    double code;
                    for (int j = 0; j < 2000; j++)
                    {
                        code = rand.Next(1000, 1999);
                        Code.Text = String.Join(",", code);
                    }
                    //Отправка письма на почту
                    try
                    {
                        using (System.Net.WebClient client = new System.Net.WebClient())
                        {
                            string myemail = "s.muzafari@mail.ru";
                            string mypswd = "webmaster228";
                            string zag = "ФГБОУ ВО РЭУ им. Г.В.Плеханова";
                            MailMessage mess = new MailMessage();
                            mess.To.Add(Email.Text); // адрес получателя
                            mess.From = new MailAddress(myemail, zag);
                            mess.Subject = "Сброс пароля!"; // тема
                            mess.Body = "Доброго времени суток, " + LoginTxt.Text +
                                ". Отправляем вам письмо для сброса пароля! Ваш код восстановления " + Code.Text + " (" +
                                "Не передавайте код никому. Если это были не вы проигнорируйте это письмо.)"; //Текст письма
                            SmtpClient smtp = new SmtpClient();
                            smtp.Host = "smtp.mail.ru"; //smtp-сервер отправителя
                            smtp.Port = 587;
                            smtp.EnableSsl = true;
                            smtp.Credentials = new NetworkCredential(myemail.Split('@')[0], mypswd);
                            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                            smtp.Send(mess); // отправка пользователю
                            mess.To.Remove(mess.To[0]);
                            mess.Dispose();
                            MessageBox.Show("Вы получили письмо с кодом на почту!)");
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Неверная почта!)");
                    }
                    //Изменения пароля в бд
                    command.CommandText = "UPDATE [User] set password = @password where login = @login"; // запрос на вставку
                    command.Parameters.AddWithValue("@login", LoginTxt.Text);
                    command.Parameters.AddWithValue("@password", Code.Text);
                    command.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Сброс пароля совершён! Измените пароль!!");
                    this.Hide();
                    EditPassword edpswd = new EditPassword();
                    edpswd.Show();
                }
            }
            catch
            {
                MessageBox.Show("Что-то произошло не так!");
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Auth auth = new Auth();
            auth.Show();
        }
    }
}
