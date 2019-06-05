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
    public partial class Form8 :Form
    {
        public Form8()
        {
            InitializeComponent();
            String empcode = Form5.userCode;
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\suman\Documents\Login.mdf;Integrated Security=True;Connect Timeout=30");
            SqlDataAdapter sda = new SqlDataAdapter("Select NAME,EMPCODE,EMAIL,GENDER,DESIGNATION,LOCATION,BIRTHDATE,ADDRESS,BLOODGROUP,PHONENUMBER From [Table] where EMPCODE ='" + empcode + "'", con);
            DataTable dt;
            dt = new DataTable();
            sda.Fill(dt);

            //label1001.Text = empcode;
            label1001.Text = dt.Rows[0][0].ToString();
            label1002.Text = dt.Rows[0][1].ToString();
            label1003.Text = dt.Rows[0][2].ToString();
            label1004.Text = dt.Rows[0][3].ToString();
            label1005.Text = dt.Rows[0][4].ToString();
            label1006.Text = dt.Rows[0][5].ToString();
            label1007.Text = dt.Rows[0][6].ToString();
            label1008.Text = dt.Rows[0][7].ToString();
            label1009.Text = dt.Rows[0][8].ToString();
            label1010.Text = dt.Rows[0][9].ToString();
        }

        private void Label11_Click(object sender, EventArgs e)
        {

        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form3 x = new Form3();
            x.Show();
        }
    }
}
