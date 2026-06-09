using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Configuration;

namespace Proyecto_Asados_La_Flaca_Versión_1._1_Completo.Services
{
    public abstract class DataBaseConnection : IDisposable
    {
        protected SqlConnection? _connection;
        protected SqlCommand? _command;
        private bool _disposed = false;

        protected DataBaseConnection()
        {
            string connectionString = GetConnectionString();
            _connection = new SqlConnection(connectionString);
        }

        protected DataBaseConnection(string connectionString)
        {
            _connection = new SqlConnection(connectionString);
        }

        protected void OpenConnection()
        {
            if (_connection is null)
                throw new InvalidOperationException("La conexión no ha sido inicializada.");

            if (_connection.State == System.Data.ConnectionState.Closed)
                _connection.Open();
        }

        protected void CloseConnection()
        {
            if (_connection is not null &&
                _connection.State == System.Data.ConnectionState.Open)
            {
                _connection.Close();
            }
        }

        private static string GetConnectionString()
        {
            IConfiguration config = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: false)
                .Build();

            string? connStr = config.GetConnectionString("DefaultConnection");

            if (string.IsNullOrEmpty(connStr))
                throw new InvalidOperationException(
                    "No se encontró 'DefaultConnection' en appsettings.json.");

            return connStr;
        }

        public bool TestConnection()
        {
            try
            {
                OpenConnection();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                CloseConnection();
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _command?.Dispose();
                    CloseConnection();
                    _connection?.Dispose();
                }
                _disposed = true;
            }
        }
    }
}

