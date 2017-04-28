namespace EntityGenerator
{
    partial class main_frm
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
            this.DataSource_lbl = new System.Windows.Forms.Label();
            this.dataSource_cmb = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.testConn_btn = new System.Windows.Forms.Button();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.confirm_btn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.database_cmb = new System.Windows.Forms.ComboBox();
            this.loadTxt = new System.Windows.Forms.Label();
            this.userName_txt = new System.Windows.Forms.TextBox();
            this.password_txt = new System.Windows.Forms.TextBox();
            this.server_txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // DataSource_lbl
            // 
            this.DataSource_lbl.AutoSize = true;
            this.DataSource_lbl.Location = new System.Drawing.Point(30, 15);
            this.DataSource_lbl.Name = "DataSource_lbl";
            this.DataSource_lbl.Size = new System.Drawing.Size(47, 12);
            this.DataSource_lbl.TabIndex = 0;
            this.DataSource_lbl.Text = "数据源:";
            // 
            // dataSource_cmb
            // 
            this.dataSource_cmb.FormattingEnabled = true;
            this.dataSource_cmb.Items.AddRange(new object[] {
            "mysql",
            "mssql"});
            this.dataSource_cmb.Location = new System.Drawing.Point(118, 12);
            this.dataSource_cmb.Name = "dataSource_cmb";
            this.dataSource_cmb.Size = new System.Drawing.Size(168, 20);
            this.dataSource_cmb.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "服务器名：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "数据库：";
            // 
            // testConn_btn
            // 
            this.testConn_btn.Location = new System.Drawing.Point(12, 201);
            this.testConn_btn.Name = "testConn_btn";
            this.testConn_btn.Size = new System.Drawing.Size(75, 37);
            this.testConn_btn.TabIndex = 5;
            this.testConn_btn.Text = "测试连接";
            this.testConn_btn.UseVisualStyleBackColor = true;
            this.testConn_btn.Click += new System.EventHandler(this.testConn_btn_Click);
            // 
            // cancel_btn
            // 
            this.cancel_btn.Location = new System.Drawing.Point(258, 199);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(75, 37);
            this.cancel_btn.TabIndex = 7;
            this.cancel_btn.Text = "取消";
            this.cancel_btn.UseVisualStyleBackColor = true;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // confirm_btn
            // 
            this.confirm_btn.Location = new System.Drawing.Point(150, 199);
            this.confirm_btn.Name = "confirm_btn";
            this.confirm_btn.Size = new System.Drawing.Size(75, 37);
            this.confirm_btn.TabIndex = 6;
            this.confirm_btn.Text = "确定";
            this.confirm_btn.UseVisualStyleBackColor = true;
            this.confirm_btn.Click += new System.EventHandler(this.confirm_btn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.database_cmb);
            this.groupBox1.Controls.Add(this.loadTxt);
            this.groupBox1.Controls.Add(this.userName_txt);
            this.groupBox1.Controls.Add(this.password_txt);
            this.groupBox1.Controls.Add(this.server_txt);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.testConn_btn);
            this.groupBox1.Controls.Add(this.confirm_btn);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cancel_btn);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(345, 248);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "连接到数据库";
            // 
            // database_cmb
            // 
            this.database_cmb.FormattingEnabled = true;
            this.database_cmb.Location = new System.Drawing.Point(116, 149);
            this.database_cmb.Name = "database_cmb";
            this.database_cmb.Size = new System.Drawing.Size(170, 20);
            this.database_cmb.TabIndex = 12;
            // 
            // loadTxt
            // 
            this.loadTxt.AutoSize = true;
            this.loadTxt.Location = new System.Drawing.Point(130, 180);
            this.loadTxt.Name = "loadTxt";
            this.loadTxt.Size = new System.Drawing.Size(0, 12);
            this.loadTxt.TabIndex = 11;
            // 
            // userName_txt
            // 
            this.userName_txt.Location = new System.Drawing.Point(116, 65);
            this.userName_txt.Name = "userName_txt";
            this.userName_txt.Size = new System.Drawing.Size(170, 21);
            this.userName_txt.TabIndex = 2;
            this.userName_txt.Text = "sa";
            // 
            // password_txt
            // 
            this.password_txt.Location = new System.Drawing.Point(116, 106);
            this.password_txt.Name = "password_txt";
            this.password_txt.PasswordChar = '*';
            this.password_txt.Size = new System.Drawing.Size(170, 21);
            this.password_txt.TabIndex = 3;
            this.password_txt.Text = "123456";
            this.password_txt.LostFocus += new System.EventHandler(this.GetDatabases);
            // 
            // server_txt
            // 
            this.server_txt.Location = new System.Drawing.Point(116, 24);
            this.server_txt.Name = "server_txt";
            this.server_txt.Size = new System.Drawing.Size(170, 21);
            this.server_txt.TabIndex = 1;
            this.server_txt.LostFocus += new System.EventHandler(this.GetDatabases);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 10;
            this.label4.Text = "密码：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "用户名：";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.DataSource_lbl);
            this.panel1.Controls.Add(this.dataSource_cmb);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(345, 51);
            this.panel1.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 51);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(345, 248);
            this.panel2.TabIndex = 11;
            // 
            // main_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 299);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "main_frm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "数据库连接";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label DataSource_lbl;
        private System.Windows.Forms.ComboBox dataSource_cmb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button testConn_btn;
        private System.Windows.Forms.Button cancel_btn;
        private System.Windows.Forms.Button confirm_btn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox userName_txt;
        private System.Windows.Forms.TextBox password_txt;
        private System.Windows.Forms.TextBox server_txt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label loadTxt;
        private System.Windows.Forms.ComboBox database_cmb;
    }
}