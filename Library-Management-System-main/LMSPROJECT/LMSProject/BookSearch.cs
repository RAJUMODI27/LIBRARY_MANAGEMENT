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
    public partial class BookSearch : Form
    {
        public BookSearch()
        {
            InitializeComponent();
        }

        private void BookSearch_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\rnmod\OneDrive\Desktop\Library-Management-System-main\LMSPROJECT\LMSProject\LMSDB.mdf;Integrated Security=True");
            using (conn)
            {

                SqlCommand cmd = new SqlCommand("select bkName as BookName, bkAuthor as BookAuthor, bkPublication as BookPublication, bkDate as BookDate from tblBookInfos", conn);
                conn.Open();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                DataSet dataset = new DataSet();
                dataAdapter.Fill(dataset);
                dataGridView1.DataSource = dataset.Tables[0];
            }
        }

        private void txtBookName_TextChanged(object sender, EventArgs e)
        {
            if (txtBookName.Text != "")
            {
                SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\rnmod\OneDrive\Desktop\Library-Management-System-main\LMSPROJECT\LMSProject\LMSDB.mdf;Integrated Security=True");
                using (conn)
                {

                    SqlCommand cmd = new SqlCommand("select  bkName as BookName, bkAuthor as BookAuthor, bkPublication as BookPublication, bkDate as BookDate from tblBookInfos where bkName like '" + txtBookName.Text + "%'", conn);
                    conn.Open();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                    DataSet dataset = new DataSet();
                    dataAdapter.Fill(dataset);
                    dataGridView1.DataSource = dataset.Tables[0];
                }
            }
            else
            {
                SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\rnmod\OneDrive\Desktop\Library-Management-System-main\LMSPROJECT\LMSProject\LMSDB.mdf;Integrated Security=True");
                using (conn)
                {

                    SqlCommand cmd = new SqlCommand("select  bkName as BookName, bkAuthor as BookAuthor, bkPublication as BookPublication, bkDate as BookDate from tblBookInfos", conn);
                    conn.Open();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                    DataSet dataset = new DataSet();
                    dataAdapter.Fill(dataset);
                    dataGridView1.DataSource = dataset.Tables[0];
                }
            }
        }

       

        

        private void button1_Click(object sender, EventArgs e)
        {
            txtBookName.Clear();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
