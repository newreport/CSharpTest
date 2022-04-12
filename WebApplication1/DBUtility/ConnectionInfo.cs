using System.Configuration;

namespace WebApplication1.DBUtility
{
    public class ConnectionInfo
    {
        public static string GetMySQLConnectionString()
        {
            return ConfigurationSettings.AppSettings["MySQLConnString"];

        }
    }
}
