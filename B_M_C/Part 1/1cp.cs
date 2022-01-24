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
    public partial class _1cp : UserControl
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\C# Final Project\B_M_C\B_M_C\FinalTable.mdf;Integrated Security=True;Connect Timeout=30");

        public _1cp()
        {
            InitializeComponent();
        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            if (txtnewpass.Text == txtconpass.Text)
            {
                
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update [BandFinal] set Password =  '" + txtnewpass.Text + "' where UserName = '" + txtolduser.Text + "'";
                //cmd.Parameters.AddWithValue("@Pass", txtnewpass.Text.Trim());
                //cmd.Parameters.AddWithValue("@Ba", txtolduser.Text.Trim());
                con.Open();
                cmd.ExecuteNonQuery();
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
    }
}
