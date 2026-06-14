using Microsoft.Data.SqlClient;
using Proyecto_Asados_La_Flaca_Versión_1._1_Completo.Domain;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Collections.Generic;

namespace Proyecto_Asados_La_Flaca_Versión_1._1_Completo.Services.BusinessLogic
{
    public class OrderBusiness
    {

            private readonly string connectionString = "Server=COQUETO;Database=Dev_Asado2.sql;Integrated Security=True;TrustServerCertificate=True;Encrypt=False;";



        public string GetNextOrderCode()
        {
            string query = "SELECT ISNULL(MAX(OrderCode), 0) + 1 FROM OrderDetail";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                conn.Open();
                return cmd.ExecuteScalar().ToString();
            }
        }



        public void CompleteOrder(Order order)
        { 
          using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    // Insertar cabecera en Order (solo fecha, estado y disponible)
                    string insertOrder = @"INSERT INTO [Order] (State, Date, Available) 
                                   VALUES (@State, @Date, @Available)";

                    using (SqlCommand cmdOrder = new SqlCommand(insertOrder, conn, transaction))
                    {
                        cmdOrder.Parameters.AddWithValue("@State", order.State);
                        cmdOrder.Parameters.AddWithValue("@Date", order.Date);
                        cmdOrder.Parameters.AddWithValue("@Available", order.Available);
                        cmdOrder.ExecuteNonQuery();
                    }

                    // Insertar detalles en OrderDetail
                    foreach (var detail in order.Detalles)
                    {
                        detail.CalcularSubTotal();

                        string insertDetail = @"INSERT INTO OrderDetail 
                    (OrderCode, ProductName, Cuantity, UnitPrice, SubTotal, Customer, OrderEmployee, Available) 
                    VALUES (@OrderCode, @ProductName, @Cuantity, @UnitPrice, @SubTotal, @Customer, @OrderEmployee, @Available)";

                        using (SqlCommand cmdDetail = new SqlCommand(insertDetail, conn, transaction))
                        {
                            cmdDetail.Parameters.AddWithValue("@OrderCode", detail.OrderCode);
                            cmdDetail.Parameters.AddWithValue("@ProductName", detail.ProductName);
                            cmdDetail.Parameters.AddWithValue("@Cuantity", detail.Quantity);
                            cmdDetail.Parameters.AddWithValue("@UnitPrice", detail.UnitPrice);
                            cmdDetail.Parameters.AddWithValue("@SubTotal", detail.SubTotal);
                            cmdDetail.Parameters.AddWithValue("@Customer", detail.Customer);
                            cmdDetail.Parameters.AddWithValue("@OrderEmployee", detail.OrderEmployee);
                            cmdDetail.Parameters.AddWithValue("@Available", detail.Available);
                            cmdDetail.ExecuteNonQuery();
                        }
                    }

                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw new Exception("Error al guardar el pedido completo. Detalle: " + ex.Message);
                }
            }
        }


    }



} 



