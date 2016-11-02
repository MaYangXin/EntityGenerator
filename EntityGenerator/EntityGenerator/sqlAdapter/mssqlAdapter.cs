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
        public List<table> GetAllTable()
        {
            var tables=new List<table>();
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
                        tables.Add(new table
                        {
                            tableName = row["name"].ToString(),
                            IsView = row["xtype"].ToString().Trim() == "V" ? true : false
                        });
                    }
                }
            }
            return tables;
        }
    }
}
