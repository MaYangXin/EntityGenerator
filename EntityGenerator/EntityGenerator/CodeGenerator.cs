using EntityGenerator.controls;
using EntityGenerator.sqlAdapter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityGenerator
{
    public partial class codeGenerator_frm : Form
    {
        private IsqlAdapter sqlAdapter;
        private List<TableInfo> tables;
        public codeGenerator_frm(IsqlAdapter sqlAdapter)
        {
            InitializeComponent();
            this.sqlAdapter = sqlAdapter;
        }

        private void codeGenerator_frm_Load(object sender, EventArgs e)
        {
            BindingTree();
        }
        private void BindingTree()
        {
            table_tvw.SuspendLayout();
            var rootNode = new TreeNode(sqlAdapter.connInfo.databaseName);
            var tableNode = new TreeNode("表");
            var viewNode = new TreeNode("视图");
            tables = sqlAdapter.GetAllTable();
            tables.FindAll(P => P.IsView).ForEach(P => viewNode.Nodes.Add(P.tableName));
            tables.FindAll(P => !P.IsView).ForEach(P => tableNode.Nodes.Add(P.tableName));
            rootNode.Nodes.Add(tableNode);
            rootNode.Nodes.Add(viewNode);
            table_tvw.Nodes.Add(rootNode);
            table_tvw.ResumeLayout(true);
        }

        private void table_tvw_AfterCheck(object sender, TreeViewEventArgs e)
        {
            TreeViewCheck.CheckControl(e);
        }

        private void preview_btn_Click(object sender, EventArgs e)
        {
            if (tables.Count > 0)
            {
                //cSharp_content_rtx.Text.Replace("{{yx-namespace}}", cSharp_namespace_txt.Text);
                //cSharp_content_rtx.Text.Replace("{{yx-modifier}}",cSharp_modifier_txt.Text);
                var foreachRegex = new Regex("{{yx-foreach}}<%(/S/s)+%>");
                var i = foreachRegex.Matches(cSharp_content_rtx.Text).Count;
                cSharp_content_rtx.Text.Replace("{{yx-foreach}}", cSharp_modifier_txt.Text);
                new Preview_frm().ShowDialog();
            }
        }
        private void Set()
        {

        }
        private void generator_btn_Click(object sender, EventArgs e)
        {
            foreach (TreeNode topNode in table_tvw.TopNode.Nodes)
            {
                foreach (TreeNode node in topNode.Nodes)
                {
                    if (node.Checked)
                    {
                        var content = cSharp_content_rtx.Text.Replace("yx-namespace", cSharp_namespace_txt.Text)
                               .Replace("yx-modifier", cSharp_modifier_txt.Text)
                               .Replace("yx-tableName", node.Text);
                        var columnInfos = sqlAdapter.GetColumnsByTableName(node.Text);
                        var columnBuider = new StringBuilder();
                        foreach (var column in columnInfos)
                        {
                           // columnBuider.Append("public " + TypeConvert.ConvertToCSharp(column.columnType) + " " + column.columnName + "{get;set;}");
                            columnBuider.Append("\r\n");
                        }
                        content = content.Replace("yx-content", columnBuider.ToString());
                    }
                }
            }
        }
    }
}
