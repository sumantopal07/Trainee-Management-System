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
    public partial class Form7 : Form
    {
        private static string idUpdate;
        public Form7()
        {
            InitializeComponent();
            button3.Visible = false;
            dateTimePicker2.Visible = false;
            dateTimePicker2.Value = new DateTime(2000, 01,01);
            dateTimePicker1.Value = new DateTime(2000, 01, 01);
            tableRefresh();
        }
        private void tableRefresh()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\suman\Documents\Login.mdf;Integrated Security=True;Connect Timeout=30");
            SqlDataAdapter sda = new SqlDataAdapter("Select ID,NAME,COLLEGE,SKILLS,GENDER,HOMEPLACE,YEARPASSOUT,DATEOFJOINING,PHONE From [Trainee] where EMPCODE='"+Form5.userCode+"'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            int n = Convert.ToInt32(dataGridView1.Rows.Count.ToString());
            for (int i = 0; i < n; i++)
            {
                dataGridView1.Rows[i].Cells[0].ReadOnly = true;
            }
        }
        private bool allFilled()
        {
            foreach (Control c in Controls)
            {
                if (c is TextBox)
                {
                    //MessageBox.Show();
                    if (c.Text.ToString().Length == 0)
                        return false;
                }
                if (c is DomainUpDown)
                {
                    if (GENDER_BOX.SelectedItem.ToString() != "M" && GENDER_BOX.SelectedItem.ToString() != "F"
                        && GENDER_BOX.SelectedItem.ToString() != "OTHERS")
                        return false;
                }
                if (c is DateTimePicker)
                {
                    if (dateTimePicker1.Value.ToString("dd/MM/yyyy") == dateTimePicker2.Value.ToString("dd/MM/yyyy")) //DateTime.Today.AddYears(-100)
                    {
                        return false;
                    }

                }

            }
            return true;
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            button3.Visible = false;
            if (allFilled() == false)
            {
                MessageBox.Show("Fill All Details");
                return;
            }
            int Flag = 0;
            for(int j=0;j< PHONE_BOX.Text.Length;j++)
            {
                if (PHONE_BOX.Text[j] > '9' || PHONE_BOX.Text[j] < '0')
                {
                    Flag = 1;
                    break;
                }
            }
            if(PHONE_BOX.Text.Length!=10 || Flag==1)
            {
                MessageBox.Show("phone must be exactly 10 digits");
                return;
            }
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\suman\Documents\Login.mdf;Integrated Security=True;Connect Timeout=30");
                SqlDataAdapter sda = new SqlDataAdapter("Select COUNT(ID) from [Trainee]", con);
                DataTable dt;
                dt = new DataTable();
                sda.Fill(dt);
                string w   = dt.Rows[0][0].ToString();
                if (w == "0")
                    w = "1";
                else
                {
                    sda = new SqlDataAdapter("Select MAX(ID) from [Trainee] ", con);
                    //DataTable dt;
                    dt = new DataTable();
                    sda.Fill(dt);
                    w = dt.Rows[0][0].ToString();
                    int x = Int32.Parse(w);
                    x += 1;
                    w = x + "";
                }
                SqlCommand cmd;
                con.Open();
                string s = "INSERT INTO [Trainee](ID,NAME,COLLEGE,PHONE,GENDER,SKILLS,HOMEPLACE,YEARPASSOUT,DATEOFJOINING,EMPCODE) VALUES(@p9,@p0,@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)";
                cmd = new SqlCommand(s, con);
                //int k = 0; string x1 = "";
                cmd.Parameters.AddWithValue("@p0", NAME_BOX.Text);
                cmd.Parameters.AddWithValue("@p1", COLLEGE_BOX.Text);
                cmd.Parameters.AddWithValue("@p2", PHONE_BOX.Text);
                cmd.Parameters.AddWithValue("@p3", GENDER_BOX.Text);
                cmd.Parameters.AddWithValue("@p4", SKILL_BOX.Text);
                cmd.Parameters.AddWithValue("@p5", HOMEPLACE_BOX.Text);
                cmd.Parameters.AddWithValue("@p6", YEAR_BOX.Text);
                cmd.Parameters.AddWithValue("@p7", dateTimePicker1.Text);
                cmd.Parameters.AddWithValue("@p8", Form5.userCode);
                cmd.Parameters.AddWithValue("@p9", w);
                cmd.CommandType = CommandType.Text;
                int i = cmd.ExecuteNonQuery();
                s = "INSERT INTO [TRAINEEWORK](ID,SESSIONS,EMPCODE) VALUES(@p0,@p1,@p2)";
                cmd = new SqlCommand(s, con);
                //int k = 0; string x1 = "";
                cmd.Parameters.AddWithValue("@p0",w);
                cmd.Parameters.AddWithValue("@p1","0");
                cmd.Parameters.AddWithValue("@p2", Form5.userCode);
                cmd.CommandType = CommandType.Text;
                i = cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Trainee details added Successfully ");
                tableRefresh();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

        }

        private void GENDER_BOX_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void NAME_BOX_TextChanged(object sender, EventArgs e)
        {

        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form3 x = new Form3();
            x.Show();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            button3.Visible = false;
            int selectedrowindex, i;
            DataGridViewRow selectedRow;
            string  x;
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                if (dataGridView1.SelectedCells.Count > 0)
                {
                    MessageBox.Show("Deleted Successfully");
                    selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;

                    selectedRow = dataGridView1.Rows[selectedrowindex];
                    
                    //a = Convert.ToString(selectedRow.Cells["DESIGNATION"].Value);
                    x = Convert.ToString(selectedRow.Cells["ID"].Value);
                    //if (a != "ADMIN")
                    //{
                        dataGridView1.Rows.RemoveAt(row.Index);
                        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\suman\Documents\Login.mdf;Integrated Security=True;Connect Timeout=30");
                        SqlCommand cmd;
                        con.Open();
                        string s = "delete from [Trainee] where ID='" + x + "'";
                        cmd = new SqlCommand(s, con);
                        cmd.CommandType = CommandType.Text;
                        i = cmd.ExecuteNonQuery();
                        con.Close();
                        tableRefresh();
                }
                else
                {
                    MessageBox.Show("Select Row to delete!");
                }
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
           
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            button3.Visible = false;
            tableRefresh();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            button3.Visible = true;
            DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
            NAME_BOX.Text = row.Cells[1].Value.ToString();
            COLLEGE_BOX.Text = row.Cells[2].Value.ToString();
            PHONE_BOX.Text = row.Cells[8].Value.ToString();
            GENDER_BOX.Text = row.Cells[4].Value.ToString();
            SKILL_BOX.Text = row.Cells[3].Value.ToString();
            HOMEPLACE_BOX.Text = row.Cells[5].Value.ToString();
            YEAR_BOX.Text = row.Cells[6].Value.ToString();
            dateTimePicker1.Text = row.Cells[7].Value.ToString();
            idUpdate = row.Cells[0].Value.ToString();
        }

        private void Button3_Click_1(object sender, EventArgs e)
        {
            if (allFilled() == false)
            {
                MessageBox.Show("Fill All Details");
                return;
            }
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\suman\Documents\Login.mdf;Integrated Security=True;Connect Timeout=30");
            SqlCommand cmd;
            con.Open();
            string s = "UPDATE [Trainee] SET NAME=@p1,COLLEGE=@p2,PHONE=@p3,GENDER=@p4,SKILLS=@p5,HOMEPLACE=@p6,YEARPASSOUT=@p7,DATEOFJOINING=@p8 where ID=@p0 and EMPCODE='" + Form5.userCode + "'";
            cmd = new SqlCommand(s, con);
            cmd.Parameters.AddWithValue("@p1", NAME_BOX.Text);
            cmd.Parameters.AddWithValue("@p2", COLLEGE_BOX.Text);
            cmd.Parameters.AddWithValue("@p3", PHONE_BOX.Text);
            cmd.Parameters.AddWithValue("@p4", GENDER_BOX.Text);
            cmd.Parameters.AddWithValue("@p5", SKILL_BOX.Text);
            cmd.Parameters.AddWithValue("@p6", HOMEPLACE_BOX.Text);
            cmd.Parameters.AddWithValue("@p7", YEAR_BOX.Text);
            cmd.Parameters.AddWithValue("@p8", dateTimePicker1.Text);
            cmd.Parameters.AddWithValue("@p0", idUpdate);
            cmd.CommandType = CommandType.Text;
            try
            {

                MessageBox.Show("Data Updated Successfully");
                int i = cmd.ExecuteNonQuery();
            }
            catch (Exception e111)
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
    }
}
