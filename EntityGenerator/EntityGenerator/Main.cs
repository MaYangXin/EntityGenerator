using EntityGenerator.sqlAdapter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace EntityGenerator
{
    public partial class main_frm : Form
    {
        private IsqlAdapter sqlAdapter;
        public main_frm()
        {
            InitializeComponent();
            dataSource_cmb.SelectedIndex = 0;
            var regex = new Regex(@"(?:{{yx-for}})([\w\W]*?)(?:{{yx-end}})");
            string a = @"{{yx-for}}
   var i=0;
   var j=2;
{{yx-end}}";
            var matches=regex.Matches(a);
            foreach (System.Text.RegularExpressions.Match match in matches)
            {
                var yourWant = match.Value.ToString();
            }
        }

        private void testConn_btn_Click(object sender, EventArgs e)
        {
            if(FormValidate())
            {
                MessageBox.Show(TestConnection() ? "测试成功" : "测试失败");
            }
        }

        private void confirm_btn_Click(object sender, EventArgs e)
        {
            if (FormValidate())
            {
                if (TestConnection())
                    new codeGenerator_frm(sqlAdapter).ShowDialog();
                else MessageBox.Show("数据库连接失败,请重新输入");
            }
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private bool FormValidate()
        {
            bool isValid = !(string.IsNullOrEmpty(server_txt.Text) || string.IsNullOrEmpty(userName_txt.Text) ||
              string.IsNullOrEmpty(password_txt.Text) || string.IsNullOrEmpty(databaseName_txt.Text));
            if (!isValid)
                MessageBox.Show("表单中的任意一个文本框都不能为空");
            return isValid;
        }
        private bool TestConnection()
        {
            var connInfo = new ConnInfo
            {
                server = server_txt.Text,
                userName = userName_txt.Text,
                password = password_txt.Text,
                databaseName = databaseName_txt.Text,
            };
            var isTest = false;
            switch (dataSource_cmb.Text)
            {
                case "mysql":
                    sqlAdapter=new mysqlAdapter(connInfo);
                    isTest =sqlAdapter.TestConnection(); break;
                case "mssql":
                    sqlAdapter = new mssqlAdapter(connInfo);
                    isTest = sqlAdapter.TestConnection(); break;
                default: MessageBox.Show("匹配不到适合的数据源"); break;
            }
            return isTest;
        }
    }
}
