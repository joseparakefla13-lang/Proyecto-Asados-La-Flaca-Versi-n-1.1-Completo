using Microsoft.Data.SqlClient;
using Proyecto_Asados_La_Flaca_Versión_1._1_Completo.Domain;
using Proyecto_Asados_La_Flaca_Versión_1._1_Completo.Services;
using Proyecto_Asados_La_Flaca_Versión_1._1_Completo.Services.BusinessLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Proyecto_Asados_La_Flaca_Versión_1._1_Completo.Catalogs
{
    public partial class FrmEmployee : Form
    {
        private readonly string connectionString = "Server=COQUETO;Database=Dev_Asado2.sql;Integrated Security=True;TrustServerCertificate=True;Encrypt=False;";

        public FrmEmployee()
        {
            InitializeComponent();
            // Configuración inicial del DataGridView//
            DtgEmployee.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // selecciona fila completa//
            DtgEmployee.MultiSelect = false; DtgEmployee.MultiSelect = false; // solo permite seleccionar una fila//
            LoadPositionType();// carga tipos de cliente en el combo//
            this.AutoValidate = AutoValidate.EnablePreventFocusChange;// activa validaciones automáticas//
        }
        private void LoadPositionType()
        {
            try
            {
                EmployeeTypeBusiness business = new EmployeeTypeBusiness();
                DataTable dt = business.GetPosition();

                if (dt.Rows.Count > 0)
                {
                    // Verificamos el nombre real de la columna
                    string columnName = dt.Columns[0].ColumnName;

                    CbPosition.DataSource = dt;
                    CbPosition.DisplayMember = columnName;   // lo que se muestra
                    CbPosition.ValueMember = columnName;     // lo que se guarda
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar tipos de cliente: {ex.Message}");
            }
        }

        private void LoadEmployee()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"SELECT EmployeeCode, Names, SurNames, Phone, Position, Available
                             FROM Employee
                             WHERE Available = 1";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    DtgEmployee.AutoGenerateColumns = false;
                    DtgEmployee.DataSource = null;
                    DtgEmployee.Rows.Clear();
                    DtgEmployee.DataSource = dt;

                    DtgEmployee.Columns.Clear();

                    DtgEmployee.Columns.Add(new DataGridViewTextBoxColumn
                    {
                        Name = "EmployeeCode",
                        DataPropertyName = "EmployeeCode",
                        HeaderText = "Código"
                    });
                    DtgEmployee.Columns.Add(new DataGridViewTextBoxColumn
                    {
                        Name = "Names",
                        DataPropertyName = "Names",
                        HeaderText = "Nombre"
                    });
                    DtgEmployee.Columns.Add(new DataGridViewTextBoxColumn
                    {
                        Name = "SurNames",
                        DataPropertyName = "SurNames",
                        HeaderText = "Apellidos"
                    });
                    DtgEmployee.Columns.Add(new DataGridViewTextBoxColumn
                    {
                        Name = "Position",
                        DataPropertyName = "Position",
                        HeaderText = "Puesto"
                    });
                    DtgEmployee.Columns.Add(new DataGridViewTextBoxColumn
                    {
                        Name = "Phone",
                        DataPropertyName = "Phone",
                        HeaderText = "Teléfono"
                    });
                    DtgEmployee.Columns.Add(new DataGridViewCheckBoxColumn
                    {
                        Name = "Available",
                        DataPropertyName = "Available",
                        HeaderText = "Activo"
                    });

                    DtgEmployee.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar Empleados: " + ex.Message);
            }
        }



        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                EmployeeBusiness business = new EmployeeBusiness();

                // Instancias locales
                string codigo = TxtCode.Text.Trim();   // aquí ya puede venir de Buscar
                string nombre = TxtName.Text.Trim();
                string apellidos = TxtSurname.Text.Trim();
                string telefono = TxtPhone.Text.Trim();
                string puesto = CbPosition.Text;
                bool activo = CbAvailable.Checked;

                // Validaciones básicas
                if (string.IsNullOrEmpty(nombre))
                {
                    MessageBox.Show("Debe ingresar un nombre.");
                    return;
                }
                if (string.IsNullOrEmpty(apellidos))
                {
                    MessageBox.Show("Debe ingresar apellidos.");
                    return;
                }
                if (string.IsNullOrEmpty(puesto))
                {
                    MessageBox.Show("Debe seleccionar un puesto laboral.");
                    return;
                }
                if (string.IsNullOrEmpty(telefono))
                {
                    MessageBox.Show("Debe ingresar un número de teléfono.");
                    return;
                }
                if (!activo)
                {
                    MessageBox.Show("Debe marcar el estado Activo para poder guardar el empleado.");
                    return;
                }

                // Crear instancia de Employee
                Employee emp = new Employee
                {
                    EmployeeCode = codigo,
                    Names = nombre,
                    SurNames = apellidos,
                    Phone = telefono,
                    Position = puesto,
                    Available = activo
                };

                int rows;
                if (string.IsNullOrEmpty(codigo)) // si no hay código, es nuevo
                {
                    string nextCode = business.GetNextEmployeeCode();
                    emp.EmployeeCode = nextCode;
                    rows = business.InsertEmployee(emp);

                    if (rows > 0)
                        MessageBox.Show($"Empleado agregado correctamente con código {nextCode}.");
                    else
                        MessageBox.Show("No se pudo agregar el empleado.");
                }
                else // si ya hay código, actualizar
                {
                    rows = business.UpdateEmployee(emp);

                    if (rows > 0)
                        MessageBox.Show("Empleado actualizado correctamente.");
                    else
                        MessageBox.Show("No se pudo actualizar el empleado.");
                }

                LoadEmployee(); // refresca el DataGridView
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar empleado: {ex.Message}");
            }
        }



        private void BtnSearch_Click(object sender, EventArgs e)
        {

            EmployeeBusiness business = new EmployeeBusiness();
            string codigo = TxtSearch.Text.Trim().ToUpper();

            DataTable dt = business.SearchEmployeeByCode(codigo);

            if (dt.Rows.Count > 0)
            {
                TxtCode.Text = dt.Rows[0]["EmployeeCode"].ToString();
                TxtName.Text = dt.Rows[0]["Names"].ToString();
                TxtSurname.Text = dt.Rows[0]["SurNames"].ToString();
                TxtPhone.Text = dt.Rows[0]["Phone"].ToString();
                CbPosition.Text = dt.Rows[0]["Position"].ToString();
                CbAvailable.Checked = Convert.ToBoolean(dt.Rows[0]["Available"]);

                TxtCode.ReadOnly = true;   // se muestra pero no se puede editar

                // habilitar edición
                TxtName.Enabled = true;
                TxtSurname.Enabled = true;
                TxtPhone.Enabled = true;
                CbPosition.Enabled = true;
                CbAvailable.Enabled = true;

                TxtSearch.Clear(); // también limpiar si no encuentra

                // Mostrar también en el DataGridView solo el resultado de la búsqueda
                DtgEmployee.AutoGenerateColumns = false;
                DtgEmployee.DataSource = dt;

                MessageBox.Show("Empleado encontrado. Puede editar los campos.");
            }
            else
            {
                MessageBox.Show("No se encontró el empleado con ese código.");
                TxtSearch.Clear(); // también limpiar si no encuentra
            }
        }

        private void TxtCode_Validating(object sender, CancelEventArgs e)
        {
            string input = TxtCode.Text.Trim().ToUpper();

            Regex regex = new Regex(@"^EMP\d{3}$");

            if (!regex.IsMatch(input))
            {
                LbErrorCode.Text = "Formato inválido. Use EMP###";
                LbErrorCode.Visible = true;
                // e.Cancel = true;  <-- quítalo para no bloquear el foco
            }
            else
            {
                LbErrorCode.Visible = false;
            }
        }
        private void ConfigurarModoLectura(bool soloLectura)
        {

            // Bloquear todas las columnas del DataGridView
            foreach (DataGridViewColumn col in DtgEmployee.Columns)
            {
                col.ReadOnly = true;
            }

            // Bloquear o habilitar también los TextBox y combos
            TxtCode.ReadOnly = true; // siempre bloqueado
            TxtName.Enabled = !soloLectura;
            TxtSurname.Enabled = !soloLectura;
            TxtPhone.Enabled = !soloLectura;
            CbPosition.Enabled = !soloLectura;
            CbAvailable.Enabled = !soloLectura;
        }

        private void FrmEmployee_Load(object sender, EventArgs e)
        {
            LoadEmployee(); // carga al abrir el formulario
            DtgEmployee.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DtgEmployee.MultiSelect = false;
            DtgEmployee.AllowUserToAddRows = false; // evita fila vacía extra
            ConfigurarModoLectura(true); // por defecto solo lectura
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {

            if (DtgEmployee.SelectedRows.Count > 0)
            {
                DataGridViewRow row = DtgEmployee.SelectedRows[0];
                string employeeCode = row.Cells["EmployeeCode"].Value?.ToString();

                if (!string.IsNullOrWhiteSpace(employeeCode))
                {
                    DialogResult result = MessageBox.Show(
                        $"¿Seguro que deseas dar de baja al empleado {employeeCode}?",
                        "Confirmar baja",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            DeleteCommand deleteService = new DeleteCommand();

                            // Baja lógica: Available = 0
                            string query = "UPDATE Employee SET Available = 0 WHERE EmployeeCode = @EmployeeCode";
                            SqlParameter[] parameters =
                            {
                        new SqlParameter("@EmployeeCode", employeeCode)
                    };

                            int rows = deleteService.ExecuteDelete(query, parameters);

                            if (rows > 0)
                            {
                                MessageBox.Show("Empleado dado de baja correctamente.");
                                LoadEmployee(); // refresca el DataGridView
                            }
                            else
                            {
                                MessageBox.Show("No se encontró el empleado para dar de baja.");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error al dar de baja empleado: " + ex.Message);
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



        private void TxtPhone_Validating(object sender, CancelEventArgs e)
        {
            string input = TxtPhone.Text.Trim();

            // Validar que sean solo números
            if (!System.Text.RegularExpressions.Regex.IsMatch(input, @"^\d*$"))
            {
                LblErrorPhone.Visible = true;
                return;
            }

            // Validar longitud
            if (input.Length == 8)
            {
                LblErrorPhone.Visible = false; // correcto, ocultar error
            }
            else
            {
                LblErrorPhone.Text = "El teléfono debe tener exactamente 8 dígitos.";
                LblErrorPhone.Visible = true;
            }
        }

        private void TxtPhone_TextChanged(object sender, EventArgs e)
        {

            string input = TxtPhone.Text.Trim();

            // Si no hay nada, ocultar el label
            if (string.IsNullOrEmpty(input))
            {
                LblErrorPhone.Visible = false;
                return;
            }

            // Validar que sean solo números
            if (!System.Text.RegularExpressions.Regex.IsMatch(input, @"^\d*$"))
            {
                LblErrorPhone.Text = "Solo se permiten números.";
                LblErrorPhone.Visible = true;
                return;
            }

            // Validar longitud
            if (input.Length == 8)
            {
                LblErrorPhone.Visible = false; // correcto, ocultar error
            }
            else
            {
                LblErrorPhone.Text = "El teléfono debe tener exactamente 8 dígitos.";
                LblErrorPhone.Visible = true;
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            LoadEmployee(); // recarga el DataGridView para mostrar los cambios
        }
    }
}

