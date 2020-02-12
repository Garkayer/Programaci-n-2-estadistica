using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programación_2_estadistica
{
    public partial class Form1 : Form
    {
        estadistica objEstadistica = new estadistica();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMediaAritmetica_Click(object sender, EventArgs e)
        {
            //split => divide una cadena en base a un delimitador (patron) y devuelve una matriz
            lblRespuesta.Text = "X=" + objEstadistica.media(txtSerie.Text.Split(','));
        }

        private void btnCalcularMedia_Click(object sender, EventArgs e)
        {
            lblRespuesta.Text = "Tipica" + objEstadistica.tipica(txtSerie.Text.Split(','));
        }

        private void btnCalcularEstandar_Click(object sender, EventArgs e)
        {
            lblRespuesta.Text = "Estandar" + objEstadistica.estandar(txtSerie.Text.Split(','));
        }
    }
}
