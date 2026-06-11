using Proyecto_Asados_La_Flaca_Versión_1._1_Completo.Domain;
using Proyecto_Asados_La_Flaca_Versión_1._1_Completo.Services.BusinessLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using Microsoft.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace Proyecto_Asados_La_Flaca_Versión_1._1_Completo.Catalogs
{
    public partial class FrmCustomer : Form
    {
        private readonly string connectionString = "Server=COQUETO;Database=Dev_Asado2.sql;Integrated Security=True;TrustServerCertificate=True;Encrypt=False;";
        public FrmCustomer()
        {
            InitializeComponent();
            LoadClientTypes();
            this.AutoValidate = AutoValidate.EnablePreventFocusChange;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void DtmFecha_ValueChanged(object sender, EventArgs e)
        {

        }
        private void LoadCustomers()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = "SELECT ClustomerCode, Names, Phone, TypeCustomer, Available, RegistDate FROM Customer";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    DgvCustomer.AutoGenerateColumns = false; // evita duplicados
                    DgvCustomer.DataSource = dt;

                    // Configurar columnas manualmente
                    DgvCustomer.Columns.Clear();

                    DgvCustomer.Columns.Add(new DataGridViewTextBoxColumn
                    {
                        DataPropertyName = "ClustomerCode",
                        HeaderText = "Código"
                    });
                    DgvCustomer.Columns.Add(new DataGridViewTextBoxColumn
                    {
                        DataPropertyName = "Names",
                        HeaderText = "Nombre"
                    });
                    DgvCustomer.Columns.Add(new DataGridViewTextBoxColumn
                    {
                        DataPropertyName = "Phone",
                        HeaderText = "Teléfono"
                    });
                    DgvCustomer.Columns.Add(new DataGridViewTextBoxColumn
                    {
                        DataPropertyName = "TypeCustomer",
                        HeaderText = "Tipo"
                    });
                    DgvCustomer.Columns.Add(new DataGridViewCheckBoxColumn
                    {
                        DataPropertyName = "Available",
                        HeaderText = "Activo"
                    });
                    DgvCustomer .Columns.Add(new DataGridViewTextBoxColumn
                    {
                        DataPropertyName = "RegistDate",
                        HeaderText = "Fecha Registro"
                    });

                    DgvCustomer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar clientes: " + ex.Message);
            }
        }

        

        
        private void LoadClientTypes()
        {
            try
            {
                CustomerTypeBusiness business = new CustomerTypeBusiness();
                DataTable dt = business.GetCustomerTypes();

                if (dt.Rows.Count > 0)
                {
                    // Verificamos el nombre real de la columna
                    string columnName = dt.Columns[0].ColumnName;

                    CbTypeCustomer.DataSource = dt;
                    CbTypeCustomer.DisplayMember = columnName;   // lo que se muestra
                    CbTypeCustomer.ValueMember = columnName;     // lo que se guarda
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar tipos de cliente: {ex.Message}");
            }
        }
        private void BtnSaveClient_Click(object sender, EventArgs e)
        {

            try
            {
                Customer nuevo = new Customer
                {
                    ClustomerCode = TxtCustomerCode.Text.Trim(),
                    Names = TxtName.Text.Trim(),
                    Phone = TxtPhone.Text.Trim(),
                    TypeCustomer = CbTypeCustomer.Text,
                    Available = true,
                    RegistDate = DateTime.Today
                };

                CustomerBusiness business = new CustomerBusiness();
                int rows = business.InsertCustomer(nuevo);

                MessageBox.Show(rows > 0 ? "Cliente agregado correctamente." : "No se pudo agregar el cliente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar cliente: {ex.Message}");
            }
        }

        private void FrmCustomer_Load(object sender, EventArgs e)
        {
            LoadCustomers(); // carga al abrir el formulario
        }



        private void TxtCustomerCode_Validating(object sender, CancelEventArgs e)
        {
            string input = TxtCustomerCode.Text.Trim().ToUpper(); // normalizar a mayúsculas

            // Formato: CL seguido de 3 dígitos
            Regex regex = new Regex(@"^CLI\d{3}$");

            if (!regex.IsMatch(input))
            {
                lblErrorCode.Visible = true;   // mostrar mensaje
                e.Cancel = true;               // evita que el foco cambie
            }
            else
            {
                lblErrorCode.Visible = false;  // ocultar mensaje si es válido
            }
        }

        private void TxtPhone_Validating(object sender, CancelEventArgs e)
        {
            string input = TxtPhone.Text.Trim();

            // Expresión regular: exactamente 8 dígitos
            Regex regex = new Regex(@"^\d{8}$");

            if (!regex.IsMatch(input))
            {
                LblErrorPhone.Text = "El teléfono debe tener exactamente 8 dígitos numéricos.";
                LblErrorPhone.Visible = true;
                e.Cancel = true; // bloquea el avance al siguiente campo
            }
            else
            {
                LblErrorPhone.Visible = false; // oculta el mensaje si es válido
            }
        }

   
    }
}
