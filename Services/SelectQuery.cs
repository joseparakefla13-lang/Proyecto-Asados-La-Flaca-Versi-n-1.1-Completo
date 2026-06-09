using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Text;
namespace Proyecto_Asados_La_Flaca_Versión_1._1_Completo.Services
{
   /// <summary>
        /// Subclase para ejecutar consultas SELECT.
        /// Devuelve datos como DataTable para uso directo en controles Windows Forms
        /// (DataGridView, ComboBox, ListBox, etc.).
        /// </summary>
        public class SelectQuery : DataBaseConnection
        {
            // Hereda _connection y _command de la superclase DatabaseConnection.

            public SelectQuery() : base() { }
            public SelectQuery(string connectionString) : base(connectionString) { }

            /// <summary>
            /// Ejecuta una consulta SELECT y devuelve un DataTable con los resultados.
            /// </summary>
            /// <param name="query">Consulta SQL parametrizada.</param>
            /// <param name="parameters">Parámetros SQL (previenen inyección SQL).</param>
            /// <returns>DataTable con los registros encontrados.</returns>
            public DataTable ExecuteSelect(string query,
                                           SqlParameter[] parameters = null)
            {
                DataTable result = new DataTable();

                try
                {
                    OpenConnection();

                    _command = new SqlCommand(query, _connection);
                    _command.CommandType = CommandType.Text;

                    if (parameters is not null)
                        _command.Parameters.AddRange(parameters);

                    using SqlDataAdapter adapter = new SqlDataAdapter(_command);
                    adapter.Fill(result); // Llena el DataTable con los resultados de la consulta.
                }
                catch (SqlException ex)
                {
                    throw new Exception($"Error al intentar obtener resultados " + $"{ex.Message}", ex);
                }
                finally
                {
                    CloseConnection();
                }

                return result;
            } //end exe

            public bool IsDuplicate(string query, SqlParameter[] parameters = null)
            {
                try
                {

                    OpenConnection();

                    _command = new SqlCommand(query, _connection);
                    _command.CommandType = CommandType.Text;

                    if (parameters is not null)
                        _command.Parameters.AddRange(parameters);

                    return Convert.ToBoolean(_command.ExecuteScalar());

                }
                catch (SqlException ex)
                {
                    throw new Exception(
                              $"Error al ejecutar consulta escalar . {ex.Message}", ex);


                }
                finally
                {

                    CloseConnection();

                }


            }

        } }
