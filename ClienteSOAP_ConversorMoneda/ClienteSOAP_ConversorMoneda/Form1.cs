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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_mxn_Click(object sender, EventArgs e)
        {
            ConvertirMXNa MXN = new ConvertirMXNa();
            MXN.Show();            
        }

        private void lbl_mxn_Click(object sender, EventArgs e)
        {
            ConvertirMXNa MXN = new ConvertirMXNa();
            MXN.Show();
        }

        private void btn_usd_Click(object sender, EventArgs e)
        {
            ConvertirUSDa USD = new ConvertirUSDa();
            USD.Show();
        }

        private void lbl_usd_Click(object sender, EventArgs e)
        {
            ConvertirUSDa USD = new ConvertirUSDa();
            USD.Show();
        }

        private void btn_cop_Click(object sender, EventArgs e)
        {
            ConvertirCOPa COP = new ConvertirCOPa();
            COP.Show();
        }

        private void lbl_cop_Click(object sender, EventArgs e)
        {
            ConvertirCOPa COP = new ConvertirCOPa();
            COP.Show();
        }

        private void btn_eur_Click(object sender, EventArgs e)
        {
            ConvertirEURa EUR = new ConvertirEURa();
            EUR.Show();
        }

        private void lbl_eur_Click(object sender, EventArgs e)
        {
            ConvertirEURa EUR = new ConvertirEURa();
            EUR.Show();
        }
    }
}
