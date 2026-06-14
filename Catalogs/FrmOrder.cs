using Proyecto_Asados_La_Flaca_Versión_1._1_Completo.Domain;
using Proyecto_Asados_La_Flaca_Versión_1._1_Completo.Services.BusinessLogic;
using Microsoft.Data.SqlClient;
using System.Data;


namespace Proyecto_Asados_La_Flaca_Versión_1._1_Completo.Catalogs
{
    public partial class FrmOrder : Form
    {
        private readonly OrderBusiness business = new OrderBusiness();
        // Cadena de conexión privada
        private readonly string connectionString =
            "Server=COQUETO;Database=Dev_Asado2.sql;Integrated Security=True;TrustServerCertificate=True;Encrypt=False;";
        public FrmOrder()
        {
            InitializeComponent();
            // Generar el siguiente código de pedido al cargar
            TxtN_Order.Text = business.GetNextOrderCode();
            TxtN_Order.Enabled = false;
            ConfigureDataGridView();

        }
        private void ConfigureDataGridView()
        {
            DtgOrderDetail.Columns.Clear();

            DtgOrderDetail.Columns.Add("ProductName", "Producto");
            DtgOrderDetail.Columns.Add("UnitPrice", "Precio");
            DtgOrderDetail.Columns.Add("Cuantity", "Cantidad");
            DtgOrderDetail.Columns.Add("SubTotal", "Subtotal");

            // columnas de cabecera que se replican en detalle
            DtgOrderDetail.Columns.Add("OrderCode", "N°Pedido");
            DtgOrderDetail.Columns.Add("Customer", "Cliente");
            DtgOrderDetail.Columns.Add("OrderDate", "Fecha");
            DtgOrderDetail.Columns.Add("OrderEmployee", "Empleado");
        }



        private void LoadEmployees()
        {

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = @"SELECT EmployeeCode, (Names + ' ' + SurNames) AS FullName
                         FROM Employee 
                         WHERE Available = 1 
                         ORDER BY Names";

                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                CbTitleEmployee.DataSource = dt;
                CbTitleEmployee.DisplayMember = "FullName";       // muestra Nombre + Apellido
                CbTitleEmployee.ValueMember = "EmployeeCode";     // guarda el código
            }
        }






        private void LoadProducts()
        {

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT ProductName, UnitPrice FROM Produc WHERE Available = 1 ORDER BY ProductName";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                CbProducts.DataSource = dt;
                CbProducts.DisplayMember = "ProductName";   // muestra solo el nombre
                                                            // No necesitas ValueMember si no usas el ID
            }
        }




        private void FrmOrder_Load(object sender, EventArgs e)
        {

            try
            {
                LoadEmployees();
                LoadProducts();

                // Mostrar el próximo código de pedido
                OrderBusiness business = new OrderBusiness();
                TxtN_Order.Text = business.GetNextOrderCode();
                TxtN_Order.Enabled = false; // siempre bloqueado
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar datos: {ex.Message}");
            }
        }

        private void CbProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CbProducts.SelectedItem != null)
            {
                DataRowView row = (DataRowView)CbProducts.SelectedItem;
                TxtPrice.Text = row["UnitPrice"].ToString();
            }
        }

        private void BtnInsertOrder_Click(object sender, EventArgs e)
        {
            if (CbProducts.SelectedItem != null &&
                         int.TryParse(TxtQuantity.Text, out int quantity) && quantity > 0)
            {
                DataRowView row = (DataRowView)CbProducts.SelectedItem;
                string productName = row["ProductName"].ToString();
                decimal price = Convert.ToDecimal(row["UnitPrice"]);
                decimal subtotal = price * quantity;

                // Insertar SOLO producto, precio, cantidad y subtotal
                DtgOrderDetail.Rows.Add(productName, price, quantity, subtotal, null, null, null, null);

                TxtSubTotal.Text = subtotal.ToString("N2");
                CalcularTotal();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un producto y una cantidad válida.");
            }
        }



        private void CalcularTotal()
        {
            decimal total = 0;
            foreach (DataGridViewRow row in DtgOrderDetail.Rows)
            {
                if (row.Cells["Subtotal"].Value != null)
                {
                    total += Convert.ToDecimal(row.Cells["Subtotal"].Value);
                }
            }
            TxtTotal.Text = total.ToString("N2");
        }



        private void BtsSearchCustomer_Click(object sender, EventArgs e)
        {

            // Capturamos el código escrito en el TextBox
            string codigo = TxtSearchCustomer.Text.Trim();

            // Instanciamos la capa de negocio
            CustomerBusiness business = new CustomerBusiness();

            // Llamamos al método que busca por código
            string nombre = business.GetCustomerNameByCode(codigo);

            // Si encontró el cliente, llenamos el campo automáticamente
            if (!string.IsNullOrEmpty(nombre))
            {
                TxtCustomer.Text = nombre; // muestra el nombre en el TextBox
            }
            else
            {
                MessageBox.Show("No se encontró un cliente con ese código.");
            }
        }

        private void BtnSaveOrder_Click(object sender, EventArgs e)
        {

            try
            {
                if (DtgOrderDetail.Rows.Count == 0)
                {
                    MessageBox.Show("Debe agregar al menos un producto antes de guardar.");
                    return;
                }

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlTransaction tran = conn.BeginTransaction();

                    try
                    {
                        // 1. Insertar cabecera en dbo.Order
                        string queryOrder = @"INSERT INTO [Order] (OrderDate, State, Available)
                                      VALUES (@OrderDate, @State, @Available);
                                      SELECT SCOPE_IDENTITY();";

                        SqlCommand cmdOrder = new SqlCommand(queryOrder, conn, tran);
                        cmdOrder.Parameters.AddWithValue("@OrderDate", DateTime.Now);
                        cmdOrder.Parameters.AddWithValue("@State", CbAvailable.Text);
                        cmdOrder.Parameters.AddWithValue("@Available", 1);

                        int orderId = Convert.ToInt32(cmdOrder.ExecuteScalar());

                        // 2. Insertar detalles en dbo.OrderDetail
                        foreach (DataGridViewRow row in DtgOrderDetail.Rows)
                        {
                            if (row.IsNewRow) continue;
                            if (row.Cells["ProductName"].Value == null) continue;

                            // completar columnas en la grilla
                            row.Cells["OrderCode"].Value = TxtN_Order.Text;
                            row.Cells["Customer"].Value = TxtCustomer.Text;
                            row.Cells["OrderDate"].Value = DateTime.Now;
                            row.Cells["OrderEmployee"].Value = CbTitleEmployee.Text;

                            string queryDetail = @"INSERT INTO OrderDetail 
                        (OrderId, ProductName, Cuantity, UnitPrice, SubTotal, Customer, OrderCode, OrderEmployee)
                        VALUES (@OrderId, @ProductName, @Cuantity, @UnitPrice, @SubTotal, @Customer, @OrderCode, @OrderEmployee)";

                            SqlCommand cmdDetail = new SqlCommand(queryDetail, conn, tran);
                            cmdDetail.Parameters.AddWithValue("@OrderId", orderId);
                            cmdDetail.Parameters.AddWithValue("@ProductName", row.Cells["ProductName"].Value);
                            cmdDetail.Parameters.AddWithValue("@Cuantity", row.Cells["Cuantity"].Value);
                            cmdDetail.Parameters.AddWithValue("@UnitPrice", row.Cells["UnitPrice"].Value);
                            cmdDetail.Parameters.AddWithValue("@SubTotal", row.Cells["SubTotal"].Value);
                            cmdDetail.Parameters.AddWithValue("@Customer", row.Cells["Customer"].Value);
                            cmdDetail.Parameters.AddWithValue("@OrderCode", row.Cells["OrderCode"].Value);
                            cmdDetail.Parameters.AddWithValue("@OrderEmployee", row.Cells["OrderEmployee"].Value);

                            cmdDetail.ExecuteNonQuery();
                        }

                        tran.Commit();

                        MessageBox.Show($"Pedido {TxtN_Order.Text} guardado correctamente.");
                    }
                    catch (Exception ex)
                    {
                        tran.Rollback();
                        MessageBox.Show($"Error al guardar pedido: {ex.Message}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error general: {ex.Message}");
            }



        }
    }
}






