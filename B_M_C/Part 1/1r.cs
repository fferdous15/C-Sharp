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
    public partial class _1r : UserControl
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\C# Final Project\B_M_C\B_M_C\FinalTable.mdf;Integrated Security=True;Connect Timeout=30");

        public _1r()
        {
            InitializeComponent();
        }
        DataTable dt = new DataTable();
        int indexRow;

        public void display()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            
            cmd.CommandText = " Select * from RequestFinal";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

       

       

        private void _1r_Load(object sender, EventArgs e)
        {
            //display();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexRow = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[indexRow];
            textBox1.Text = row.Cells[1].Value.ToString();
            textBox2.Text = row.Cells[4].Value.ToString();
            textBox3.Text = row.Cells[3].Value.ToString();

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("Please fill the required fields");
            }
            else
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = " Select * from RequestFinal where Hirer = '" + textBox1.Text + "' and Date = '" + textBox2.Text + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                if (dt.Rows.Count == 1)
                {
                    cmd.CommandText = "update [RequestFinal] set Decision =  '" + 1 + "' where Hirer = '" + textBox1.Text + "' and Date = '" + textBox2.Text + "'";
                    cmd.ExecuteNonQuery();
                    dataGridView1.DataSource = dt;
                }

                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                MessageBox.Show("Request accepted!");

                

                con.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;

            cmd.CommandText = " Select * from RequestFinal where Band = '" + txtshow.Text + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("Please fill the required fields");
            }
            else

            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = " Select * from RequestFinal where Hirer = '" + textBox1.Text + "' and Date = '" + textBox2.Text + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                if (dt.Rows.Count == 1)
                {
                    cmd.CommandText = "delete from [RequestFinal] where Hirer =  '" + textBox1.Text + "' and Date = '" + textBox2.Text + "'";
                    cmd.ExecuteNonQuery();
                    dataGridView1.DataSource = dt;
                }

                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";

                MessageBox.Show("Request rejected!");
                dataGridView1.DataSource = dt;



                con.Close();
            }
        }

        private void btnshow_Click(object sender, EventArgs e)
        {
            
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = " Select * from RequestFinal where Band = '" + txtshow.Text + "'";
                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);

                dataGridView1.DataSource = dt;

                con.Close();
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
