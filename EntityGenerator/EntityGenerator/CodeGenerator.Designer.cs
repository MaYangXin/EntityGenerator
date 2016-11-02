namespace EntityGenerator
{
    partial class codeGenerator_frm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(codeGenerator_frm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.table_tvw = new System.Windows.Forms.TreeView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.generator_btn = new System.Windows.Forms.Button();
            this.cSharp_format_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cSharp_modifier_txt = new System.Windows.Forms.TextBox();
            this.cSharp_namespace_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.java_Page = new System.Windows.Forms.TabControl();
            this.cSharp_page = new System.Windows.Forms.TabPage();
            this.cSharp_content_rtx = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.java_namespace_txt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.java_modifier_txt = new System.Windows.Forms.TextBox();
            this.java_format_txt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.preview_btn = new System.Windows.Forms.Button();
            this.java_content_rtx = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.java_Page.SuspendLayout();
            this.cSharp_page.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.table_tvw);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(141, 614);
            this.panel1.TabIndex = 0;
            // 
            // table_tvw
            // 
            this.table_tvw.CheckBoxes = true;
            this.table_tvw.Dock = System.Windows.Forms.DockStyle.Fill;
            this.table_tvw.Location = new System.Drawing.Point(0, 0);
            this.table_tvw.Name = "table_tvw";
            this.table_tvw.Size = new System.Drawing.Size(141, 614);
            this.table_tvw.TabIndex = 2;
            this.table_tvw.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.table_tvw_AfterCheck);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.preview_btn);
            this.panel2.Controls.Add(this.generator_btn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(141, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(445, 98);
            this.panel2.TabIndex = 1;
            // 
            // generator_btn
            // 
            this.generator_btn.Location = new System.Drawing.Point(241, 34);
            this.generator_btn.Name = "generator_btn";
            this.generator_btn.Size = new System.Drawing.Size(90, 39);
            this.generator_btn.TabIndex = 8;
            this.generator_btn.Text = "生成代码";
            this.generator_btn.UseVisualStyleBackColor = true;
            this.generator_btn.Click += new System.EventHandler(this.generator_btn_Click);
            // 
            // cSharp_format_txt
            // 
            this.cSharp_format_txt.Location = new System.Drawing.Point(105, 68);
            this.cSharp_format_txt.Name = "cSharp_format_txt";
            this.cSharp_format_txt.Size = new System.Drawing.Size(184, 21);
            this.cSharp_format_txt.TabIndex = 5;
            this.cSharp_format_txt.Text = ".cs";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "文件格式：";
            // 
            // cSharp_modifier_txt
            // 
            this.cSharp_modifier_txt.Location = new System.Drawing.Point(105, 41);
            this.cSharp_modifier_txt.Name = "cSharp_modifier_txt";
            this.cSharp_modifier_txt.Size = new System.Drawing.Size(184, 21);
            this.cSharp_modifier_txt.TabIndex = 3;
            this.cSharp_modifier_txt.Text = "Public";
            // 
            // cSharp_namespace_txt
            // 
            this.cSharp_namespace_txt.Location = new System.Drawing.Point(105, 14);
            this.cSharp_namespace_txt.Name = "cSharp_namespace_txt";
            this.cSharp_namespace_txt.Size = new System.Drawing.Size(184, 21);
            this.cSharp_namespace_txt.TabIndex = 2;
            this.cSharp_namespace_txt.Text = "EntityGenerator.Models";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "命名空间：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "类访问修饰符：";
            // 
            // java_Page
            // 
            this.java_Page.Controls.Add(this.cSharp_page);
            this.java_Page.Controls.Add(this.tabPage2);
            this.java_Page.Controls.Add(this.tabPage3);
            this.java_Page.Dock = System.Windows.Forms.DockStyle.Fill;
            this.java_Page.Location = new System.Drawing.Point(141, 98);
            this.java_Page.Name = "java_Page";
            this.java_Page.SelectedIndex = 0;
            this.java_Page.Size = new System.Drawing.Size(445, 516);
            this.java_Page.TabIndex = 2;
            // 
            // cSharp_page
            // 
            this.cSharp_page.Controls.Add(this.cSharp_content_rtx);
            this.cSharp_page.Controls.Add(this.groupBox1);
            this.cSharp_page.Location = new System.Drawing.Point(4, 22);
            this.cSharp_page.Name = "cSharp_page";
            this.cSharp_page.Padding = new System.Windows.Forms.Padding(3);
            this.cSharp_page.Size = new System.Drawing.Size(437, 490);
            this.cSharp_page.TabIndex = 0;
            this.cSharp_page.Text = "c#";
            this.cSharp_page.UseVisualStyleBackColor = true;
            // 
            // cSharp_content_rtx
            // 
            this.cSharp_content_rtx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cSharp_content_rtx.Location = new System.Drawing.Point(3, 103);
            this.cSharp_content_rtx.Name = "cSharp_content_rtx";
            this.cSharp_content_rtx.Size = new System.Drawing.Size(431, 384);
            this.cSharp_content_rtx.TabIndex = 1;
            this.cSharp_content_rtx.Text = resources.GetString("cSharp_content_rtx.Text");
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cSharp_namespace_txt);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cSharp_modifier_txt);
            this.groupBox1.Controls.Add(this.cSharp_format_txt);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(431, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "可选项";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.java_content_rtx);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(437, 490);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "java";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.java_namespace_txt);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.java_modifier_txt);
            this.groupBox2.Controls.Add(this.java_format_txt);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(431, 100);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "可选项";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 7;
            this.label5.Text = "命名空间：";
            // 
            // java_namespace_txt
            // 
            this.java_namespace_txt.Location = new System.Drawing.Point(107, 13);
            this.java_namespace_txt.Name = "java_namespace_txt";
            this.java_namespace_txt.Size = new System.Drawing.Size(184, 21);
            this.java_namespace_txt.TabIndex = 8;
            this.java_namespace_txt.Text = "EntityGenerator.Models";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 12);
            this.label6.TabIndex = 6;
            this.label6.Text = "类访问修饰符：";
            // 
            // java_modifier_txt
            // 
            this.java_modifier_txt.Location = new System.Drawing.Point(107, 40);
            this.java_modifier_txt.Name = "java_modifier_txt";
            this.java_modifier_txt.Size = new System.Drawing.Size(184, 21);
            this.java_modifier_txt.TabIndex = 9;
            this.java_modifier_txt.Text = "Public";
            // 
            // java_format_txt
            // 
            this.java_format_txt.Location = new System.Drawing.Point(107, 67);
            this.java_format_txt.Name = "java_format_txt";
            this.java_format_txt.Size = new System.Drawing.Size(184, 21);
            this.java_format_txt.TabIndex = 11;
            this.java_format_txt.Text = ".cs";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 10;
            this.label7.Text = "文件格式";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(437, 490);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "自定义";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(6, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(706, 100);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "参数介绍";
            // 
            // preview_btn
            // 
            this.preview_btn.Location = new System.Drawing.Point(81, 34);
            this.preview_btn.Name = "preview_btn";
            this.preview_btn.Size = new System.Drawing.Size(98, 39);
            this.preview_btn.TabIndex = 9;
            this.preview_btn.Text = "预览";
            this.preview_btn.UseVisualStyleBackColor = true;
            this.preview_btn.Click += new System.EventHandler(this.preview_btn_Click);
            // 
            // java_content_rtx
            // 
            this.java_content_rtx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.java_content_rtx.Location = new System.Drawing.Point(3, 103);
            this.java_content_rtx.Name = "java_content_rtx";
            this.java_content_rtx.Size = new System.Drawing.Size(431, 384);
            this.java_content_rtx.TabIndex = 1;
            this.java_content_rtx.Text = "";
            // 
            // codeGenerator_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 614);
            this.Controls.Add(this.java_Page);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "codeGenerator_frm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "实体代码生成器";
            this.Load += new System.EventHandler(this.codeGenerator_frm_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.java_Page.ResumeLayout(false);
            this.cSharp_page.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button generator_btn;
        private System.Windows.Forms.TextBox cSharp_format_txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox cSharp_modifier_txt;
        private System.Windows.Forms.TextBox cSharp_namespace_txt;
        private System.Windows.Forms.TreeView table_tvw;
        private System.Windows.Forms.TabControl java_Page;
        private System.Windows.Forms.TabPage cSharp_page;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox cSharp_content_rtx;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox java_namespace_txt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox java_modifier_txt;
        private System.Windows.Forms.TextBox java_format_txt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button preview_btn;
        private System.Windows.Forms.RichTextBox java_content_rtx;
    }
}

