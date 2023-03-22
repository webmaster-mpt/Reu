using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reu
{
    public partial class Student : Form
    {
        public Student()
        {
            InitializeComponent();
            this.FormClosing += Student_FormClosing;
        }
        private void Lk_Click(object sender, EventArgs e)
        {
            this.Hide();
            Lk lk = new Lk();
            lk.Show();
        }
        private void Propusk_Click(object sender, EventArgs e)
        {
            this.Hide();
            Claim cl = new Claim();
            cl.Show();
        }
        private void BackAuth_Click(object sender, EventArgs e)
        {
            this.Hide();
            Auth auth = new Auth();
            auth.Show();
        }
        private void Student_FormClosing(object sender, FormClosingEventArgs e)
        {
        }
    }
}
