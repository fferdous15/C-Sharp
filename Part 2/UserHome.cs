using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B_M_C
{
    public partial class UserHome : Form
    {
        
        public UserHome()
        {
            InitializeComponent();

        }

        private void UserHome_Load(object sender, EventArgs e)
        {
            
        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {

        }

        private void btnBands_Click(object sender, EventArgs e)
        {
            userBands.BringToFront();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {

            userChangePassword1.BringToFront();


        }

        private void btnProfile_Click(object sender, EventArgs e)
        {


        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLinks_Click(object sender, EventArgs e)
        { 

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            accreq1.BringToFront();
        }

        private void btnrp_Click(object sender, EventArgs e)
        {
            userReport1.BringToFront();
        }
    }
}
