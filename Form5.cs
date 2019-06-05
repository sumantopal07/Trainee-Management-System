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
    public partial class Form5 : Form
    {
        public static string userCode= "";
        public Form5()
        {
            InitializeComponent();
            password.PasswordChar = '*';
        }

        private void LOGIN_BUTTON(object sender, EventArgs e)
        {
            if((empcode.Text).Length == 0 || (password.Text).Length == 0)
           {
               MessageBox.Show("empty values are not accepted  ");
                return;
           }
           SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\suman\Documents\Login.mdf;Integrated Security=True;Connect Timeout=30");
           SqlDataAdapter sda =new SqlDataAdapter("Select DESIGNATION From [Table] where EMPCODE ='" + empcode.Text + "' and PASSWORD  ='" + password.Text + "'", con);
           SqlDataAdapter sda1 = new SqlDataAdapter("Select Count(*) From [Table] where EMPCODE ='" + empcode.Text + "' and PASSWORD  ='" + password.Text + "'", con);
            DataTable dt,dt1;
            dt= new DataTable();
           sda1.Fill(dt);
                if (dt.Rows[0][0].ToString() == "0")
                {
                    MessageBox.Show("Please Check UserName and Password ");
                    return;
                }
                dt1 = new DataTable(); sda.Fill(dt1);
                if (dt1.Rows[0][0].ToString() == "ADMIN")
                {
                    userCode = empcode.Text;
                    Form2 ss = new Form2();
                    ss.Show();
                    this.Hide();
                    
                }
                else if (dt1.Rows[0][0].ToString() != null)
                {
                    this.Hide();
                    userCode = empcode.Text;
                    Form3 ss = new Form3();
                    ss.Show();
                }
            
        }

        private void EMPCODE_BOX(object sender, EventArgs e)
        {

        }

        private void PASSWORD_BOX(object sender, EventArgs e)
        {

        }

        private void SIGNUP_LABEL(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form1 x = new Form1();
            x.Show();
        }
    }
}
