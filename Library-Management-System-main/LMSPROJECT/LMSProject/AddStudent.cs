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
    public partial class AddStudent : Form
    {
        public AddStudent()
        {
            InitializeComponent();
        }

       

       

       
       

       

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtstName.Clear();
            txtstNumber.Clear();
            txtstDepartment.Clear();
            txtstSemester.Clear();
            txtstEmail.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\rnmod\OneDrive\Desktop\Library-Management-System-main\LMSPROJECT\LMSProject\LMSDB.mdf;Integrated Security=True");
            using (conn)
            {
                if (txtstName.Text != "" && txtstNumber.Text != "" && txtstDepartment.Text != "" && txtstSemester.Text != "" && txtstContact.Text != "" && txtstEmail.Text != "")
                {
                    //Int64 contact = Int64.Parse(txtstContact.Text);
                    SqlCommand cmd = new SqlCommand("insert into tblStudentInfos(stName,stNumber,stDepartment,stSemester,stContact,stEmail) values('" + txtstName.Text + "', '" + txtstNumber.Text + "'," +
                   "'" + txtstDepartment.Text + "', '" + txtstSemester.Text + "', '" + Int64.Parse(txtstContact.Text) + "', '" + txtstEmail.Text + "') ", conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Student Infos saved.", " Success" + MessageBoxButtons.OK + MessageBoxIcon.Information);
                    txtstName.Clear();
                    txtstNumber.Clear();
                    txtstDepartment.Clear();
                    txtstSemester.Clear();
                    txtstContact.Clear();
                    txtstEmail.Clear();
                }
                else
                {
                    MessageBox.Show("No Info entered.", "Error" + MessageBoxButtons.OK + MessageBoxIcon.Warning);
                }

            }
        }
    }
}
