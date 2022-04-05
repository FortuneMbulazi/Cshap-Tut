using System;
using System.Configuration;
using System.Data.SqlClient;

namespace DapperExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var conString = ConfigurationManager.ConnectionStrings["TestDB"].ConnectionString;
            using(var con = new SqlConnection(""))
            {

            }
        }
    }
}
