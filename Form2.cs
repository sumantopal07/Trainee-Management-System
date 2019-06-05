using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            tableRefresh();
            dataGridView1.ReadOnly = true;
            //button1.Visible = false;
            //label6.Visible = false;
            //textBox5.Visible = false;
        }
        private void tableRefresh()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\suman\Documents\Login.mdf;Integrated Security=True;Connect Timeout=30");
            SqlDataAdapter sda = new SqlDataAdapter("Select EMPCODE,NAME,DESIGNATION,LOCATION,EMAIL From [Table] ORDER BY EMPCODE", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void DataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Button5_Click(object sender, EventArgs e)
        {

        }

        private void Button4_Click(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {
        }

        private void Button2_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        /*private int Randomidgenerator()
        {
            int min = 1000, max = 9999;
            Random random = new Random();
            return random.Next(min, max);
        }*/
        /*private String Randomidgenerator()
        {
            StringBuilder builder = new StringBuilder();
            Enumerable
               .Range(65, 26)
                .Select(e => ((char)e).ToString())
                .Concat(Enumerable.Range(97, 26).Select(e => ((char)e).ToString()))
                .Concat(Enumerable.Range(0, 10).Select(e => e.ToString()))
                .OrderBy(e => Guid.NewGuid())
                .Take(11)
                .ToList().ForEach(e => builder.Append(e));
            string id = builder.ToString();
            return id;
        }*/

        private void ADD_CLICK(object sender, EventArgs e)
        {
         
            if(textBox1.Text=="" || textBox2.Text =="" || textBox3.Text == "" || textBox4.Text == "" || textBox6.Text == "")
            {
                MessageBox.Show("Empty values are not permitted");
                return;
            }
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\suman\Documents\Login.mdf;Integrated Security=True;Connect Timeout=30");
            SqlCommand cmd;
            con.Open();
            string s = "insert into [Table](NAME,EMPCODE,LOCATION,DESIGNATION,EMAIL) values(@p1,@p2,@p3,@p4,@p5)";
            cmd = new SqlCommand(s, con);
            cmd.Parameters.AddWithValue("@p2", textBox1.Text);
            cmd.Parameters.AddWithValue("@p1", textBox2.Text);
            cmd.Parameters.AddWithValue("@p4", textBox3.Text);
            cmd.Parameters.AddWithValue("@p3", textBox4.Text);
            cmd.Parameters.AddWithValue("@p5", textBox6.Text);
            cmd.CommandType = CommandType.Text;
            try
            {
                int i = cmd.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Not satisfying database constraints");
            }
            con.Close();
            tableRefresh();
            foreach (Control c in Controls)
                if (c is TextBox)
                {
                    c.Text = "";
                }
            Guid guid = Guid.NewGuid();
            string str = guid.ToString();
        
        }

        private void DELETE_CLICK(object sender, EventArgs e)
        {
            int selectedrowindex, i;
            DataGridViewRow selectedRow;
            string a, x;
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                if (dataGridView1.SelectedCells.Count > 0)
                {
                    selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;

                    selectedRow = dataGridView1.Rows[selectedrowindex];

                    a = Convert.ToString(selectedRow.Cells["DESIGNATION"].Value);
                    x = Convert.ToString(selectedRow.Cells["EMPCODE"].Value);
                    if (a != "ADMIN")
                    {
                        MessageBox.Show("Deleted Successfully");
                        //DialogResult res = MessageBox.Show("Are you sure you want to Delete", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                        dataGridView1.Rows.RemoveAt(row.Index);
                        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\suman\Documents\Login.mdf;Integrated Security=True;Connect Timeout=30");
                        SqlCommand cmd;
                        con.Open();
                        string s = "delete from [Table] where EMPCODE='" + x + "'";
                        cmd = new SqlCommand(s, con);
                        cmd.CommandType = CommandType.Text;
                        i = cmd.ExecuteNonQuery();
                        con.Close();
                        tableRefresh();
                    }
                    else
                    {
                        MessageBox.Show("Admin Deletion is not  Permitted");
                    }
                }
                else
                {
                    MessageBox.Show("Select Row to delete!");
                }
            }
            if(dataGridView1.SelectedCells.Count<=0)
            {
                MessageBox.Show("Select Row to delete!"); 
            }
        }
        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form5 x = new Form5();
            x.Show();
        }

        private void Button2_Click_1(object sender, EventArgs e)
        {
            
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            if (textBox5.Text == "")
            {
                MessageBox.Show("Name must not be empty to perform search");
                return;
            }
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\suman\Documents\Login.mdf;Integrated Security=True;Connect Timeout=30");
            SqlDataAdapter sda = new SqlDataAdapter("Select EMPCODE,NAME,DESIGNATION,LOCATION,EMAIL From [Table] WHERE NAME LIKE'%"+textBox5.Text+"%'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void Button2_Click_2(object sender, EventArgs e)
        {
            /*
            int selectedrowindex, i;
            DataGridViewRow selectedRow;
            string a, x;
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                if (dataGridView1.SelectedCells.Count > 0)
                {
                    selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;

                    selectedRow = dataGridView1.Rows[selectedrowindex];

                    a = Convert.ToString(selectedRow.Cells["DESIGNATION"].Value);
                    x = Convert.ToString(selectedRow.Cells["EMPCODE"].Value);
                    DialogResult res = MessageBox.Show("Are you sure you want to Delete", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    dataGridView1.Rows.RemoveAt(row.Index);
                        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\suman\Documents\Login.mdf;Integrated Security=True;Connect Timeout=30");
                        SqlCommand cmd;
                        con.Open();
                        string s = "delete from [Table] where EMPCODE='" + x + "'";
                        cmd = new SqlCommand(s, con);
                        cmd.CommandType = CommandType.Text;
                        i = cmd.ExecuteNonQuery();
                        con.Close();
                        tableRefresh();
                    }
                    else
                    {
                        MessageBox.Show("Admin Deletion is not  Permitted");
                    }
                }
                else
                {
                    MessageBox.Show("Select Row to delete!");
                }
            }
            */
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox6.Text == "")
            {
                MessageBox.Show("Empty values are not permitted");
                return;
            }
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\suman\Documents\Login.mdf;Integrated Security=True;Connect Timeout=30");
            SqlCommand cmd;
            con.Open();
            string s = "UPDATE [Table] SET NAME=@p1,LOCATION=@p3,DESIGNATION=@p4,EMAIL=@p5 where EMPCODE=@p2";
            cmd = new SqlCommand(s, con);
            cmd.Parameters.AddWithValue("@p2", textBox1.Text);
            cmd.Parameters.AddWithValue("@p1", textBox2.Text);
            cmd.Parameters.AddWithValue("@p4", textBox3.Text);
            cmd.Parameters.AddWithValue("@p3", textBox4.Text);
            cmd.Parameters.AddWithValue("@p5", textBox5.Text);
            cmd.CommandType = CommandType.Text;
            try
            {
                int i = cmd.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Not satisfying database constraints");
            }
            con.Close();
            tableRefresh();
            foreach (Control c in Controls)
                if (c is TextBox)
                {
                    c.Text = "";
                }
            
        }

        private void Button3_Click_1(object sender, EventArgs e)
        {
            tableRefresh();
        }

        private void Label7_Click(object sender, EventArgs e)
        {

        }

        private void DataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {
            //i
                //EMPCODE,NAME,DESIGNATION,LOCATION,EMAIL
                  DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                textBox1.Text = row.Cells[0].Value.ToString();
                textBox2.Text = row.Cells[1].Value.ToString();
                textBox3.Text = row.Cells[2].Value.ToString();
                textBox4.Text = row.Cells[3].Value.ToString();
                textBox6.Text = row.Cells[4].Value.ToString();

            
        }
    }
}
