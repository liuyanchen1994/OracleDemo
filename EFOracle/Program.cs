using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EFOracle
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                OracleDbcontext dbcontext = new OracleDbcontext();
                var test = dbcontext.Tests.ToList();

                Console.WriteLine(test.ToString());
                Console.ReadKey();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }
    }
}
