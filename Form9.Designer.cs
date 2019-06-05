namespace WindowsFormsApp2
{
    partial class Form9
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox102 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox104 = new System.Windows.Forms.TextBox();
            this.textBox103 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox101 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(497, 51);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(691, 386);
            this.dataGridView1.TabIndex = 98;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(164, 412);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(142, 46);
            this.button2.TabIndex = 97;
            this.button2.Text = "ADD";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(518, 515);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(72, 25);
            this.linkLabel1.TabIndex = 96;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "BACK";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel1_LinkClicked);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(338, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(586, 39);
            this.label5.TabIndex = 95;
            this.label5.Text = "PROJECT STATUS OF TRAINEES";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(782, 454);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 46);
            this.button1.TabIndex = 99;
            this.button1.Text = "REFRESH";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 332);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 17);
            this.label1.TabIndex = 100;
            this.label1.Text = "SESSIONS COMPLETED";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 272);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 17);
            this.label3.TabIndex = 102;
            this.label3.Text = "TOOLS USED TO PROJECT";
            // 
            // textBox102
            // 
            this.textBox102.Location = new System.Drawing.Point(276, 210);
            this.textBox102.Name = "textBox102";
            this.textBox102.Size = new System.Drawing.Size(190, 22);
            this.textBox102.TabIndex = 105;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 17);
            this.label2.TabIndex = 101;
            this.label2.Text = "PROJECT TITLE";
            // 
            // textBox104
            // 
            this.textBox104.Location = new System.Drawing.Point(276, 329);
            this.textBox104.Name = "textBox104";
            this.textBox104.Size = new System.Drawing.Size(190, 22);
            this.textBox104.TabIndex = 103;
            // 
            // textBox103
            // 
            this.textBox103.Location = new System.Drawing.Point(276, 272);
            this.textBox103.Name = "textBox103";
            this.textBox103.Size = new System.Drawing.Size(190, 22);
            this.textBox103.TabIndex = 107;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(49, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 17);
            this.label6.TabIndex = 108;
            this.label6.Text = "ID";
            // 
            // textBox101
            // 
            this.textBox101.Location = new System.Drawing.Point(276, 138);
            this.textBox101.Name = "textBox101";
            this.textBox101.Size = new System.Drawing.Size(190, 22);
            this.textBox101.TabIndex = 109;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(343, 163);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 17);
            this.label7.TabIndex = 110;
            this.label7.Text = "*ID will not change";
            // 
            // Form9
            // 
            this.ClientSize = new System.Drawing.Size(1317, 584);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox101);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox103);
            this.Controls.Add(this.textBox102);
            this.Controls.Add(this.textBox104);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label5);
            this.Name = "Form9";
            this.Load += new System.EventHandler(this.Form9_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox102;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox104;
        private System.Windows.Forms.TextBox textBox103;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox101;
        private System.Windows.Forms.Label label7;
    }
}
