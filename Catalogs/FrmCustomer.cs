using Microsoft.Data.SqlClient;
using Proyecto_Asados_La_Flaca_Versión_1._1_Completo.Domain;
using Proyecto_Asados_La_Flaca_Versión_1._1_Completo.Services;
using Proyecto_Asados_La_Flaca_Versión_1._1_Completo.Services.BusinessLogic;
using System.ComponentModel;
using System.Data;
using System.Text.RegularExpressions;
namespace Proyecto_Asados_La_Flaca_Versión_1._1_Completo.Catalogs
{
    public partial class FrmCustomer : Form
    {
        
                         // Cadena de conexión a la base de datos//

        private readonly string connectionString = "Server=COQUETO;Database=Dev_Asado2.sql;Integrated Security=True;TrustServerCertificate=True;Encrypt=False;";
        public FrmCustomer()
        {
            InitializeComponent();
            // Configuración inicial del DataGridView//
            DgvCustomer.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // selecciona fila completa//
            DgvCustomer.MultiSelect = false; DgvCustomer.MultiSelect = false; // solo permite seleccionar una fila//
            LoadClientTypes();// carga tipos de cliente en el combo//
            this.AutoValidate = AutoValidate.EnablePreventFocusChange;// activa validaciones automáticas//
        }
        /* ------------------- CARGAR CLIENTES ACTIVOS ------------------- */
        private void LoadCustomers()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                             // Consulta que trae solo clientes activos//
                    string query = @"SELECT ClustomerCode, Names, Phone, TypeCustomer, Available, RegistDate 
                             FROM Customer
                             WHERE Available = 1";   // solo clientes activos

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    // Configuración del DataGridView//
                    DgvCustomer.AutoGenerateColumns = false; // evita duplicados
                    DgvCustomer.DataSource = null;           // limpia antes
                    DgvCustomer.Rows.Clear();                // evita filas fantasma
                    DgvCustomer.DataSource = dt;

                    // limpieza columnas automáticas y configura manualmente para controlar el orden y formato//
                    DgvCustomer.Columns.Clear();
                    // Configurar columnas manualmente
                    DgvCustomer.Columns.Add(new DataGridViewTextBoxColumn
                    {
                        Name = "ClustomerCode",
                        DataPropertyName = "ClustomerCode",
                        HeaderText = "Código"
                    });
                    DgvCustomer.Columns.Add(new DataGridViewTextBoxColumn
                    {
                        Name = "Names",
                        DataPropertyName = "Names",
                        HeaderText = "Nombre"
                    });
                    DgvCustomer.Columns.Add(new DataGridViewTextBoxColumn
                    {
                        Name = "Phone",
                        DataPropertyName = "Phone",
                        HeaderText = "Teléfono"
                    });
                    DgvCustomer.Columns.Add(new DataGridViewTextBoxColumn
                    {
                        Name = "TypeCustomer",
                        DataPropertyName = "TypeCustomer",
                        HeaderText = "Tipo"
                    });
                    DgvCustomer.Columns.Add(new DataGridViewCheckBoxColumn
                    {
                        Name = "Available",
                        DataPropertyName = "Available",
                        HeaderText = "Activo"
                    });
                    DgvCustomer.Columns.Add(new DataGridViewTextBoxColumn
                    {
                        Name = "RegistDate",
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
        /* ------------------- CARGAR TIPOS DE CLIENTE ------------------- */

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
        /* ------------------- GUARDAR NUEVO CLIENTE ------------------- */
        private void BtnSaveClient_Click(object sender, EventArgs e)
        {

            try
            {
                CustomerBusiness business = new CustomerBusiness();

                // 1. Generar el siguiente código disponible
                string nextCode = business.GetNextCustomerCode();
                TxtCustomerCode.Text = nextCode;

                // 2. Validar nombre
                string nombre = TxtName.Text.Trim();
                if (string.IsNullOrEmpty(nombre))
                {
                    MessageBox.Show("Debe ingresar un nombre.");
                    return;
                }

                // 3. Validar teléfono
                string telefono = TxtPhone.Text.Trim();
                if (string.IsNullOrEmpty(telefono))
                {
                    MessageBox.Show("Debe ingresar un número de teléfono.");
                    return;
                }
                if (!business.IsUniquePhone(telefono))
                {
                    MessageBox.Show("El número de teléfono ya está registrado. Ingrese uno diferente.");
                    return;
                }

                // 4. Validar tipo de cliente
                string tipoCliente = CbTypeCustomer.Text;
                if (string.IsNullOrEmpty(tipoCliente))
                {
                    MessageBox.Show("Debe seleccionar un tipo de cliente.");
                    return;
                }

                // 5. Validar fecha (solo hoy)
                DateTime fechaRegistro = DtmRegistrationDate.Value.Date;
                if (!business.IsValidRegisterDate(fechaRegistro))
                {
                    MessageBox.Show("La fecha de registro debe ser la de hoy.");
                    return;
                }

                // 6. Validar estado activo (CheckBox)
                if (!ChAvailable.Checked)
                {
                    MessageBox.Show("Debe marcar el estado Activo para poder guardar el cliente.");
                    return;
                }

                // 7. Crear objeto cliente con todos los datos validados
                Customer nuevo = new Customer
                {
                    ClustomerCode = nextCode,
                    Names = nombre,
                    Phone = telefono,
                    TypeCustomer = tipoCliente,
                    Available = true,              // se guarda activo solo si el CheckBox está marcado
                    RegistDate = fechaRegistro
                };

                // 8. Guardar en BD
                int rows = business.InsertCustomer(nuevo);

                if (rows > 0)
                {
                    MessageBox.Show($"Cliente agregado correctamente con código {nextCode}.");
                    LoadCustomers(); // refresca grid
                }
                else
                {
                    MessageBox.Show("No se pudo agregar el cliente.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar cliente: {ex.Message}");
            }
        }

    
    
        
        /* ------------------- EVENTO LOAD DEL FORM ------------------- */
        private void FrmCustomer_Load(object sender, EventArgs e)
        {
            LoadCustomers(); // carga al abrir el formulario
            DgvCustomer.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvCustomer.MultiSelect = false;
            DgvCustomer.AllowUserToAddRows = false; // evita fila vacía extra
            ConfigurarModoLectura(true); // por defecto solo lectura
        }


        /* ------------------- VALIDACIONES ------------------- */
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
        /* ------------------- DAR DE BAJA CLIENTE ------------------- */
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (DgvCustomer.SelectedRows.Count > 0)
            {
                DataGridViewRow row = DgvCustomer.SelectedRows[0];
                string customerCode = row.Cells["ClustomerCode"].Value?.ToString();

                if (!string.IsNullOrWhiteSpace(customerCode))
                {
                    DialogResult result = MessageBox.Show(
                        $"¿Seguro que deseas dar de baja al cliente {customerCode}?",
                        "Confirmar baja",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            DeleteCommand deleteService = new DeleteCommand();

                            // UPDATE en vez de DELETE
                            string query = "UPDATE Customer SET Available = 0 WHERE ClustomerCode = @ClustomerCode";
                            SqlParameter[] parameters =
                            {
                        new SqlParameter("@ClustomerCode", customerCode)
                    };

                            int rows = deleteService.ExecuteDelete(query, parameters);

                            if (rows > 0)
                            {
                                MessageBox.Show("Cliente dado de baja correctamente.");
                                LoadCustomers(); // refresca el grid
                            }
                            else
                            {
                                MessageBox.Show("No se encontró el cliente para dar de baja.");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error al dar de baja cliente: " + ex.Message);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("La fila seleccionada no tiene un código válido.");
                }
            }
            else
            {
                MessageBox.Show("Seleccione una fila completa para dar de baja.");
            }
        }
        /* ------------------- RECARGAR CLIENTES ------------------- */
        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            LoadCustomers(); // recarga el grid para mostrar cambios
        }
        /* ------------------- VALIDAR CÓDIGO ------------------- */
        private bool validateCode (string codigo)
        {
            return Regex.IsMatch(codigo, @"^CLI\d{3}$");
        }
        /* ------------------- BUSCAR CLIENTE POR CÓDIGO ------------------- */

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            string codigo = TxtSearch.Text.Trim();

            // Validar formato CLI###
            if (!validateCode(codigo))
            {
                MessageBox.Show("El código debe tener el formato CLI### (ejemplo: CLI876).");
                return;
            }

            try
            {
                CustomerBusiness business = new CustomerBusiness();
                DataTable dt = business.SearchCustomerByCode(codigo);

                DgvCustomer.DataSource = null;
                DgvCustomer.Rows.Clear();
                DgvCustomer.DataSource = dt;

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No se encontró un cliente con ese código.");
                }
                else
                {
                    ConfigurarModoLectura(false); // habilita edición en Nombre y Teléfono
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar cliente: " + ex.Message);
            }

            TxtSearch.Clear(); // limpiar textbox después de buscar

        }
        private void ConfigurarModoLectura(bool soloLectura)
        {
            foreach (DataGridViewColumn col in DgvCustomer.Columns)
            {
                col.ReadOnly = true; // todas bloqueadas
            }

            if (!soloLectura)
            {
                // habilitar edición solo en Nombre y Teléfono
                DgvCustomer.Columns["Names"].ReadOnly = false;
                DgvCustomer.Columns["Phone"].ReadOnly = false;
                DgvCustomer.Columns["TypeCustomer"].ReadOnly = false; // también el tipo de cliente
                DgvCustomer.Columns["Available"].ReadOnly = false; // y el estado de disponibilidad
            }
        }

    }

}



