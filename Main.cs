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
    
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            //textBox3.PasswordChar = '*';
          //  textBox4.PasswordChar = '*';

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            // SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\suman\Documents\Login.mdf;Integrated Security=True;Connect Timeout=30");
          /*  if (string.Compare(textBox3.Text, textBox4.Text) == 0 && (textBox4.Text).Length >= 5)
            {
                //int flag = 0;
                bool exists = false;
                using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\suman\Documents\Login.mdf;Integrated Security=True;Connect Timeout=30"))
                {
                    con.Open();



                    // create a command to check if the username exists
                    using (SqlCommand cmd = new SqlCommand("select count(*) from [Table] where USERNAME = @USERNAME", con))
                    {
                        cmd.Parameters.AddWithValue("USERNAME", textBox5.Text);
                        exists = (int)cmd.ExecuteScalar() > 0;
                    }
                    con.Close();
                }
                if (exists)
                    MessageBox.Show("This UserName already exists ");
                else
                {
                    using (SqlConnection sc = new SqlConnection())
                    {
                        sc.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\suman\Documents\Login.mdf;Integrated Security=True;Connect Timeout=30";
                        sc.Open();

                        using (SqlCommand com = sc.CreateCommand())
                        {
                            com.CommandText =
                              @"insert into [Table](USERNAME,PASSWORD,NAME,DESIGNATION )values('" + textBox5.Text + "','" + textBox3.Text + "','" + textBox1.Text + "','" + textBox2.Text + "')";
                            com.ExecuteNonQuery();
                        }
                    }
                }
            }
            else if (string.Compare(textBox3.Text, textBox4.Text) != 0)
            {
                MessageBox.Show("Please Enter Password again");
                return;
            }
            else if ((textBox4.Text).Length < 5)
            {
                MessageBox.Show("Password Too Short");
                return;
            }
            MessageBox.Show("Successfullu signed in");
            this.Hide();
            Form1 x = new Form1();
            x.Show();*/

        }

        private void Button2_Click(object sender, EventArgs e)
        {
          //  this.Hide();
          //  Form1 ss = new Form1();
           // ss.Show();
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void EXIT_Click(object sender, EventArgs e)
        {

        }

        private void Main_Load(object sender, EventArgs e)
        {

        }
    }
}


