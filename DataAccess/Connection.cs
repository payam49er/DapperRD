using System;
using static System.Configuration.ConfigurationManager;

namespace DataAccess
{
    public static class Connection
    {
       public static string GetconnectionString(string connectionStringName)
        {
           if(!string.IsNullOrEmpty(connectionStringName))
                return ConnectionStrings[connectionStringName].ConnectionString;
            throw new Exception("Connection string is not defined");
        }
    }
}
