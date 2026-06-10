using Proyecto_Asados_La_Flaca_Versión_1._1_Completo.Domain;
using Proyecto_Asados_La_Flaca_Versión_1._1_Completo.Services.BusinessLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Windows.Forms;
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace Proyecto_Asados_La_Flaca_Versión_1._1_Completo.Catalogs
{
    public partial class FrmCustomer : Form
    {
        public FrmCustomer()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void DtmFecha_ValueChanged(object sender, EventArgs e)
        {

        }

        private void BtnSaveClient_Click(object sender, EventArgs e)
        {
            string msg = string.Empty;

            //Validar que  los campos de Municipios no estén vacíos
            if (string.IsNullOrWhiteSpace(TxtCustomerCode.Text) ||
                string.IsNullOrWhiteSpace(TxtName.Text) ||
                string.IsNullOrWhiteSpace(TxtPhone.Text) ||
                string.IsNullOrWhiteSpace(TxtTypeOfCustomer.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos faltantes.", "Campos Incompletos",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Detener el proceso de registro si hay campos incompletos
            }

            // Si todo esta bien, se procede con el registro
            try
            {
                //Crear instancia para Cliente con los datos ingresados
                Customer newCustomer = new Customer
                {
                    CustomerCode = TxtCustomerCode.Text.Trim(),
                    Name = TxtName.Text.Trim(),
                    Phone = TxtPhone.Text.Trim(),
                    TypeOfCustomer = TxtTypeOfCustomer.Text.Trim()
                };

                CustomerBusiness customerBusiness = new CustomerBusiness(); //Inicializar sin parámetros
                int result = customerBusiness.InsertCustomer(newCustomer);

                //Validar el resultado del registro
                if (result > 0)
                {
                    MessageBox.Show("El nuevo Cliente fue registrado exitosamente.", "Operación Exitosa",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                // clearInputs(); // Limpiar los campos después del registro

            }
            catch (Exception logic)
            {
                MessageBox.Show($"Ocurrió un error al registrar el Cliente: {logic.Message}", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }//Endn try-catch

        }

        private void FrmCustomer_Load(object sender, EventArgs e)
        {
            CustomerBusiness customerBusiness = new CustomerBusiness();

            // Obtener los datos desde la BD
            DataTable dt = customerBusiness.ListCustomers();

            // Asignar al DataGridView
            DgvCustomer.DataSource = dt;
        }
    }
}
