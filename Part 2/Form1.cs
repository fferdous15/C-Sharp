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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {

        }

        private void btnrockstar_Click(object sender, EventArgs e)
        {
            LoginRockstar lgn = new LoginRockstar();
            lgn.Show();
            this.Hide();
            
        }

        private void btnuser_Click(object sender, EventArgs e)
        {
            LoginUser lgn = new LoginUser();
            lgn.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            admin a = new admin();
            this.Hide();
            a.Show();
        }
    }
}
