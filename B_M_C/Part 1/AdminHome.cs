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
    public partial class AdminHome : Form
    {
        public AdminHome()
        {
            InitializeComponent();
        }

        private void AdminHome_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'finalTableDataSet10.UserFinal' table. You can move, or remove it, as needed.
            this.userFinalTableAdapter.Fill(this.finalTableDataSet10.UserFinal);
            // TODO: This line of code loads data into the 'finalTableDataSet9.BandFinal' table. You can move, or remove it, as needed.
            this.bandFinalTableAdapter.Fill(this.finalTableDataSet9.BandFinal);
            // TODO: This line of code loads data into the 'finalTableDataSet8.ReportTable' table. You can move, or remove it, as needed.
            this.reportTableTableAdapter.Fill(this.finalTableDataSet8.ReportTable);

        }
    }
}
