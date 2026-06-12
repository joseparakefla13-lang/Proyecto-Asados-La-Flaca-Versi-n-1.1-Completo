using Proyecto_Asados_La_Flaca_Versión_1._1_Completo.Domain;
using Proyecto_Asados_La_Flaca_Versión_1._1_Completo.Services.BusinessLogic;
using Microsoft.Data.SqlClient;
using System.Data;


namespace Proyecto_Asados_La_Flaca_Versión_1._1_Completo.Catalogs
{
    public partial class FrmOrder : Form
    {
        // Cadena de conexión privada
        private readonly string connectionString = "Server=COQUETO;Database=Dev_Asado2.sql;Integrated Security=True;TrustServerCertificate=True;Encrypt=False;";
        public FrmOrder()
        {
            InitializeComponent();

        }
        private void LoadEmployees()
        {

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT (Names + ' ' + SurNames) AS FullName FROM Employee WHERE Available = 1 ORDER BY Names";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                CbTitleEmployee.DataSource = dt;
                CbTitleEmployee.DisplayMember = "FullName";   // muestra Nombre + Apellido
                                                              // No necesitas ValueMember si no vas a usar el ID
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


        private void BtnSaveOrder_Click(object sender, EventArgs e)
        {

            if (DtgOrderDetail.Rows.Count == 0)
            {
                MessageBox.Show("Debe agregar al menos un producto.");
                return;
            }

            if (string.IsNullOrWhiteSpace(TxtCustomer.Text))
            {
                MessageBox.Show("Ingrese el cliente.");
                return;
            }

            if (CbTitleEmployee.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un empleado.");
                return;
            }

            if (string.IsNullOrWhiteSpace(CbAvailable.Text))
            {
                MessageBox.Show("Seleccione un estado.");
                return;
            }

            // Construir cabecera del pedido
            Order order = new Order
            {
                CustomerId = Convert.ToInt32(TxtCustomer.Text),
                EmployeeId = Convert.ToInt32(CbTitleEmployee.SelectedValue),
                State = CbAvailable.Text,
                Date = DateTime.Now,
                Available = true
            };

            OrderBusiness business = new OrderBusiness();
            int orderId = business.InsertOrder(order);

            // Guardar detalle
            foreach (DataGridViewRow row in DtgOrderDetail.Rows)
            {
                string productName = row.Cells["Producto"].Value.ToString();
                int quantity = Convert.ToInt32(row.Cells["Cantidad"].Value);
   
                     decimal price = Convert.ToDecimal(row.Cells["Precio"].Value);

                business.InsertOrderDetail(orderId, productName, quantity, price);
            }

            MessageBox.Show($"Pedido {orderId} guardado correctamente.");

            // Limpiar carrito y total
            DtgOrderDetail.Rows.Clear();
            TxtTotal.Text = string.Empty;
        }

        private void FrmOrder_Load(object sender, EventArgs e)
        {
            try
            {
                LoadEmployees();
                LoadProducts();
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

                // Agregar fila al DataGridView
                DtgOrderDetail.Rows.Add(productName, price, quantity, subtotal);

                // Recalcular total
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

    }
}


