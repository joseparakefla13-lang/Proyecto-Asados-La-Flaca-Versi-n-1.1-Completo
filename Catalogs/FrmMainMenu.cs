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
            // Limpiar todo lo que haya en el panel dinámico
            PnlSubMenuSystems.Controls.Clear();

            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;

            PnlSubMenuSystems.Controls.Add(formulario);
            formulario.Show(); ;
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();

           FrmLogin frmLogin = new FrmLogin();
            frmLogin.Show(); ;
        }
    }
}
