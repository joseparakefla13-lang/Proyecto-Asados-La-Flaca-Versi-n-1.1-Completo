using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Text;
using Microsoft.Data.SqlClient;

namespace Proyecto_Asados_La_Flaca_Versión_1._1_Completo.Services
{
    /// <summary>
    /// Subclase para ejecutar operaciones DELETE.
    /// </summary>
    public class DeleteCommand : DataBaseConnection
    {
        public DeleteCommand() : base() { }
        public DeleteCommand(string connectionString) : base(connectionString) { }

        /// <summary>
        /// Ejecuta un DELETE y devuelve el número de filas eliminadas.
        /// </summary>
        /// <param name="query">Sentencia DELETE parametrizada.</param>
        /// <param name="parameters">Parámetros SQL.</param>
        /// <returns>Número de filas eliminadas.</returns>
        public int ExecuteDelete(string query, SqlParameter[]? parameters = null)
        {
            try
            {
                OpenConnection();

                _command = new SqlCommand(query, _connection);
                _command.CommandType = CommandType.Text;

                if (parameters is not null)
                    _command.Parameters.AddRange(parameters);

                int rowsAffected = _command.ExecuteNonQuery();

                if (rowsAffected == 0)
                    throw new Exception("El DELETE no eliminó ningún registro. " +
                                        "Verifica que el ID exista en la base de datos.");

                return rowsAffected;
            }
            catch (SqlException ex)
            {
                throw new Exception($"Error SQL al ejecutar DELETE: {ex.Message}", ex);
            }
            finally
            {
                CloseConnection();
            }
        }
    }
}
