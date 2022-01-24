using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace B_M_C
{

    public partial class UserChangePassword : UserControl 
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\C# Final Project\B_M_C\B_M_C\FinalTable.mdf;Integrated Security=True;Connect Timeout=30");
        public UserChangePassword()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            //SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\C# Final Project\B_M_C\B_M_C\FinalTable.mdf;Integrated Security=True;Connect Timeout=30");

            if (txtnewpass.Text == txtconpass.Text)
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from UserFinal where username_ = '" + txtolduser.Text + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                if (dt.Rows.Count == 1)
                {
                    cmd.CommandText = "update [UserFinal] set password_ =  '" + txtnewpass.Text + "' where username_ = '" + txtolduser.Text + "'";
                    cmd.ExecuteNonQuery();
                }
                con.Close();
                txtolduser.Text = "";
                txtnewpass.Text = "";
                txtconpass.Text = "";
                MessageBox.Show("Password Changed!");
            }

            else
            {
                MessageBox.Show("New Password and Confirm Password doesn't match!");
            }
        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ChangePassword_Load(object sender, EventArgs e)
        {
            
        }
    }
}
