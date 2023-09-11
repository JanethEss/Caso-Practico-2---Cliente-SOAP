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
    public partial class ConvertirUSDa : Form
    {
        public ConvertirUSDa()
        {
            InitializeComponent();
        }
        WSConvertidor.ConversorMonedaSoapClient servicio = new WSConvertidor.ConversorMonedaSoapClient();


        private void btn_MXN_Click(object sender, EventArgs e)
        {
            var res = servicio.USD_MXN(int.Parse(txtUSD.Text));
            txt_Res.Text = res.ToString();
            lblPrefijo.Text = "MXN";
        }

        private void btn_COP_Click(object sender, EventArgs e)
        {
            var res = servicio.USD_COP(int.Parse(txtUSD.Text));
            txt_Res.Text = res.ToString();
            lblPrefijo.Text = "COP";
        }

        private void btn_EUR_Click(object sender, EventArgs e)
        {
            var res = servicio.USD_EUR(int.Parse(txtUSD.Text));
            txt_Res.Text = res.ToString();
            lblPrefijo.Text = "EUR";
        }

        private void txtUSD_MouseMove(object sender, MouseEventArgs e)
        {
            ingresarUSD.SetToolTip(txtUSD, "Ingresa la cantidad en dolares");
        }
    }
}
