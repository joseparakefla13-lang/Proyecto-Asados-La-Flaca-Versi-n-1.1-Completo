using Proyecto_Asados_La_Flaca_Versión_1._1_Completo.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace Proyecto_Asados_La_Flaca_Versión_1._1_Completo.Services.BusinessLogic
{
    public class OrderBusiness   // cámbialo de internal a public
    {
            private readonly string connectionString =
                "Server=COQUETO;Database=Dev_Asado2;Integrated Security=True;TrustServerCertificate=True;Encrypt=False;";

            // Guardar cabecera del pedido y devolver el ID generado
            public int InsertOrder(Order order)
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"INSERT INTO Orde (Empleado_id, Clustomer_id, OrderDate, State, Observations, Available)
                             VALUES (@Empleado_id, @Clustomer_id, @OrderDate, @State, @Observations, @Available);
                             SELECT SCOPE_IDENTITY();";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Empleado_id", order.EmployeeId);
                    cmd.Parameters.AddWithValue("@Clustomer_id", order.CustomerId);
                    cmd.Parameters.AddWithValue("@OrderDate", order.Date);
                    cmd.Parameters.AddWithValue("@State", order.State);
                    cmd.Parameters.AddWithValue("@Observations", order.Observations ?? "");
                    cmd.Parameters.AddWithValue("@Available", order.Available);

                    return Convert.ToInt32(cmd.ExecuteScalar()); // devuelve el ID generado
                }
            }

            // Guardar detalle del pedido con parámetros sueltos
            public void InsertOrderDetail(int orderId, string productName, int quantity, decimal price)
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"INSERT INTO OrderDetail (Order_id, ProductName, Quantity, UnitPrice, SubTotal)
                             VALUES (@Order_id, @ProductName, @Quantity, @UnitPrice, @SubTotal)";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Order_id", orderId);
                    cmd.Parameters.AddWithValue("@ProductName", productName);
                    cmd.Parameters.AddWithValue("@Quantity", quantity);
                    cmd.Parameters.AddWithValue("@UnitPrice", price);
                    cmd.Parameters.AddWithValue("@SubTotal", price * quantity);

                    cmd.ExecuteNonQuery();
                }
            }

            // Guardar detalle del pedido usando objeto OrderDetail
            public void InsertOrderDetail(OrderDetail detail)
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"INSERT INTO OrderDetail (Order_id, ProductName, Quantity, UnitPrice, SubTotal)
                             VALUES (@Order_id, @ProductName, @Quantity, @UnitPrice, @SubTotal)";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Order_id", detail.OrderId);
                    cmd.Parameters.AddWithValue("@ProductName", detail.ProductName);
                    cmd.Parameters.AddWithValue("@Quantity", detail.Quantity);
                    cmd.Parameters.AddWithValue("@UnitPrice", detail.UnitPrice);
                    cmd.Parameters.AddWithValue("@SubTotal", detail.SubTotal);

                    cmd.ExecuteNonQuery();
                }
            }

            // Método completo: guarda cabecera y todos los detalles
            public void CompleteOrder(Order order)
            {
                if (order.CustomerId <= 0) throw new Exception("Debe seleccionar un cliente.");
                if (order.EmployeeId <= 0) throw new Exception("Debe seleccionar un empleado.");
                if (order.Detalles == null || order.Detalles.Count == 0)
                    throw new Exception("El pedido debe tener al menos un detalle.");

                int orderId = InsertOrder(order);

                foreach (var d in order.Detalles)
                {
                    d.OrderId = orderId;
                    d.CalcularSubTotal();
                    if (!d.EsValido())
                        throw new Exception($"Detalle inválido para producto {d.ProductName}");
                    InsertOrderDetail(d);
                }
            }
        

    }

}
