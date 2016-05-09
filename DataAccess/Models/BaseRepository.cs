using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public abstract class BaseRepository
    {
        private readonly string _connectionString;

        protected BaseRepository(string connectionName)
        {
            _connectionString = Connection.GetconnectionString(connectionName);
        }

        protected async Task<T> WithConnection<T>(Func<IDbConnection, Task<T>> getData)
        {
            try
            {
                using (var connection = new SqlConnection(_connectionString))
                {
                    await connection.OpenAsync();
                    return await getData(connection);
                }
            }
            catch (TimeoutException exception)
            {
                throw new Exception(string.Format("{0}.WithConnection() expired a Sql timeout",GetType().FullName,exception));
            }
        }

        protected async Task WithConnection<T>(Action<IDbConnection> action)
        {
            try
            {
                using (var connection = new SqlConnection(_connectionString))
                {
                    await connection.OpenAsync();
                }
            }
            catch (TimeoutException exception)
            {
                throw new Exception(string.Format("{0}.WithConnection() expired a Sql timeout", GetType().FullName,
                    exception));
            }
        }
    }
}
