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
    public partial class ConvertirMXNa : Form
    {
        public ConvertirMXNa()
        {
            InitializeComponent();

        }
        WSConvertidor.ConversorMonedaSoapClient servicio = new WSConvertidor.ConversorMonedaSoapClient();


        private void btn_USD_Click(object sender, EventArgs e)
        {
            var res = servicio.MXN_USD(int.Parse(txtMXN.Text));
            txt_Res.Text = res.ToString();
            lblPrefijo.Text = "USD";
        }

        private void btn_COP_Click(object sender, EventArgs e)
        {
            var res = servicio.MXN_COP(int.Parse(txtMXN.Text));
            txt_Res.Text = res.ToString();
            lblPrefijo.Text = "COP";
        }

        private void btn_EUR_Click(object sender, EventArgs e)
        {
            var res = servicio.MXN_EUR(int.Parse(txtMXN.Text));
            txt_Res.Text = res.ToString();
            lblPrefijo.Text = "EUR";
        }

        private void txtMXN_MouseMove(object sender, MouseEventArgs e)
        {
            ingresarMXN.SetToolTip(txtMXN, "Ingresa la cantidad en pesos mexicanos");

        }
    }
}
