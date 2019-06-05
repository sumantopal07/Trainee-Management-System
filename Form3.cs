using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\suman\Documents\Login.mdf;Integrated Security=True;Connect Timeout=30");
            SqlDataAdapter sda = new SqlDataAdapter("Select SKILLS from [Trainee] where EMPCODE ='" + Form5.userCode + "'", con);
            DataTable dt;
            dt = new DataTable();
            sda.Fill(dt);
            Dictionary<string, int> d = new Dictionary<string, int>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string skill = "";
                skill = (string)(dt.Rows[i][0]);
                string[] skillsList = skill.Split(',');
                foreach (string word in skillsList)
                {
                    if (d.ContainsKey(word.ToLower()))
                    {
                        d[word.ToLower()] = d[word.ToLower()] + 1;
                    }
                    else
                    {
                        d.Add(word.ToLower(), 1);
                    }
                }
            }
            chart1.Series["Series1"].IsValueShownAsLabel = true; 
            foreach (var key in d.Keys)
            {
                chart1.Series["Series1"].Points.AddXY(key, d[key]);
            }
            sda = new SqlDataAdapter("Select COUNT(ID) from [Trainee] where EMPCODE ='" + Form5.userCode + "'", con);
            //ataTable dt;
            dt = new DataTable();
            sda.Fill(dt);
            label4.Text = dt.Rows[0][0].ToString();
            dt = new DataTable();
            sda = new SqlDataAdapter("Select PROJECTTITLE from [TRAINEEWORK] where EMPCODE ='" + Form5.userCode + "'", con);
            sda.Fill(dt);
            d = new Dictionary<string, int>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string skill = "";
                skill = dt.Rows[i][0].ToString();
                string[] skillsList = skill.Split(',');
                foreach (string word in skillsList)
                {
                    if (d.ContainsKey(word.ToLower()))
                    {
                        d[word.ToLower()] = d[word.ToLower()] + 1;
                    }
                    else
                    {
                        d.Add(word.ToLower(), 1);
                    }
                }
            }
            chart2.Series["Series1"].IsValueShownAsLabel = true; ;
            foreach (var key in d.Keys)
            {
                chart2.Series["Series1"].Points.AddXY(key, d[key]);
            }
            if (label4.Text == "0")
                button4.Visible = false;
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void Label10_Click(object sender, EventArgs e)
        {

        }

        private void Label9_Click(object sender, EventArgs e)
        {

        }

        private void Button5_Click(object sender, EventArgs e)
        {

        }

        private void Label15_Click(object sender, EventArgs e)
        {

        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form5 x = new Form5();
            x.Show();
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            //dataGridView1.Visible = true;

            /*SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\suman\Documents\Login.mdf;Integrated Security=True;Connect Timeout=30");
            SqlDataAdapter sda = new SqlDataAdapter("Select ID,DATE,INTIME,EXITTIME,STATUS From [Attendance] WHERE EMPCODE='"+Form5.userCode+"'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            //dataGridView1.DataSource = dt;
            button1.Visible = true;*/
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form8 x = new Form8();
            x.Show();
        }

        private void Button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form7 x = new Form7();
            x.Show();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 x = new Form6();
            x.Show();
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }
    }
}
