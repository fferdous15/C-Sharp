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
using System.IO;

namespace B_M_C
{
    public partial class LoginUser : Form
    {
       
        private void LoginUser_Load(object sender, EventArgs e)
        {
            
        }

        public LoginUser()
        {
            InitializeComponent();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
        }

       

        private void btnsignup_Click(object sender, EventArgs e)
        {
            UserSignup us = new UserSignup();
            us.Show();
            this.Hide();
            
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\C# Final Project\B_M_C\B_M_C\FinalTable.mdf;Integrated Security=True;Connect Timeout=30");
            string query = "select * from [UserFinal] where username_ = '" + txtuser.Text.Trim() + "' and password_ = '" + txtpass.Text.Trim() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dtbl = new DataTable();
            
            if (dtbl.Rows.Count == 1)
            {
                UserHome uh = new UserHome();
                
                uh.Show();
                
                this.Hide();
                
            }
            else
            {
                MessageBox.Show("Incorrect Username or Password!");
                
            }

           
            
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void txtpass_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuGradientPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

       
    }
}
