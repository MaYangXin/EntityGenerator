using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityGenerator
{
    public class ConnInfo
    {
        public string server { get; set; }
        public string userName { get; set; }
        public string password { get; set; }
        public string databaseName { get; set; }
    }
    public class TableInfo
    {
        public string tableName { get; set; }
        public bool IsView { get; set; }
    }
    public class ColumnInfo
    {
        public string columnType { get; set; }
        public string columnName { get; set; }
    }
    public class GenerateParam
    {
        public string nameSpace { get; set; }
        public string modifier { get; set; }
        public string format { get; set; }
    }
}
