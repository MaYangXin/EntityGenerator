using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityGenerator.sqlAdapter
{
    public class mysqlAdapter : IsqlAdapter
    {
        public ConnInfo connInfo { get; set; }
        public string connStr { get; set; }
        public mysqlAdapter(ConnInfo connInfo)
        {
            this.connInfo = connInfo;
            connStr = string.Format("server={0};user id={1};password={2};database={3}",
            connInfo.server, connInfo.userName, connInfo.password, connInfo.databaseName);
        }
        public bool TestConnection()
        {
            var dbconnection = new MySqlConnection(connStr);
            try
            {
                dbconnection.Open();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Write(ex);
                return false;
            }
            finally
            {
                dbconnection.Close();
            }
            return true;
        }
        public List<TableInfo> GetAllTable()
        {
            var tables = new List<TableInfo>();
            using (var conn = new MySqlConnection(connStr))
            {
                conn.Open();
                var cmd = new MySqlCommand("select table_Name,table_type from information_schema.tables where table_schema='kdss_online'", conn);
                var adapter = new MySqlDataAdapter(cmd);
                var dsResult = new DataSet();
                adapter.Fill(dsResult);
                if (dsResult.Tables.Count > 0)
                {
                    foreach (DataRow row in dsResult.Tables[0].Rows)
                    {
                        tables.Add(new TableInfo
                        {
                            tableName = row["table_Name"].ToString(),
                            IsView = row["table_type"] == "VIEW" ? true : false
                        });
                    }
                }
            }
            return tables;
        }
        public List<ColumnInfo> GetColumnsByTableName(string tableName)
        {
            var tables = new List<ColumnInfo>();
            using (var conn = new MySqlConnection(connStr))
            {
                conn.Open();
                var cmd = new MySqlCommand("desc @tableName", conn);
                cmd.Parameters.Add(new MySqlParameter("@tableName", tableName));
                var adapter = new MySqlDataAdapter(cmd);
                var dsResult = new DataSet();
                adapter.Fill(dsResult);
                if (dsResult.Tables.Count > 0)
                {
                    foreach (DataRow row in dsResult.Tables[0].Rows)
                    {
                        tables.Add(new ColumnInfo
                        {
                            columnName = row["Field"].ToString(),
                            columnType = row["Type"].ToString()
                        });
                    }
                }
            }
            return tables;
        }
    }
}
