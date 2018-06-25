using Newtonsoft.Json;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Data;

namespace OracleDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string connStr = "User Id=system;Password=123456;Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=10.0.0.201)(PORT=1521)))(CONNECT_DATA=(SERVICE_NAME=orcl3)))";
            string sql = "select * from u_role";
            DataTable datatable = new DataTable();
            using (OracleConnection conn = new OracleConnection(connStr))
            {
                conn.Open();
                using (OracleCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = sql;
                    OracleDataAdapter adapter = new OracleDataAdapter(cmd);
                    adapter.Fill(datatable);
                }
            }
            Console.WriteLine(JsonConvert.SerializeObject(datatable));
            Console.ReadKey();
        }
    }
}
