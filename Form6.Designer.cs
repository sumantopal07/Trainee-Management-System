namespace WindowsFormsApp2
{
    partial class Form6
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
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.SKILL_BOX = new System.Windows.Forms.DomainUpDown();
            this.PROJECT_BOX = new System.Windows.Forms.DomainUpDown();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(574, 560);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(72, 25);
            this.linkLabel1.TabIndex = 81;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "BACK";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel1_LinkClicked);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(484, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(388, 39);
            this.label5.TabIndex = 80;
            this.label5.Text = "TRAINEES MANAGER";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(188, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 17);
            this.label3.TabIndex = 72;
            this.label3.Text = "SKILLS";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(241, 138);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 32);
            this.button1.TabIndex = 84;
            this.button1.Text = "SEARCH";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(99, 187);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(386, 369);
            this.dataGridView1.TabIndex = 99;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(599, 187);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(597, 271);
            this.dataGridView2.TabIndex = 103;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView2_CellContentClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(800, 138);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 32);
            this.button2.TabIndex = 102;
            this.button2.Text = "SEARCH";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(684, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 17);
            this.label1.TabIndex = 100;
            this.label1.Text = "PROJECT ALLOTED";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(800, 475);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(226, 66);
            this.button4.TabIndex = 105;
            this.button4.Text = "UPDATE PROJECT DETAILS";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // SKILL_BOX
            // 
            this.SKILL_BOX.Location = new System.Drawing.Point(286, 97);
            this.SKILL_BOX.Name = "SKILL_BOX";
            this.SKILL_BOX.Size = new System.Drawing.Size(179, 22);
            this.SKILL_BOX.TabIndex = 106;
            this.SKILL_BOX.Text = "SELECT SKILL";
            // 
            // PROJECT_BOX
            // 
            this.PROJECT_BOX.Location = new System.Drawing.Point(862, 94);
            this.PROJECT_BOX.Name = "PROJECT_BOX";
            this.PROJECT_BOX.Size = new System.Drawing.Size(179, 22);
            this.PROJECT_BOX.TabIndex = 107;
            this.PROJECT_BOX.Text = "SELECT PROJECT";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(558, 475);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(107, 32);
            this.button3.TabIndex = 108;
            this.button3.Text = "REFRESH";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click_1);
            // 
            // Form6
            // 
            this.ClientSize = new System.Drawing.Size(1242, 603);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.PROJECT_BOX);
            this.Controls.Add(this.SKILL_BOX);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Name = "Form6";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DomainUpDown SKILL_BOX;
        private System.Windows.Forms.DomainUpDown PROJECT_BOX;
        private System.Windows.Forms.Button button3;
    }
}
