using System;
using System.Windows.Forms;

namespace Reu
{
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();
        }

        private void Fak_Click(object sender, EventArgs e)
        {
            this.Hide();
            Fak fak = new Fak();
            fak.Show();
        }

        private void StAdmin_Click(object sender, EventArgs e)
        {
            this.Hide();
            StAdmin st = new StAdmin();
            st.Show();
        }

        private void user_Click(object sender, EventArgs e)
        {
            this.Hide();
            User st = new User();
            st.Show();
        }

        private void BackAuth_Click(object sender, EventArgs e)
        {
            this.Hide();
            Auth at = new Auth();
            at.Show();
        }

        private void SortAndExport_Click(object sender, EventArgs e)
        {
            this.Hide();
            Export ex = new Export();
            ex.Show();
        }
    }
}
