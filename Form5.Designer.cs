namespace WindowsFormsApp2
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.EXIT = new System.Windows.Forms.Button();
            this.empcode = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(300, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(230, 38);
            this.label3.TabIndex = 34;
            this.label3.Text = "LOGIN PAGE";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(41, 95);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(262, 243);
            this.panel1.TabIndex = 55;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(612, 370);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(96, 17);
            this.linkLabel1.TabIndex = 61;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "SignUp PAGE";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SIGNUP_LABEL);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(461, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 60;
            this.label4.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(461, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 17);
            this.label2.TabIndex = 59;
            this.label2.Text = "EMP_CODE";
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(602, 201);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(137, 22);
            this.password.TabIndex = 58;
            this.password.TextChanged += new System.EventHandler(this.PASSWORD_BOX);
            // 
            // EXIT
            // 
            this.EXIT.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EXIT.Location = new System.Drawing.Point(501, 287);
            this.EXIT.Name = "EXIT";
            this.EXIT.Size = new System.Drawing.Size(167, 67);
            this.EXIT.TabIndex = 57;
            this.EXIT.Text = "LOGIN";
            this.EXIT.UseVisualStyleBackColor = true;
            this.EXIT.Click += new System.EventHandler(this.LOGIN_BUTTON);
            // 
            // empcode
            // 
            this.empcode.Location = new System.Drawing.Point(602, 118);
            this.empcode.Name = "empcode";
            this.empcode.Size = new System.Drawing.Size(137, 22);
            this.empcode.TabIndex = 56;
            this.empcode.TextChanged += new System.EventHandler(this.EMPCODE_BOX);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 447);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.password);
            this.Controls.Add(this.EXIT);
            this.Controls.Add(this.empcode);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Name = "Form5";
            this.Text = "Form5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Button EXIT;
        private System.Windows.Forms.TextBox empcode;
    }
}