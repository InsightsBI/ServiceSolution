using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insights.DataLayer
{
  public class RuntimeConnectionString
    {
        SqlConnection conn;

        public RuntimeConnectionString( string connectionString)
        {
            conn = new SqlConnection(connectionString);
        }
        public bool IsConnection
        {
            get
            {
                if (conn.State == System.Data.ConnectionState.Closed)
                { 
                    try
                    {
                        conn.Open();
                        return true;
                    }
                    catch (Exception)
                    {
                        conn.Close();
                        return false;
                    }
                }
                return false;

            }
        }
    }
}
