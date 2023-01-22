using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMSProject
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login admin = new Login();
            admin.Show();
        }

        

        private void booksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BookSearch bksearch = new BookSearch();
            bksearch.Show();
        }

        private void circularPicture1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void circularPicture1_Click_1(object sender, EventArgs e)
        {
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
