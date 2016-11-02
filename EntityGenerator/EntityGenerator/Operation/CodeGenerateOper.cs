using EntityGenerator.sqlAdapter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace EntityGenerator.Operation
{
    public class CodeGenerateOper
    {
        /// <summary>
        /// 生成实体内容
        /// </summary>
        /// <param name="content">未转换内容</param>
        /// <param name="generator">代码生成参数</param>
        /// <param name="tableName">表名</param>
        /// <returns>转换后内容</returns>
        public static string GenerateEntity(string content,GenerateParam generator,string tableName,IsqlAdapter sqlAdapter)
        {
            var forRegex = new Regex(@"(?<={{yx-columns}})[\s\S]*(?={{yx-end}})");
            content = content.Replace("{{yx-namespace}}", generator.nameSpace)
                     .Replace("{{yx-modifier}}", generator.modifier)
                     .Replace("{{yx-tableName}}", tableName);
            if(forRegex.IsMatch(content))
            {
                var columns = sqlAdapter.GetColumnsByTableName(tableName);
                var matchCollection = forRegex.Matches(content);
                foreach(Match match in matchCollection)
                {
                    foreach (var column in columns)
                    {
                        match.Value.Replace("{{yx-columnType}}", TypeConvertorOper.Convert(column.columnType));
                    }
                }
            }
        }
    }
}
