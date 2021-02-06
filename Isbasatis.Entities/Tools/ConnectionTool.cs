using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Isbasatis.Entities.Tools
{
   public static class ConnectionTool
    {

        public static bool CheckConnection(string SqlServerConnectionString)
        {
            using (SqlConnection connection = new SqlConnection(SqlServerConnectionString))
            {
                try
                {
                    connection.Open();
                    return true;
                }
                catch (Exception)
                {

                    return false;   
                }
            }
        }
    }
}
