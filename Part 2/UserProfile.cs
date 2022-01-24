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
    public partial class UserProfile : UserControl
    {
        
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\C# Final Project\B_M_C\B_M_C\FinalTable.mdf;Integrated Security=True;Connect Timeout=30");


        public UserProfile(string s)
        {
            InitializeComponent();
            txtn.Text = s;
          
        }

        public UserProfile()
        {
        }

        DataTable dt = new DataTable();
        int indexRow;

        public void display()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;

            cmd.CommandText = " Select * from UserFinal";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void UserProfile_Load(object sender, EventArgs e)
        {
            display();
            
        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexRow = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[indexRow];
            txtn.Text = row.Cells[1].Value.ToString();
            txtun.Text = row.Cells[0].Value.ToString();
            txtpn.Text = row.Cells[3].Value.ToString();
            txte.Text = row.Cells[2].Value.ToString();
            txta.Text = row.Cells[4].Value.ToString();
            txtdob.Text = row.Cells[5].Value.ToString();
        }

        private void txtn_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
