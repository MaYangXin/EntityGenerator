using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityGenerator.sqlAdapter
{
    public interface IsqlAdapter
    {
        ConnInfo connInfo { get; set; }
        string connStr { get; set; }
        bool TestConnection();
        List<TableInfo> GetAllTable();
        public List<ColumnInfo> GetColumnsByTableName(string tableName);
    }
}
