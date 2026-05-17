using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Proyecto_Asados_La_Flaca_Versión_1._1_Completo.Catalogs
{
    public partial class FrmOrder : Form
    {
        public FrmOrder()
        {
            InitializeComponent();
        }

        private void BtnOrder_Click(object sender, EventArgs e)
        {
            FrmOrder orderDetailsForm = new FrmOrder();
            orderDetailsForm.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
