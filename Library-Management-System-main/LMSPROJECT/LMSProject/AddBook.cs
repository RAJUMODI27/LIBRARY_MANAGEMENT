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

namespace LMSProject
{
    public partial class AddBook : Form
    {
        public AddBook()
        {
            InitializeComponent();
        }

       

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

      

        

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\rnmod\OneDrive\Desktop\Library-Management-System-main\LMSPROJECT\LMSProject\LMSDB.mdf;Integrated Security=True");
            using (conn)
            {
                if (txtbkName.Text != "" && txtbkAuthor.Text != "" && txtbkPublication.Text != "" && bkPurchaseDate.Text != "" && txtbkPrice.Text != "" && txtbkQuantity.Text != "")
                {
                    SqlCommand cmd = new SqlCommand("insert into tblBookInfos(bkName,bkAuthor,bkPublication,bkDate,bkPrice,bkQuanity) values('" + txtbkName.Text + "', '" + txtbkAuthor.Text + "'," +
                   "'" + txtbkPublication.Text + "', '" + bkPurchaseDate.Text + "', '" + Int64.Parse(txtbkPrice.Text) + "', '" + Int64.Parse(txtbkQuantity.Text) + "') ", conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Book Infos saved.", " Success" + MessageBoxButtons.OK + MessageBoxIcon.Information);
                    txtbkName.Clear();
                    txtbkAuthor.Clear();
                    txtbkPublication.Clear();
                    // bkPurchaseDate.Clear();
                    txtbkPrice.Clear();
                    txtbkQuantity.Clear();
                }
                else
                {
                    MessageBox.Show("No Info entered.", "Error" + MessageBoxButtons.OK + MessageBoxIcon.Warning);
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtbkName.Clear();
            txtbkAuthor.Clear();
            txtbkPublication.Clear();
            // bkPurchaseDate.Clear();
            txtbkPrice.Clear();
            txtbkQuantity.Clear();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
