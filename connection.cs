using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Management
{
    internal class connection
    {

        public static SqlConnection DataCon { get; set; }

        public static void ConnectDB(string server, string dbName)
        {
            DataCon = new SqlConnection($"Server={server};Database={dbName};Trusted_Connection=True;TrustServerCertificate=True;");
            DataCon.Open();
        }



        public static void ConnectDB(string server, string dbName, string user, string pass)
        {
            DataCon = new SqlConnection($"Server={server};Database={dbName};User Id={user};Password={pass};TrustServerCertificate=True;");
            DataCon.Open();
        }

    }
}
