using Proyecto_Asados_La_Flaca_Versión_1._1_Completo.Domain;
using Proyecto_Asados_La_Flaca_Versión_1._1_Completo.Services.BusinessLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

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

                // Generar código automático
                string nextCode = business.GetNextEmployeeCode();

                // Instancias locales (variables) con los valores de los controles
                string nombre = TxtName.Text.Trim();
                string apellidos = TxtSurname.Text.Trim();
                string telefono = TxtPhone.Text.Trim();
                string puesto = CbPosition.Text;   // valor seleccionado en el ComboBox
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

                if (!business.IsUniquePhone(telefono))
                {
                    MessageBox.Show("El número de teléfono ya está registrado.");
                    return;
                }

                if (!activo)
                {
                    MessageBox.Show("Debe marcar el estado Activo para poder guardar el empleado.");
                    return;
                }

                // Crear instancia de Employee con las variables locales
                Employee nuevo = new Employee
                {
                    EmployeeCode = nextCode,
                    Names = nombre,
                    SurNames = apellidos,
                    Phone = telefono,
                    Position = puesto,
                    Available = activo
                };

                // Guardar en BD
                int rows = business.InsertEmployee(nuevo);

                if (rows > 0)
                {
                    MessageBox.Show($"Empleado agregado correctamente con código {nextCode}.");
                    LoadEmployee(); // refresca el DataGridView
                }
                else
                {
                    MessageBox.Show("No se pudo agregar el empleado.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar empleado: {ex.Message}");
            }
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            string codigo = TxtSearch.Text.Trim();

            if (!codigo.StartsWith("EMP"))
            {
                MessageBox.Show("El código debe tener el formato EMP### (ejemplo: EMP001).");
                return;
            }

            EmployeeBusiness business = new EmployeeBusiness();
            DataTable dt = business.SearchEmployeeByCode(codigo);

            DtgEmployee.DataSource = null;
            DtgEmployee.Rows.Clear();
            DtgEmployee.DataSource = dt;

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("No se encontró un empleado con ese código.");
            }
        }

        private void TxtCode_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtPhone.Text))
            {
                LbErrorCode.Visible = true;
                e.Cancel = true;
            }
            else
            {
                LbErrorCode.Visible = false;
            }
        }
        private void ConfigurarModoLectura(bool soloLectura)
        {
            foreach (DataGridViewColumn col in DtgEmployee.Columns)
            {
                col.ReadOnly = true; // todas bloqueadas
            }

            if (!soloLectura)
            {
                // habilitar edición solo en Nombre y Teléfono
                DtgEmployee.Columns["Names"].ReadOnly = false;
                DtgEmployee.Columns["SurNames"].ReadOnly = false; // también apellidos
                DtgEmployee.Columns["Phone"].ReadOnly = false;
                DtgEmployee.Columns["Position"].ReadOnly = false; // también el tipo de cliente
                DtgEmployee.Columns["Available"].ReadOnly = false; // y el estado de disponibilidad
            }
        }
        private void FrmEmployee_Load(object sender, EventArgs e)
        {
            LoadEmployee(); // carga al abrir el formulario
            DtgEmployee.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DtgEmployee.MultiSelect = false;
            DtgEmployee.AllowUserToAddRows = false; // evita fila vacía extra
            ConfigurarModoLectura(true); // por defecto solo lectura
        }
    }
}
