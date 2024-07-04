using Microsoft.Data.SqlClient;
using System.Collections.Concurrent;

namespace DataBaseCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Connect();
        }

        static void Connect()
        {
            SqlConnection sqlConn = new SqlConnection();

            try
            {
                sqlConn.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=JKJune2024;Integrated Security=True";
                sqlConn.Open();
                
                Console.WriteLine("Success");
            }
            catch(Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
            sqlConn.Close(); 
            }
        }
    }
}
