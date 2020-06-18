using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoVectores
{
    public partial class frmNumeroLetras : Form
    {
        public frmNumeroLetras()
        {
            InitializeComponent();
        }

        private void txtNumero_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (int.TryParse(this.txtNumero.Text, out int num))
                {
                    this.txtResultado.Text = clases.NumLetras.getLetras(num);
                    this.txtNumero.Text = "";
                }
            }
        }

        private void txtNumero_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(this.txtNumero.Text, out Int32 num))
            {
                String x = clases.NumLetras.NumeroaLetras(num);
                this.txtResultado.Text = x.ToString();

            }
        }
    }
}
