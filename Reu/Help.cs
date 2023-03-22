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
    public partial class Help : Form
    {
        public Help()
        {
            InitializeComponent();
            this.FormClosing += Help_FormClosing;
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Claim cl = new Claim();
            cl.Show();
        }

        private void Help_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
