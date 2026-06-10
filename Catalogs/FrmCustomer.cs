using Proyecto_Asados_La_Flaca_Versión_1._1_Completo.Domain;
using Proyecto_Asados_La_Flaca_Versión_1._1_Completo.Services.BusinessLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace Proyecto_Asados_La_Flaca_Versión_1._1_Completo.Catalogs
{
    public partial class FrmCustomer : Form
    {
        public FrmCustomer()
        {
            InitializeComponent();
            this.AutoValidate = AutoValidate.EnablePreventFocusChange;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void DtmFecha_ValueChanged(object sender, EventArgs e)
        {

        }

        private void BtnSaveClient_Click(object sender, EventArgs e)
        {
            // Validar campos obligatorios
            if (string.IsNullOrWhiteSpace(TxtCustomerCode.Text) ||
                string.IsNullOrWhiteSpace(TxtName.Text) ||
                string.IsNullOrWhiteSpace(TxtPhone.Text) ||
                string.IsNullOrWhiteSpace(TxtTypeOfCustomer.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos faltantes.", "Campos Incompletos",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Crear instancia de cliente con todos los datos
                Customer newCustomer = new Customer
                {
                    CustomerCode = TxtCustomerCode.Text.Trim(),
                    Name = TxtName.Text.Trim(),
                    Phone = TxtPhone.Text.Trim(),
                    TypeOfCustomer = TxtTypeOfCustomer.Text.Trim(),
                    IsEnable = ChbStateCustomer.Checked, // checkbox de tu formulario
                    RegisterDate = DtmRegistrationDate.Value // fecha del DateTimePicker
                };

                CustomerBusiness customerBusiness = new CustomerBusiness();
                int result = customerBusiness.InsertCustomer(newCustomer);

                if (result > 0)
                {
                    MessageBox.Show("El nuevo Cliente fue registrado exitosamente.", "Operación Exitosa",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // clearInputs(); // limpiar campos si lo deseas
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al registrar el Cliente: {ex.Message}", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void FrmCustomer_Load(object sender, EventArgs e)
        {

        }



        private void TxtCustomerCode_Validating(object sender, CancelEventArgs e)
        {
            string input = TxtCustomerCode.Text.Trim().ToUpper(); // normalizar a mayúsculas

            // Formato: CL seguido de 3 dígitos
            Regex regex = new Regex(@"^CL\d{3}$");

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
