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
using System.Configuration;
using System.IO;

namespace B_M_C
{
    public partial class UserSignup : Form

        
    {
        
        //string a, b, c, d, h, f;
      
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\C# Final Project\B_M_C\B_M_C\FinalTable.mdf;Integrated Security=True;Connect Timeout=30");

        public UserSignup()
        {
            InitializeComponent();
          
        }

        private void UserSignup_Load(object sender, EventArgs e)
        {
            //a = txtFullName.Text;
            //b = txtUserName.Text;
            //d = txtPhoneNumber.Text;
            //c = txtEmail.Text;
            //h = txtAddress.Text;
            //f = dateTimePicker1.Text;
            //passtext = txtPassword.Text;
            //usertext = txtUserName.Text;
            ////Eta userlogin form theke import hoyeche
            //UserChangePassword ucp = new UserChangePassword();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }



        private void button1_Click(object sender, EventArgs e)
        {
            
            //UserPro up = new UserPro(txtFullName.Text, txtUserName.Text, txtEmail.Text, txtPhoneNumber.Text, txtAddress.Text, dateTimePicker1.Text);
            
            if (txtPassword.Text == "" || txtConfirmPassword.Text == "" || txtPassword.Text != txtConfirmPassword.Text)
                MessageBox.Show("Password doesn't match!");
            else
            {

                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into [UserFinal] (fullname,username_,email,phonenumber,address,password_,confirmpassword_,dateofbirth)" + "values(@fullname,@username_,@email,@phonenumber,@address,@password_,@confirmpassword_,@dateofbirth)";

                cmd.Parameters.AddWithValue("@username_", txtUserName.Text);
                cmd.Parameters.AddWithValue("@fullname", txtFullName.Text);
                cmd.Parameters.AddWithValue("@email", txtEmail.Text.Trim());
                cmd.Parameters.AddWithValue("@phonenumber", txtPhoneNumber.Text.Trim());
                cmd.Parameters.AddWithValue("@address", txtAddress.Text.Trim());
                cmd.Parameters.AddWithValue("@password_", txtPassword.Text.Trim());
                cmd.Parameters.AddWithValue("@confirmpassword_", txtConfirmPassword.Text.Trim());

                cmd.Parameters.AddWithValue("@dateofbirth", dateTimePicker1.Text);
                cmd.ExecuteNonQuery();
                con.Close();

               
                txtUserName.Text = "";
                txtFullName.Text = "";
                txtEmail.Text = "";
                txtPhoneNumber.Text = "";
                txtAddress.Text = "";
                txtPassword.Text = "";
                txtConfirmPassword.Text = "";
                dateTimePicker1.Text = "";

               


                MessageBox.Show("Inserted! \nPlease go back and login");
                LoginUser lu = new LoginUser();
                lu.Show();
                this.Hide();
                

            }




        }

        private void btnback_Click(object sender, EventArgs e)
        {
            LoginUser lu = new LoginUser();
            lu.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }
    }
}
