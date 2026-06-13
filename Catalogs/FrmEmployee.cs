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

                string codigo = TxtCode.Text.Trim();
                string nombre = TxtName.Text.Trim();
                string apellidos = TxtSurname.Text.Trim();
                string telefono = TxtPhone.Text.Trim();
                string puesto = CbPosition.Text;
                bool activo = CbAvailable.Checked;

                // Validaciones
                if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(apellidos) ||
                    string.IsNullOrEmpty(puesto) || string.IsNullOrEmpty(telefono))
                {
                    MessageBox.Show("Debe completar todos los campos.");
                    return;
                }

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

                // 🔹 Si el código ya existe en la BD → UPDATE
                DataTable dt = business.SearchEmployeeByCode(codigo);
                if (dt.Rows.Count > 0)
                {
                    rows = business.UpdateEmployee(emp);
                    if (rows > 0)
                        MessageBox.Show($"Empleado {codigo} actualizado correctamente.");
                }
                else
                {
                    // 🔹 Si no existe → INSERT
                    rows = business.InsertEmployee(emp);
                    if (rows > 0)
                        MessageBox.Show($"Empleado agregado correctamente con código {codigo}.");
                }

                // Limpiar campos después de guardar/actualizar
                TxtName.Clear();
                TxtSurname.Clear();
                TxtPhone.Clear();
                CbPosition.SelectedIndex = -1;
                CbAvailable.Checked = false;

                // Generar y mostrar el próximo código automáticamente
                TxtCode.Text = business.GetNextEmployeeCode();

                // Refrescar el DataGridView
                LoadEmployee();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar/actualizar empleado: {ex.Message}");
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
        private void ConfigurarModoLectura()
        {
            // Bloquear todas las columnas del DataGridView (siempre lectura)
            foreach (DataGridViewColumn col in DtgEmployee.Columns)
            {
                col.ReadOnly = true;
            }

            // El código siempre bloqueado (se genera automático)
            TxtCode.ReadOnly = true;

            // Los demás campos SIEMPRE habilitados para agregar
            TxtName.Enabled = true;
            TxtSurname.Enabled = true;
            TxtPhone.Enabled = true;
            CbPosition.Enabled = true;
            CbAvailable.Enabled = true;
        }


        private void FrmEmployee_Load(object sender, EventArgs e)
        {
            EmployeeBusiness business = new EmployeeBusiness();

            // Mostrar el próximo código disponible al abrir
            TxtCode.Text = business.GetNextEmployeeCode();
            TxtCode.ReadOnly = true; // el usuario no lo edita

            // Configuración del DataGridView (solo lectura)
            LoadEmployee();
            DtgEmployee.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DtgEmployee.MultiSelect = false;
            DtgEmployee.AllowUserToAddRows = false;

            // Limpiar valores iniciales de los demás campos
            TxtName.Clear();
            TxtSurname.Clear();
            TxtPhone.Clear();
            CbPosition.SelectedIndex = -1;
            CbAvailable.Checked = false;

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

        private void BtnSearch_Click_1(object sender, EventArgs e)
        {

            string codigo = TxtSearch.Text.Trim();

            // Validar formato EMP###
            if (!Regex.IsMatch(codigo, @"^EMP\d{3}$"))
            {
                MessageBox.Show("El código debe tener el formato EMP### (ejemplo: EMP001).");
                return;
            }

            try
            {
                EmployeeBusiness business = new EmployeeBusiness();
                DataTable dt = business.SearchEmployeeByCode(codigo);

                DtgEmployee.DataSource = null;
                DtgEmployee.Rows.Clear();
                DtgEmployee.DataSource = dt;

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No se encontró un empleado con ese código.");
                }
                else
                {
                    // Cargar datos en los TextBox para edición
                    DataRow row = dt.Rows[0];
                    TxtCode.Text = row["EmployeeCode"].ToString();
                    TxtName.Text = row["Names"].ToString();
                    TxtSurname.Text = row["SurNames"].ToString();
                    TxtPhone.Text = row["Phone"].ToString();
                    CbPosition.Text = row["Position"].ToString();
                    CbAvailable.Checked = Convert.ToBoolean(row["Available"]);

                    // Habilitar edición en los campos
                    TxtName.Enabled = true;
                    TxtSurname.Enabled = true;
                    TxtPhone.Enabled = true;
                    CbPosition.Enabled = true;
                    CbAvailable.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar empleado: " + ex.Message);
            }

            TxtSearch.Clear(); // limpiar textbox después de buscar
        }

    }
}


