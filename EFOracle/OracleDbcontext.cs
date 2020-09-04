using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Oracle.ManagedDataAccess.Client;


namespace EFOracle
{
    public class OracleDbcontext : DbContext
    {
        private static string connstr = "User Id=cividefen_jm;Password=qazZXC;Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=10.0.0.202)(PORT=1521)))(CONNECT_DATA=(SERVICE_NAME=gdrf)))";
        //private static string connstr = "User Id=cividefen_jm;Password=qazZXC;Data Source=gdrf";

        public OracleDbcontext():base(new OracleConnection(connstr),true)
        { 
            Database.SetInitializer<OracleDbcontext>(null);
        }

        
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("CIVIDEFEN_JM");
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Test> Tests { get; set; }
    }
}
