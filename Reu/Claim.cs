using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;
using System.Reflection;
using System.Net.Mail;
using System.Net;

namespace Reu
{
    public partial class Claim : Form
    {
        SqlConnection con = new SqlConnection("Data Source=ASUS\\MSSQLSERVER01;Initial Catalog=Reu;Integrated Security=True");
        public Claim()
        {
            InitializeComponent();
            con.Open();
            string s = "Select * from [Received]";
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
            xa.SelectCommand = new SqlCommand("Select * from [User]", con);
            xa.Fill(xs, "userecb");
            this.Email.DataSource = xs.Tables["userecb"];
            Email.DisplayMember = "email";
            Email.ValueMember = "id";
            con.Close();
        }
        private void Claim_Load(object sender, EventArgs e)
        {
            Login.Text = Convert.ToString(Get.id);
        }
        private void FindAndReplace(Word.Application wordApp, object ToFindText, object replaceWithText)
        {
            object matchCase = true;
            object matchWholeWord = true;
            object matchWildCards = false;
            object matchSoundLike = false;
            object nmatchAllforms = false;
            object forward = true;
            object format = false;
            object matchKashida = false;
            object matchDiactitics = false;
            object matchAlefHamza = false;
            object matchControl = false;
            object read_only = false;
            object visible = true;
            object replace = 2;
            object wrap = 1;

            wordApp.Selection.Find.Execute(ref ToFindText,
                ref matchCase, ref matchWholeWord,
                ref matchWildCards, ref matchSoundLike,
                ref nmatchAllforms, ref forward,
                ref wrap, ref format, ref replaceWithText,
                ref replace, ref matchKashida,
                ref matchDiactitics, ref matchAlefHamza,
                ref matchControl);
        }
        //Creeate the Doc Method
        private void CreateWordDocument(object filename, object SaveAs)
        {
            Word.Application wordApp = new Word.Application();
            object missing = Missing.Value;
            Word.Document myWordDoc = null;

            if (File.Exists((string)filename))
            {
                object readOnly = false;
                object isVisible = false;
                wordApp.Visible = false;

                myWordDoc = wordApp.Documents.Open(ref filename, ref missing, ref readOnly,
                                        ref missing, ref missing, ref missing,
                                        ref missing, ref missing, ref missing,
                                        ref missing, ref missing, ref missing,
                                        ref missing, ref missing, ref missing, ref missing);
                myWordDoc.Activate();

                this.FindAndReplace(wordApp, "<fname>", FNameTxt.Text);
                this.FindAndReplace(wordApp, "<name>", NameTxt.Text);
                this.FindAndReplace(wordApp, "<sname>", SNameTxt.Text);
                this.FindAndReplace(wordApp, "<date>", DateTxt.Text);
            }
            else
            {
                MessageBox.Show("File not Found!");
            }

            //Save as
            myWordDoc.SaveAs2(ref SaveAs, ref missing, ref missing, ref missing,
                            ref missing, ref missing, ref missing,
                            ref missing, ref missing, ref missing,
                            ref missing, ref missing, ref missing,
                            ref missing, ref missing, ref missing);

            myWordDoc.Close();
            wordApp.Quit();
        }
        public string path;
        private void Send_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand insert = new SqlCommand();
                insert.CommandText = "insert into [Received] values (@user_id,@fname,@name,@sname,@group," +
                        "@fakultet_id,@telephone_number,@cause_id,@info,@datecl,@status,@whynot)";
                insert.Connection = con;
                insert.Parameters.AddWithValue("@user_id", Login.SelectedValue);
                insert.Parameters.AddWithValue("@fname", FNameTxt.Text);
                insert.Parameters.AddWithValue("@name", NameTxt.Text);
                insert.Parameters.AddWithValue("@sname", SNameTxt.Text);
                insert.Parameters.AddWithValue("@group", GroupTxt.Text);
                insert.Parameters.AddWithValue("@fakultet_id", FakultetCbox.SelectedValue);
                insert.Parameters.AddWithValue("@telephone_number", TelephoneTxt.Text);
                insert.Parameters.AddWithValue("@cause_id", CauseCbox.SelectedValue);
                insert.Parameters.AddWithValue("@info", InfoTxt.Text);
                insert.Parameters.AddWithValue("@datecl", DateTxt.Text);
                insert.Parameters.AddWithValue("@status", "подано");
                insert.Parameters.AddWithValue("@whynot", "");
                CreateWordDocument(@"C:\Users\user\source\repos\Reu\Электронный пропуск123.docx", @"C:\Users\user\source\repos\Reu\Reu\Электронный пропуск1.docx");
                insert.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Вы подали заявку на получение нового пропуска!Выберите способ получения " +
                    "временного электронного пропуска)");
                string sql = "Select email from [User] Where id=@id";
                SqlDataAdapter sda = new SqlDataAdapter(sql, con);
                con.Open();
                using (var cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@id", Login.SelectedValue);
                    using (var dr = cmd.ExecuteReader())
                    {
                        dr.Read();
                        Email.Text = dr.GetString(0);
                    }
                }
                con.Close();
                PanelSave.Visible = true;
            }
            catch
            {
                MessageBox.Show("Неверные данные");
            }
        }
        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            PanelUser st = new PanelUser();
            st.Show();
        }
        private void Save_Click(object sender, EventArgs e)
        {
            try
            {
                var path = string.Empty;
                using (SaveFileDialog sv = new SaveFileDialog())
                {
                    sv.Filter = "docx files(*.docx)|*.docx";
                    sv.FilterIndex = 2;
                    sv.RestoreDirectory = true;
                    if (sv.ShowDialog() == DialogResult.OK)
                    {
                        path = sv.FileName;
                        CreateWordDocument(@"C:\Users\user\source\repos\Reu\Reu\Электронный пропуск1.docx", path);
                    }
                    else
                    {
                        return;
                    }
                }
                MessageBox.Show("Файл сохранен!");
            }
            catch
            {
                MessageBox.Show("Что-то случилось не так(");
            }
        }
        private void SendEmail_Click(object sender, EventArgs e)
        {
            if(Email.Text == "")
            {
                this.Hide();
                temporary_pass tp = new temporary_pass();
                tp.Show();
            }
            else
            {
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
                        SmtpClient smtp = new SmtpClient();
                        string file = @"C:\Users\user\source\repos\Reu\Reu\Электронный пропуск1.docx";
                        Attachment sendfile = new Attachment(file);
                        mess.Subject = "Электронный пропуск";
                        mess.Body = "Ваш, временный электронный пропуск!)";
                        mess.Attachments.Add(sendfile);
                        smtp.Host = "smtp.mail.ru"; //smtp-сервер отправителя
                        smtp.Port = 587;
                        smtp.EnableSsl = true;
                        smtp.Credentials = new NetworkCredential(myemail.Split('@')[0], mypswd);
                        smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                        smtp.Send(mess); // отправка пользователю
                        mess.To.Remove(mess.To[0]);
                        mess.Dispose();
                        MessageBox.Show("Вы получили временный электронный пропуск на почту!)");
                        this.Hide();
                        PanelUser st = new PanelUser();
                        st.Show();
                    }
                }
                catch
                {
                    MessageBox.Show("Неправильная почта");
                    temporary_pass tp = new temporary_pass();
                    tp.Show();
                }
            }
        }
    }
}
