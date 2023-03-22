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
using System.Reflection;
using Word = Microsoft.Office.Interop.Word;
using System.IO;

namespace Reu
{
    public partial class Lk : Form
    {
        SqlConnection con = new SqlConnection("Data Source=ASUS\\MSSQLSERVER01;Initial Catalog=Reu;Integrated Security=True");

        public Lk()
        {
            InitializeComponent();
            con.Open();
            string s = $"Select * from View_3 where Пользователь = '{Login.Text = Get.id}'";
            SqlDataAdapter xa = new SqlDataAdapter(s, con);
            DataSet xs = new DataSet();
            xa.Fill(xs, "View_3");
            LkDataGrid.DataSource = xs.Tables["View_3"];
            con.Close();
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
                
                this.FindAndReplace(wordApp, "<ot>", OtTxt.Text);
                this.FindAndReplace(wordApp, "<group>", GroupTxt.Text);
                this.FindAndReplace(wordApp, "<fak>", FakTxt.Text);
                this.FindAndReplace(wordApp, "<telephone>", TelephoneTxt.Text);
                this.FindAndReplace(wordApp, "<infoB>", CauseTxt.Text);
                this.FindAndReplace(wordApp, "<date>", DateTxt.Text);
                this.FindAndReplace(wordApp, "<infoEnd>", InfoTxt.Text);
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

        private void SaveDocx_Click(object sender, EventArgs e)
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
                        CreateWordDocument(@"C:\Users\user\source\repos\Reu\Заявка.docx", @"C:\Users\user\source\repos\Reu\Reu\Заявка.docx");
                        CreateWordDocument(@"C:\Users\user\source\repos\Reu\Reu\Заявка.docx", path);
                    }
                }
                MessageBox.Show("Файл сохранен!");
            }
            catch
            {
                MessageBox.Show("Что-то случилось не так(");
            }
            
        }

        private void LkDataGrid_SelectionChanged(object sender, EventArgs e)
        {
            if (LkDataGrid.SelectedCells.Count == 0) return;
            Login.Text = LkDataGrid.Rows[LkDataGrid.CurrentCell.RowIndex].Cells[0].Value.ToString();
            OtTxt.Text = LkDataGrid.Rows[LkDataGrid.CurrentCell.RowIndex].Cells[1].Value.ToString();
            GroupTxt.Text = LkDataGrid.Rows[LkDataGrid.CurrentCell.RowIndex].Cells[2].Value.ToString();
            FakTxt.Text = LkDataGrid.Rows[LkDataGrid.CurrentCell.RowIndex].Cells[3].Value.ToString();
            TelephoneTxt.Text = LkDataGrid.Rows[LkDataGrid.CurrentCell.RowIndex].Cells[4].Value.ToString();
            CauseTxt.Text = LkDataGrid.Rows[LkDataGrid.CurrentCell.RowIndex].Cells[5].Value.ToString();
            InfoTxt.Text = LkDataGrid.Rows[LkDataGrid.CurrentCell.RowIndex].Cells[6].Value.ToString();
            DateTxt.Text = LkDataGrid.Rows[LkDataGrid.CurrentCell.RowIndex].Cells[7].Value.ToString();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            PanelUser st = new PanelUser();
            st.Show();
        }

        private void Se_Click(object sender, EventArgs e)
        {
            try
            {
                CreateWordDocument(@"C:\Users\user\source\repos\Reu\Заявка.docx", @"C:\Users\user\source\repos\Reu\Reu\Заявка.docx");
                this.Hide();
                SendEmail se = new SendEmail();
                se.Show();
            }
            catch
            {
                MessageBox.Show("Что-то случилось не так(");
            }
           
        }
    }
}
