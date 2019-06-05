using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
            tableRefresh();
        }
        private void tableRefresh()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\suman\Documents\Login.mdf;Integrated Security=True;Connect Timeout=30");
            SqlDataAdapter sda = new SqlDataAdapter("Select [TRAINEEWORK].ID,NAME,SESSIONS,PROJECTTITLE,TOOLSUSED From [TRAINEEWORK],[Trainee] where [TRAINEEWORK].EMPCODE='" + Form5.userCode + "' and [TRAINEEWORK].ID=[Trainee].ID", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            int n = Convert.ToInt32(dataGridView1.Rows.Count.ToString());
            for (int i = 0; i < n; i++)
            {
                dataGridView1.Rows[i].Cells[0].ReadOnly = true;
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (textBox104.Text == "" || textBox102.Text == "" || textBox103.Text == "" || textBox101.Text == "")
            {
                MessageBox.Show("Empty values are not permitted");
                return;
            }
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\suman\Documents\Login.mdf;Integrated Security=True;Connect Timeout=30");
            SqlCommand cmd;
            con.Open();
            string s = "UPDATE [TRAINEEWORK] SET SESSIONS=@p4,PROJECTTITLE=@p2,TOOLSUSED=@p3 where ID=@p1 and EMPCODE='"+Form5.userCode+"'";
            cmd = new SqlCommand(s, con);
            cmd.Parameters.AddWithValue("@p1", textBox101.Text);
            //cmd.Parameters.AddWithValue("@p2", textBox2.Text);
            cmd.Parameters.AddWithValue("@p2", textBox102.Text);
            cmd.Parameters.AddWithValue("@p3", textBox103.Text);
            cmd.Parameters.AddWithValue("@p4", textBox104.Text);
            cmd.CommandType = CommandType.Text;
            try
            {

                MessageBox.Show("Data Updated Successfully");
                int i = cmd.ExecuteNonQuery();
            }
            catch(Exception e111)
            {
                MessageBox.Show(e111.Message.ToString());
            }
            con.Close();
            tableRefresh();
            foreach (Control c in Controls)
                if (c is TextBox)
                {
                    c.Text = "";
                }
        }

        private void Form9_Load(object sender, EventArgs e)
        {

        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form6 x = new Form6();
            x.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            tableRefresh();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
            textBox101.Text = row.Cells[0].Value.ToString();
           // textBox2.Text = row.Cells[1].Value.ToString();
            textBox102.Text = row.Cells[2].Value.ToString();
            textBox103.Text = row.Cells[3].Value.ToString();
            textBox104.Text = row.Cells[4].Value.ToString();
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
