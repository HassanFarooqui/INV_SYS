using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace IVN_SYS.Models
{
    class ConnectionStringClass
    {
        public SqlConnection getDatabaseConnection()
        {
            string mainconnection = "Data Source=DESKTOP-I3IBHRD\\SQLEXPRESS2014;Initial Catalog=Inventory_System;Integrated Security=True;Connect Timeout=15;Encrypt=False;    TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection myconnection = new SqlConnection(mainconnection);
            return myconnection;
        }
    }
}
