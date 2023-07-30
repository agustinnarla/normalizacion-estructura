using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace prySituacion4
{
    public partial class frmGrafico : Form
    {
        public frmGrafico()
        {
            InitializeComponent();
        }
        clsLocalidad objLocalidad;
        clsCultivos objCultivos;
        clsProduccion objProdu;
        private void tabLocalidad_Click(object sender, EventArgs e)
        {
            
        }

        private void frmGrafico_Load(object sender, EventArgs e)
        {
            objLocalidad = new clsLocalidad();
            objCultivos = new clsCultivos();
            objProdu = new clsProduccion();
            objLocalidad.Completar(lstLocalidad);

            
        }

        private void cmdGraficar_Click(object sender, EventArgs e)
        {
            
            objProdu.graficar((int)lstLocalidad.SelectedValue, chartDatos);
        }

        private void cmdGraficar1_Click(object sender, EventArgs e)
        {
            objProdu.Graficar(chart1);
        }
    }
}
