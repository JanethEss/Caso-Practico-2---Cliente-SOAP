using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClienteSOAP_ConversorMoneda
{
    public partial class ConvertirCOPa : Form
    {
        public ConvertirCOPa()
        {
            InitializeComponent();
        }
        WSConvertidor.ConversorMonedaSoapClient servicio = new WSConvertidor.ConversorMonedaSoapClient();

        private void btn_MXN_Click(object sender, EventArgs e)
        {
            var res = servicio.COP_MXN(int.Parse(txtCOP.Text));
            txt_Res.Text = res.ToString();
            lblPrefijo.Text = "MXN";
        }

        private void btn_USD_Click(object sender, EventArgs e)
        {
            var res = servicio.COP_USD(int.Parse(txtCOP.Text));
            txt_Res.Text = res.ToString();
            lblPrefijo.Text = "USD";
        }

        private void btn_EUR_Click(object sender, EventArgs e)
        {
            var res = servicio.COP_EUR(int.Parse(txtCOP.Text));
            txt_Res.Text = res.ToString();
            lblPrefijo.Text = "EUR";
        }

        private void txtCOP_MouseHover(object sender, EventArgs e)
        {
            IngresarCOP.SetToolTip(txtCOP, "Ingresa la cantidad en pesos colombianos");

        }
    }
}
