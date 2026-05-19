using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Proyecto_Asados_La_Flaca_Versión_1._1_Completo.Catalogs
{
    public partial class FrmMainMenu : Form
    {
        public FrmMainMenu()
        {
            InitializeComponent();
        }

        private void BtnOrder_Click(object sender, EventArgs e)
        {
            OpenFrm(new FrmOrder());
        }
        public void OpenFrm(Form formulario)
        {
            // Limpiar panel antes de cargar nuevo formulario
            PnlSubMenuSystems.Controls.Clear();

            // Configuración del formulario embebido
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill; // Se ajusta automáticamente al panel

            // Agregar al panel
            PnlSubMenuSystems.Controls.Add(formulario);
            PnlSubMenuSystems.Tag = formulario;
            formulario.Show();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();

            FrmLogin frmLogin = new FrmLogin();
            frmLogin.Show(); ;
        }

        private void BtnInventory_Click(object sender, EventArgs e)
        {
            OpenFrm(new FrmInventory());
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            OpenFrm(new FrmStart());
        }

        private void BtnBilling_Click(object sender, EventArgs e)
        {
            OpenFrm(new FrmBilling());
        }

        private void BtnProducts_Click(object sender, EventArgs e)
        {
            OpenFrm(new FrmProducts());
        }
    }
}
