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
    public partial class ConvertirEURa : Form
    {
        public ConvertirEURa()
        {
            InitializeComponent();
        }
        WSConvertidor.ConversorMonedaSoapClient servicio = new WSConvertidor.ConversorMonedaSoapClient();


        private void btn_MXN_Click(object sender, EventArgs e)
        {
            var res = servicio.EUR_MXN(int.Parse(txtEUR.Text));
            txt_Res.Text = res.ToString();
            lblPrefijo.Text = "MXN";
        }

        private void btn_USD_Click(object sender, EventArgs e)
        {
            var res = servicio.EUR_USD(int.Parse(txtEUR.Text));
            txt_Res.Text = res.ToString();
            lblPrefijo.Text = "USD";
        }

        private void btn_COP_Click(object sender, EventArgs e)
        {
            var res = servicio.EUR_COP(int.Parse(txtEUR.Text));
            txt_Res.Text = res.ToString();
            lblPrefijo.Text = "COP";
        }

        private void txtEUR_MouseMove(object sender, MouseEventArgs e)
        {
            ingresarEUR.SetToolTip(txtEUR, "Ingresa la cantidad en euros");

        }
    }
}
