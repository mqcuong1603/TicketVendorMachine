using System;
using System.Data.SqlClient;

namespace TicketVendorMachine.DataAccess
{
    public class DatabaseHelper
    {
        // CHANGE THIS PASSWORD TO MATCH YOUR DOCKER SQL SERVER
        private static string connectionString =
            "Server=localhost,1433;Database=TicketVendorDB;User Id=sa;Password=Cuong7453*;TrustServerCertificate=True;";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }

        public static bool TestConnection()
        {
            try
            {
                using (var conn = GetConnection())
                {
                    conn.Open();
                    return true;
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Connection failed: {ex.Message}");
                return false;
            }
        }
    }
}