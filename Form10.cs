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
    public partial class Form10 : Form
    {
        private DateTime date1;
        public Form10()
        {
            InitializeComponent();
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000 * 300;
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
            date1 = DateTime.Now;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            DateTime date2 = DateTime.Now;
            TimeSpan difference = date2.Subtract(date1);
            //int diff = Int32.Parse(duration.ToString("ss tt"));
            if (difference.TotalSeconds < 300)
            {
                if (textBox1.Text == Form1.randomNumber)
                {
                    //MessageBox.Show("login successfully");
                    SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\suman\Documents\Login.mdf;Integrated Security=True;Connect Timeout=30");
                    SqlCommand cmd;
                    con.Open();
                    string s = "UPDATE [Table] SET ADDRESS =@p3 , GENDER = @p4,PASSWORD = @p8, BLOODGROUP = @p9, BIRTHDATE = @p11,PHONENUMBER=@p12  WHERE EMPCODE = '" + Form1.W_EMP + "'";
                    cmd = new SqlCommand(s, con);
                    cmd.Parameters.AddWithValue("@p3", Form1.W_ADDRESS);
                    cmd.Parameters.AddWithValue("@p4", Form1.W_GENDER);
                    cmd.Parameters.AddWithValue("@p8", Form1.W_PASSWORD);
                    cmd.Parameters.AddWithValue("@p9", Form1.W_BG);
                    //cmd.Parameters.AddWithValue("@p10", Form1.W_EMAIL);
                    cmd.Parameters.AddWithValue("@p11", Form1.W_DATE);
                    cmd.Parameters.AddWithValue("@p12", Form1.W_PHONE);
                    cmd.CommandType = CommandType.Text;
                    int i = cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("login successfully");
                    this.Hide();
                    Form5 x = new Form5();
                    x.Show();
                    return;
                }
                else
                {
                    MessageBox.Show("Not Matching");
                    textBox1.Text = "";
                    return;
                }
            }
            else
            {
                MessageBox.Show("Session Timeout");
                this.Hide();
                Form5 x = new Form5();
                x.Show();
                return;
            }
            
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form1 x = new Form1();
            x.Show();
            //MessageBox.Show("Session Timeout");
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            
        }
        void timer_Tick(object sender, EventArgs e)
        {
            
            MessageBox.Show("Session Timeout");
            this.Close();
            //Form1 x = new Form1();
            //x.Show();
        }
    }
}
