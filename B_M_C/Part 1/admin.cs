using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace B_M_C
{
    public partial class admin : Form
    {
        public admin()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.Hide();
            f.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\C# Final Project\B_M_C\B_M_C\FinalTable.mdf;Integrated Security=True;Connect Timeout=30");
            string query = "select * from [AdminTable] where Admin = '" + txtuser.Text.Trim() + "' and Pass = '" + txtpass.Text.Trim() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            if (dtbl.Rows.Count == 1)
            {
                AdminHome ah = new AdminHome();

                ah.Show();

                this.Hide();

            }
            else
            {
                MessageBox.Show("Incorrect Username or Password!");

            }
        }
    }
}
