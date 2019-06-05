namespace WindowsFormsApp2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.EMPCODE_BOX = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PASSWORD_BOX = new System.Windows.Forms.TextBox();
            this.ADDRESS_BOX = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.PASSWORDAGAIN_BOX = new System.Windows.Forms.TextBox();
            this.BLOODGROUP_BOX = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label12 = new System.Windows.Forms.Label();
            this.APPLICATION_BOX = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GENDER_BOX = new System.Windows.Forms.DomainUpDown();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // EMPCODE_BOX
            // 
            this.EMPCODE_BOX.Location = new System.Drawing.Point(929, 139);
            this.EMPCODE_BOX.Name = "EMPCODE_BOX";
            this.EMPCODE_BOX.Size = new System.Drawing.Size(211, 22);
            this.EMPCODE_BOX.TabIndex = 1;
            this.EMPCODE_BOX.TextChanged += new System.EventHandler(this.empCode_textbox);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(473, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(265, 38);
            this.label3.TabIndex = 33;
            this.label3.Text = "SIGN UP PAGE";
            this.label3.Click += new System.EventHandler(this.Label3_Click_1);
            // 
            // PASSWORD_BOX
            // 
            this.PASSWORD_BOX.Location = new System.Drawing.Point(929, 256);
            this.PASSWORD_BOX.Name = "PASSWORD_BOX";
            this.PASSWORD_BOX.Size = new System.Drawing.Size(211, 22);
            this.PASSWORD_BOX.TabIndex = 8;
            this.PASSWORD_BOX.TextChanged += new System.EventHandler(this.password_textbox);
            // 
            // ADDRESS_BOX
            // 
            this.ADDRESS_BOX.Location = new System.Drawing.Point(929, 558);
            this.ADDRESS_BOX.Name = "ADDRESS_BOX";
            this.ADDRESS_BOX.Size = new System.Drawing.Size(211, 22);
            this.ADDRESS_BOX.TabIndex = 6;
            this.ADDRESS_BOX.TextChanged += new System.EventHandler(this.address_textbox);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(696, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 17);
            this.label2.TabIndex = 42;
            this.label2.Text = "EMP_CODE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(696, 259);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 43;
            this.label4.Text = "Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(696, 328);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 17);
            this.label5.TabIndex = 44;
            this.label5.Text = "Password Again";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(696, 386);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 17);
            this.label7.TabIndex = 46;
            this.label7.Text = "Gender";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(696, 558);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 17);
            this.label13.TabIndex = 53;
            this.label13.Text = "Address";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(264, 184);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(262, 243);
            this.panel1.TabIndex = 54;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(696, 503);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 17);
            this.label9.TabIndex = 57;
            this.label9.Text = "Blood Group";
            // 
            // PASSWORDAGAIN_BOX
            // 
            this.PASSWORDAGAIN_BOX.Location = new System.Drawing.Point(929, 325);
            this.PASSWORDAGAIN_BOX.Name = "PASSWORDAGAIN_BOX";
            this.PASSWORDAGAIN_BOX.Size = new System.Drawing.Size(211, 22);
            this.PASSWORDAGAIN_BOX.TabIndex = 9;
            this.PASSWORDAGAIN_BOX.TextChanged += new System.EventHandler(this.passwordAgain_textbox);
            // 
            // BLOODGROUP_BOX
            // 
            this.BLOODGROUP_BOX.Location = new System.Drawing.Point(929, 503);
            this.BLOODGROUP_BOX.Name = "BLOODGROUP_BOX";
            this.BLOODGROUP_BOX.Size = new System.Drawing.Size(137, 22);
            this.BLOODGROUP_BOX.TabIndex = 10;
            this.BLOODGROUP_BOX.TextChanged += new System.EventHandler(this.bloodGroup_textbox);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(339, 482);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 58);
            this.button1.TabIndex = 11;
            this.button1.Text = "SUBMIT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.signUp_button);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(335, 555);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(122, 20);
            this.linkLabel1.TabIndex = 12;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "LOGIN PAGE";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.login_label);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(696, 199);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 17);
            this.label12.TabIndex = 58;
            this.label12.Text = "PHONE";
            // 
            // APPLICATION_BOX
            // 
            this.APPLICATION_BOX.Location = new System.Drawing.Point(929, 194);
            this.APPLICATION_BOX.Name = "APPLICATION_BOX";
            this.APPLICATION_BOX.Size = new System.Drawing.Size(211, 22);
            this.APPLICATION_BOX.TabIndex = 59;
            this.APPLICATION_BOX.TextChanged += new System.EventHandler(this.APPLICATION_BOX_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(696, 452);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 60;
            this.label1.Text = "BIRTHDATE";
            // 
            // GENDER_BOX
            // 
            this.GENDER_BOX.Location = new System.Drawing.Point(929, 386);
            this.GENDER_BOX.Name = "GENDER_BOX";
            this.GENDER_BOX.ReadOnly = true;
            this.GENDER_BOX.Size = new System.Drawing.Size(159, 22);
            this.GENDER_BOX.TabIndex = 82;
            this.GENDER_BOX.Text = "SELECT GENDER";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(929, 452);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(211, 22);
            this.dateTimePicker1.TabIndex = 83;
            this.dateTimePicker1.Value = new System.DateTime(2019, 6, 3, 0, 0, 0, 0);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1219, 716);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.GENDER_BOX);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.APPLICATION_BOX);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BLOODGROUP_BOX);
            this.Controls.Add(this.PASSWORDAGAIN_BOX);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ADDRESS_BOX);
            this.Controls.Add(this.PASSWORD_BOX);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.EMPCODE_BOX);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox EMPCODE_BOX;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PASSWORD_BOX;
        private System.Windows.Forms.TextBox ADDRESS_BOX;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox PASSWORDAGAIN_BOX;
        private System.Windows.Forms.TextBox BLOODGROUP_BOX;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox APPLICATION_BOX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DomainUpDown GENDER_BOX;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}

