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
    public partial class BandHome : Form
    {
        public BandHome()
        {
            InitializeComponent();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
           
        }

        private void BbtnReq_Click(object sender, EventArgs e)
        {
           _1r1.BringToFront();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            _1cp1.BringToFront();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bChangePass1_Load(object sender, EventArgs e)
        {

        }

        private void BandHome_Load(object sender, EventArgs e)
        {

        }

        private void _1cp1_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       
    }
}
