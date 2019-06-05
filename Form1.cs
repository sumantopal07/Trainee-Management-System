using System;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Net;
using System.IO;
using static System.Windows.Forms.DomainUpDown;
using System.Net.Mail;
using System.Data;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public static string W_PASSWORD ="", W_BG="", W_GENDER="", W_ADDRESS="", W_EMAIL="", W_EMP="", W_DATE="", W_PHONE="",randomNumber="";
        
        public Form1()
        {
            InitializeComponent();
            dateTimePicker1.Value = DateTime.Now;
            PASSWORD_BOX.PasswordChar = '*';
            PASSWORDAGAIN_BOX.PasswordChar = '*';
            //textBox2.MaxLength = 100;
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            /*if((textBox2.Text).Length == 0 || (textBox1.Text).Length == 0)
            {
                MessageBox.Show("empty values are not accepted  ");
            }
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\suman\Documents\Login.mdf;Integrated Security=True;Connect Timeout=30");
            SqlDataAdapter sda =new SqlDataAdapter("Select Count(*) From [Table] where USERNAME ='" + textBox1.Text + "' and PASSWORD  ='" + textBox2.Text + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if(dt.Rows[0][0].ToString()=="1")
            {
                this.Hide();
                userName = textBox1.Text;
                Form2 ss = new Form2();
                ss.Show();
            }
            else
            {
                MessageBox.Show("Please Check UserName and Password ");
            }*/
            
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }
        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DomainUpDownItemCollection list = this.GENDER_BOX.Items;
            list.Add("M");
            list.Add("F");
            list.Add("OTHERS");

        }

        private void Label2_Click_1(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void Label8_Click(object sender, EventArgs e)
        {

        }

        private void Label13_Click(object sender, EventArgs e)
        {

        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label11_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void Name_Label(object sender, EventArgs e)
        {

        }

        private void empCode_textbox(object sender, EventArgs e)
        {

        }

        private void email_textbox(object sender, EventArgs e)
        {

        }

        private void gender_textbox(object sender, EventArgs e)
        {

        }

        private void designation_textbox(object sender, EventArgs e)
        {

        }

        private void location_textbox(object sender, EventArgs e)
        {

        }

        private void address_textbox(object sender, EventArgs e)
        {

        }

        private void name_textbox(object sender, EventArgs e)
        {

        }

        private void birthDate_textbox(object sender, EventArgs e)
        {

        }

        private void password_textbox(object sender, EventArgs e)
        {

        }

        private void passwordAgain_textbox(object sender, EventArgs e)
        {

        }

        private void bloodGroup_textbox(object sender, EventArgs e)
        {

        }

        private void signUp_Button(object sender, EventArgs e)
        {

        }

        private void login_textbox(object sender, EventArgs e)
        {

        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void EXIT_Click(object sender, EventArgs e)
        {

        }

        private void APPLICATION_BOX_TextChanged(object sender, EventArgs e)
        {

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
                if(c is DomainUpDown)
                {
                    if (GENDER_BOX.SelectedItem.ToString() != "M" && GENDER_BOX.SelectedItem.ToString() != "F"
                        && GENDER_BOX.SelectedItem.ToString() != "OTHERS")
                        return false;
                }
                if (c is DateTimePicker)
                {
                    if (dateTimePicker1.Value.ToString("dd/MM/yyyy")== DateTime.Now.ToString("dd/MM/yyyy"))
                    {
                        return false;
                    }

                }

            }
            return true;
        }
        private bool employeeValidation()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\suman\Documents\Login.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            SqlCommand check_User_Name = new SqlCommand("SELECT COUNT(*) FROM [Table] WHERE (PASSWORD IS NULL) and ([EMPCODE] = @user)", con);
            //check_User_Name.Parameters.AddWithValue("@pin", APPLICATION_BOX.Text);
            check_User_Name.Parameters.AddWithValue("@user", EMPCODE_BOX.Text);
            int UserExist = (int)check_User_Name.ExecuteScalar();
            if (UserExist <= 0)
            {
                return false;
            }
            return true;
        }
        public static bool IsNumeric(object Expression)
        {
            double retNum;

            bool isNum = Double.TryParse(Convert.ToString(Expression), System.Globalization.NumberStyles.Any, System.Globalization.NumberFormatInfo.InvariantInfo, out retNum);
            return isNum;
        }
        private void signUp_button(object sender, EventArgs e)
        {
            if(allFilled()==false)
            {
                MessageBox.Show("Fill All Details");
                return;
            }
            if(PASSWORD_BOX.Text!= PASSWORDAGAIN_BOX.Text)
            {
                MessageBox.Show("Password Not Matching");
                return;
            }
            int flag = 0;
            for(int i=0;i<10;i++)
            {
                if(APPLICATION_BOX.Text.ToString()[0]>'9' || APPLICATION_BOX.Text.ToString()[0] < '0')
                {
                    flag = 1;
                    break;
                }
            }
            if (APPLICATION_BOX.Text.ToString().Length !=10 || flag==1)
            {
                MessageBox.Show("Please enter 10 digit number without country-code or characters");
                return;
            }
            if (PASSWORD_BOX.Text.ToString().Length<=8 )
            {
                MessageBox.Show("Password should be minimum of  9 characters");
                return;
            }
            if(employeeValidation()==false)
            {
                MessageBox.Show("You are not matching employee");
                return;
           }
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\suman\Documents\Login.mdf;Integrated Security=True;Connect Timeout=30");
            SqlDataAdapter sda = new SqlDataAdapter("Select EMAIL from [Table] where EMPCODE ='" + EMPCODE_BOX.Text + "'", con);
            DataTable dt;
            dt = new DataTable();
            sda.Fill(dt);
            W_EMAIL = dt.Rows[0][0].ToString();
            /*SqlCommand cmd;
            con.Open();
            string s = "UPDATE [Table] SET ADDRESS =@p3 , GENDER = @p4,PASSWORD = @p8, BLOODGROUP = @p9, EMAIL = @p10,BIRTHDATE = @p11  WHERE EMPCODE = '"+EMPCODE_BOX.Text+"'";
            cmd = new SqlCommand(s, con);
            cmd.Parameters.AddWithValue("@p3", ADDRESS_BOX.Text);
            cmd.Parameters.AddWithValue("@p4", GENDER_BOX.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@p8", PASSWORD_BOX.Text);
            cmd.Parameters.AddWithValue("@p9", BLOODGROUP_BOX.Text);
            cmd.Parameters.AddWithValue("@p10", EMAIL_BOX.Text);
            cmd.Parameters.AddWithValue("@p11", dateTimePicker1.Value.ToString("dd/MM/yyyy"));
            cmd.CommandType = CommandType.Text;
            int i = cmd.ExecuteNonQuery();
            con.Close();*/
            W_ADDRESS = ADDRESS_BOX.Text;
            W_GENDER = GENDER_BOX.SelectedItem.ToString();
            W_BG = BLOODGROUP_BOX.Text;
            //W_EMAIL = EMAIL_BOX.Text;
            W_PASSWORD = PASSWORD_BOX.Text;
            W_DATE = dateTimePicker1.Value.ToString("dd/MM/yyyy");
            W_EMP = EMPCODE_BOX.Text;
            W_PHONE = APPLICATION_BOX.Text;
            //MessageBox.Show("Account created Successfully ");
            dateTimePicker1.Value = DateTime.Now;
            Random rnd = new Random();
            randomNumber = (rnd.Next(100000, 999999)).ToString();
            MessageBox.Show("OTP is sent to your registered email");
            Form11 xq = new Form11();

            // Display form modelessly
            xq.Show();
            this.Hide();
            //  ALlow main UI thread to properly display please wait form.
            Application.DoEvents();
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress("traineeManagement123@gmail.com");
                mail.To.Add(new MailAddress(W_EMAIL));
                mail.Subject = "OTP to setup new account";
                mail.Body = "Your OTP is "+randomNumber+". This OTP is valid for 5 minutes only.";
                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("traineeManagement123@gmail.com", "MuNnU@1999");
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
                //MessageBox.Show("mail Send");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            xq.Hide();
            //this.Hide();
            Form10 x = new Form10();
            x.Show();
        }

        private void login_label(object sender, LinkLabelLinkClickedEventArgs e)
        {
                this.Hide();
                Form5 x = new Form5();
                x.Show();
                //this.Close();
        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Label3_Click_1(object sender, EventArgs e)
        {

        }
    }
}
