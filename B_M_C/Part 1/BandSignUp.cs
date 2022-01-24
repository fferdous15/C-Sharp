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
    public partial class BandSignUp : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\C# Final Project\B_M_C\B_M_C\FinalTable.mdf;Integrated Security=True;Connect Timeout=30");

        public BandSignUp()
        {
            InitializeComponent();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            LoginRockstar lu = new LoginRockstar();
            lu.Show();
            this.Hide();
        }

        private void Bbtnsign_Click(object sender, EventArgs e)
        {
            if (BtxtPassword.Text == "" || BtxtConfirmPassword.Text == "" || BtxtPassword.Text != BtxtConfirmPassword.Text)
                MessageBox.Show("Password doesn't match!");
            else
            {

                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into [BandFinal] (Name,UserName,Email,ContactNo,Password,ConfirmPassword,Remuneration)" + "values(@Name,@UserName,@Email,@ContactNo,@Password,@ConfirmPassword,@Remuneration)";

                cmd.Parameters.AddWithValue("@Name", BtxtFullName.Text);
                cmd.Parameters.AddWithValue("@UserName", BtxtUserName.Text);
                cmd.Parameters.AddWithValue("@Email", BtxtEmail.Text.Trim());
                cmd.Parameters.AddWithValue("@ContactNo", BtxtPhoneNumber.Text.Trim());
                
                cmd.Parameters.AddWithValue("@Password", BtxtPassword.Text.Trim());
                cmd.Parameters.AddWithValue("@ConfirmPassword", BtxtConfirmPassword.Text.Trim());

                cmd.Parameters.AddWithValue("@Remuneration", BtxtRemu.Text.Trim());
                cmd.ExecuteNonQuery();
                con.Close();
                
                BtxtFullName.Text = "";
                BtxtUserName.Text = "";
                BtxtEmail.Text = "";
                BtxtPhoneNumber.Text = "";
                BtxtPassword.Text = "";
                BtxtConfirmPassword.Text = "";
                BtxtRemu.Text = "";


                MessageBox.Show("Signed! \nPlease go back and login");
                LoginRockstar lu = new LoginRockstar();
                lu.Show();
                this.Hide();

            }
        }

        private void BandSignUp_Load(object sender, EventArgs e)
        {

        }
    }
}
