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

        public void OpenFrm(Form formulario)
        {
            // Limpiar panel antes de cargar nuevo formulario
            PnlMainContainer.Controls.Clear();

            // Configuración del formulario embebido
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill; // Se ajusta automáticamente al panel

            // Agregar al panel
            PnlMainContainer.Controls.Add(formulario);
            PnlMainContainer.Tag = formulario;
            formulario.Show();
        }

        private void BtnEmployee_Click(object sender, EventArgs e)
        {
            OpenFrm(new FrmEmployee());
        }
    }
}
