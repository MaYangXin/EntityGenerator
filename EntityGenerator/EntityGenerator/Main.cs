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
using System.Threading;

namespace EntityGenerator
{
    public partial class main_frm : Form
    {
        private event Action<bool> connectionEvent;
        public main_frm()
        {
            InitializeComponent();
            dataSource_cmb.DropDownStyle = ComboBoxStyle.DropDownList;
            database_cmb.DropDownStyle = ComboBoxStyle.DropDownList;
            dataSource_cmb.SelectedIndex = 1;
            var regex = new Regex(@"(?:{{yx-for}})([\w\W]*?)(?:{{yx-end}})");
            string a = @"{{yx-for}}
   var i=0;
   var j=2;
{{yx-end}}";
            var matches = regex.Matches(a);
            foreach (System.Text.RegularExpressions.Match match in matches)
            {
                var yourWant = match.Value.ToString();
            }
        }

        private void testConn_btn_Click(object sender, EventArgs e)
        {
            connectionEvent = new Action<bool>((IsConn) => { MessageBox.Show(IsConn ? "测试成功" : "测试失败");});
            TestConnection();
        }

        private void confirm_btn_Click(object sender, EventArgs e)
        {
            TestConnection();
            //if (TestConnection())
            //{
            //    if (string.IsNullOrEmpty(database_cmb.SelectedText))
            //    {
            //        MessageBox.Show("请选择一个数据库");
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("数据库连接失败,请重新输入");
            //}
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void TestConnection()
        {
            var isTest = false;
            IsqlAdapter sqlAdapter=SetSqlAdapter();
            new Action(() =>
            {
                isTest=sqlAdapter.TestConnection();
                if (connectionEvent != null)
                    connectionEvent(isTest);
            }).BeginInvoke(null,null);
        }
        private IsqlAdapter SetSqlAdapter()
        {
            IsqlAdapter sqlAdapter = null;
            var connInfo = new ConnInfo
            {
                server = server_txt.Text,
                userName = userName_txt.Text,
                password = password_txt.Text,
                databaseName = database_cmb.SelectedText,
            };
            switch (dataSource_cmb.Text)
            {
                case "mysql":
                    sqlAdapter = new mysqlAdapter(connInfo);break;
                case "mssql":
                    sqlAdapter = new mssqlAdapter(connInfo);break;
                default: MessageBox.Show("匹配不到适合的数据源"); break;
            }
            return sqlAdapter;
        }
        private void GetDatabases(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(userName_txt.Text) && !string.IsNullOrEmpty(dataSource_cmb.Text))
            {
                var sqlAdapter = SetSqlAdapter();
                List<string> datasource = null;
                database_cmb.DataSource = null;
                database_cmb.Items.Add("正在加载数据库名称..");
                new Action(() =>
                {
                    datasource = sqlAdapter.GetAllDatabase();
                    if(datasource.Count!=0)
                    this.Invoke(new Action(() => {
                        database_cmb.DataSource = datasource; 
                    }));
                }).BeginInvoke(null,null);
            }
        }
    }
}
