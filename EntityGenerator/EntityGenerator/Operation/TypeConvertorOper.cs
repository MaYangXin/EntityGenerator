using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityGenerator.Operation
{
    public class TypeConvertorOper
    {
        public static string Convert(string type)
        {
            switch (type)
            {
                case "bit": return "bool";
                case "tinyint": return "byte";
                case "smallint": return "short";
                case "int": return "int";
                case "bigint": return "long";
                case "real": return "float";
                case "float": return "double";
                case "money": return "decimal";
                case "datetime": return "DateTime";
                case "char": return "string";
                case "varchar": return "string";
                case "nchar": return "string";
                case "nvarchar": return "string";
                case "text": return "string  ";
                case "ntext": return "string ";
                case "image": return "byte[] ";
                case "binary": return "byte[]";
            }
            return null;
        }
    }
}
