using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityGenerator.sqlAdapter
{
     public class mssqlAdapter:IsqlAdapter
    {
         public ConnInfo connInfo { get; set; }
         public string connStr { get; set; }
         public mssqlAdapter()
         {

         }
         public mssqlAdapter(ConnInfo connInfo)
        {
            this.connInfo = connInfo;
            connStr = string.Format("server={0};user id={1};password={2};database={3}",
            connInfo.server, connInfo.userName, connInfo.password, connInfo.databaseName);

        }
        public bool TestConnection()
        {
             var dbconnection = new SqlConnection(connStr);
             try{
                 dbconnection.Open();
             }
             catch(Exception ex)
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
            using(var conn=new SqlConnection(connStr))
            {
                conn.Open();
                var cmd = new SqlCommand("select name,xtype from sysobjects where xtype='U' or xtype='V'", conn);
                var adapter = new SqlDataAdapter(cmd);
                var dsResult = new DataSet();
                adapter.Fill(dsResult);
                if(dsResult.Tables.Count>0)
                {
                    foreach(DataRow row in dsResult.Tables[0].Rows)
                    {
                        tables.Add(new TableInfo
                        {
                            tableName = row["name"].ToString(),
                            IsView = row["xtype"].ToString().Trim() == "V" ? true : false
                        });
                    }
                }
            }
            return tables;
        }
        public List<ColumnInfo> GetColumnsByTableName(string tableName)
        {
            var tables = new List<ColumnInfo>();
            using(var conn=new  SqlConnection(connStr))
            {
                conn.Open();
                var cmd = new SqlCommand("select COLUMN_NAME,DATA_TYPE from information_schema.columns where table_name=@tableName", conn);
                cmd.Parameters.Add(new SqlParameter("@tableName", tableName));
                var adapter = new SqlDataAdapter(cmd);
                var dsResult = new DataSet();
                adapter.Fill(dsResult);
                if (dsResult.Tables.Count > 0)
                {
                    foreach (DataRow row in dsResult.Tables[0].Rows)
                    {
                        tables.Add(new ColumnInfo
                        {
                            columnName = row["COLUMN_NAME"].ToString(),
                            columnType = row["DATA_TYPE"].ToString()
                        });
                    }
                }
            }
            return tables;
        }
    }
}
