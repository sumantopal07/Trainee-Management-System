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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
            tableRefresh1();
            tableRefresh2();

        }
        private void tableRefresh1()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\suman\Documents\Login.mdf;Integrated Security=True;Connect Timeout=30");
            SqlDataAdapter sda = new SqlDataAdapter("Select SKILLS,NAME from [Trainee] where EMPCODE ='" + Form5.userCode + "'", con);
            DataTable dt;
            dt = new DataTable();
            sda.Fill(dt);
            int i;
            Dictionary<string, string> d = new Dictionary<string, string>();
            for (i = 0; i < dt.Rows.Count; i++)
            {
                string word = (string)(dt.Rows[i][0]);
                if (d.ContainsKey(word.ToLower()))
                {
                    d[word.ToLower()] = d[word.ToLower()] + ","+ (string)(dt.Rows[i][1]);
                }
                else
                {
                    d.Add(word.ToLower(), (string)(dt.Rows[i][1]));
                }
            }
            dataGridView1.DataSource = d.ToArray();
            /*SqlCommand cmd;
            con.Open();
            string s = "TRUNCATE TABLE temp";
            cmd = new SqlCommand(s, con);
            i = cmd.ExecuteNonQuery();
            con.Close();
            con.Open();
            foreach (var key in d.Keys)
            {
                s = "insert into [Temp](skill,name) values(@p1,@p2)";
                cmd = new SqlCommand(s, con);
                cmd.Parameters.AddWithValue("@p1", key);
                cmd.Parameters.AddWithValue("@p2", d[key]);
                cmd.CommandType = CommandType.Text;
                i = cmd.ExecuteNonQuery();
            }
            con.Close();*/
           /* SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\suman\Documents\Login.mdf;Integrated Security=True;Connect Timeout=30");
            SqlDataAdapter sda = new SqlDataAdapter("SELECT SKILLS,NAME FROM[Trainee] where EMPCODE='" + Form5.userCode+"'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt; //SELECT SKILLS, ID, NAME FROM[Trainee] where ID = @p2 and EMPCODE = '" + Form5.userCode + "'"*/
        }
        private void tableRefresh2()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\suman\Documents\Login.mdf;Integrated Security=True;Connect Timeout=30");
            SqlDataAdapter sda = new SqlDataAdapter("Select NAME,PROJECTTITLE,SESSIONS,TOOLSUSED From [TRAINEEWORK],[Trainee] where [TRAINEEWORK].EMPCODE='" + Form5.userCode + "' AND [TRAINEEWORK].ID=[Trainee].ID", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView2.DataSource = dt;
        }
        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form7 x = new Form7();
            x.Show();
        }

        private void Button7_Click(object sender, EventArgs e)
        {
           
        }

        private void DataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Button2_Click_1(object sender, EventArgs e)
        {
            /*if (SKILL_BOX.Text == "")
            {
                MessageBox.Show("SELECT SKILL TO PERFORM SEARCH");
                return;
            }
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\suman\Documents\Login.mdf;Integrated Security=True;Connect Timeout=30");
            SqlDataAdapter sda = new SqlDataAdapter("Select SKILLS,NAME From [Trainee] WHERE EMPCODE='" + Form5.userCode + "' AND SKILLS LIKE '%" + SKILL_BOX.SelectedItem.ToString() + "%'", con);
            //selectCommand.Parameters.AddWithValue("@sport", SKILL_BOX.Text);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;*/
            //tableRefresh1();
            if (PROJECT_BOX.Text == "")
            {
                MessageBox.Show("SELECT PROJECT TO PERFORM SEARCH");
                return;
            }
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\suman\Documents\Login.mdf;Integrated Security=True;Connect Timeout=30");
            SqlDataAdapter sda = new SqlDataAdapter("Select PROJECTTITLE,NAME From [Trainee],[TRAINEEWORK] WHERE [TRAINEEWORK].ID=[Trainee].ID AND [TRAINEEWORK].EMPCODE='" + Form5.userCode + "' AND [TRAINEEWORK].PROJECTTITLE LIKE '%" + PROJECT_BOX.SelectedItem.ToString() + "%'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView2.DataSource = dt;

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form9 x = new Form9();
            x.Show();
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form3 x = new Form3();
            x.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (SKILL_BOX.Text == "")
            {
                MessageBox.Show("SELECT SKILL TO PERFORM SEARCH");
                return;
            }
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\suman\Documents\Login.mdf;Integrated Security=True;Connect Timeout=30");
            SqlDataAdapter sda = new SqlDataAdapter("Select SKILLS,NAME From [Trainee] WHERE EMPCODE='"+Form5.userCode+"' AND SKILLS LIKE '%" + SKILL_BOX.SelectedItem.ToString() + "%'", con);
            //selectCommand.Parameters.AddWithValue("@sport", SKILL_BOX.Text);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            //tableRefresh1();

        }

        private void Form6_Load(object sender, EventArgs e)
        {
            DomainUpDown.DomainUpDownItemCollection collection = this.SKILL_BOX.Items;
            Dictionary<string, int> d = new Dictionary<string, int>();
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\suman\Documents\Login.mdf;Integrated Security=True;Connect Timeout=30");
            SqlDataAdapter sda = new SqlDataAdapter("Select SKILLS from [Trainee] where EMPCODE ='" + Form5.userCode + "'", con);
            sda.Fill(dt);
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
            //chart1.Series["Series1"].IsValueShownAsLabel = true; ;
            foreach (var key in d.Keys)
            {
                collection.Add(key);
            }
            this.SKILL_BOX.Text = "SELECT SKILLS";
            DomainUpDown.DomainUpDownItemCollection xyz = this.PROJECT_BOX.Items;
             d = new Dictionary<string, int>();
             dt = new DataTable();
            //SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\suman\Documents\Login.mdf;Integrated Security=True;Connect Timeout=30");
            sda = new SqlDataAdapter("Select PROJECTTITLE from [TRAINEEWORK],[Trainee] where [TRAINEEWORK].EMPCODE ='" + Form5.userCode + "' AND [TRAINEEWORK].ID=[Trainee].ID", con);
            sda.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string word = "";
                word = (string)(dt.Rows[i][0]);
                //string[] skillsList = skill.Split(',');
               // foreach (string word in skillsList)
               // {
                if (d.ContainsKey(word.ToLower()))
                {
                    d[word.ToLower()] = d[word.ToLower()] + 1;
                }
                else
                {
                    d.Add(word.ToLower(), 1);
                }
            }
            //chart1.Series["Series1"].IsValueShownAsLabel = true; ;
            foreach (var key in d.Keys)
            {
                xyz.Add(key);
            }
            this.PROJECT_BOX.Text = "SELECT PROJECT";
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form9 x = new Form9();
            x.Show();
        }

        private void Button3_Click_1(object sender, EventArgs e)
        {
            tableRefresh1();
            tableRefresh2();
        }
    }
}
