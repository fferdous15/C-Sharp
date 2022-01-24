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
    public partial class UserBands : UserControl
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\C# Final Project\B_M_C\B_M_C\FinalTable.mdf;Integrated Security=True;Connect Timeout=30");


        public UserBands()
        {
            InitializeComponent();
        }
        DataTable dt = new DataTable();
        int indexRow;

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void display()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = " Select * from BandFinal";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void UserBands_Load(object sender, EventArgs e)
        {
            display();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = " Select * from BandFinal where Name = '"+ textBox1.Text+ "'";
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                dataGridView1.DataSource = dt;
                
            }

            else
            {
                MessageBox.Show("There are no such Bands!");
            }
            con.Close();

            textBox1.Text = "";

        }

        private void btnHire_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\C# Final Project\B_M_C\B_M_C\FinalTable.mdf;Integrated Security=True;Connect Timeout=30");
          
            string q = "select * from [RequestFinal] where Band ='"+textBox2.Text.Trim()+"' and Date = '"+dateTimePicker1.Text+"'";
            SqlDataAdapter sda = new SqlDataAdapter(q, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows.Count == 1)
            {
                MessageBox.Show("Please Pick another date!");
            }
            else
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = " Select * from BandFinal where Name = '" + textBox2.Text + "'";
                cmd.ExecuteNonQuery();
                DataTable dtbl = new DataTable();
                SqlDataAdapter sa = new SqlDataAdapter(cmd);
                sa.Fill(dtbl);
                if (dtbl.Rows.Count == 1)
                { dataGridView1.DataSource = dtbl; }
                cmd.CommandText = "insert into [RequestFinal] (Hirer,Email,Place,Date,Band)" + "values (@Hirer,@Email,@Place,@Date,@Band)";
                cmd.Parameters.AddWithValue("@Hirer", textBox4.Text.Trim());
                cmd.Parameters.AddWithValue("@Email", textBox5.Text.Trim());
                cmd.Parameters.AddWithValue("@Place", textBox3.Text.Trim());
                cmd.Parameters.AddWithValue("@Date", dateTimePicker1.Text);
                cmd.Parameters.AddWithValue("@Band", textBox2.Text.Trim());
                cmd.ExecuteNonQuery();
                MessageBox.Show("Hired!");
            }
            

            con.Close();
            textBox4.Text = "";
            textBox5.Text = "";
            textBox3.Text = "";
            textBox2.Text = "";
            dateTimePicker1.Text = "";
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexRow = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[indexRow];
            textBox2.Text = row.Cells[0].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;

            cmd.CommandText = " Select * from BandFinal";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
    }
}
