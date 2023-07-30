using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prySituacion4
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        clsLocalidad objLocalidad;
        clsCultivos objCultivos;
        clsProduccion objProduccion;
        private void frmMain_Load(object sender, EventArgs e)
        {
            objLocalidad = new clsLocalidad();
            objCultivos = new clsCultivos();
            objProduccion = new clsProduccion();


            objLocalidad.llenar(lstLocalidad);
            DataTable dtCultivos = objCultivos.getAll();

            foreach (DataRow filaCultivo in dtCultivos.Rows)
            {
                lstCultivos.Items.Add(filaCultivo["Nombre"]);
            }
        }

        private void cmdActualizar_Click(object sender, EventArgs e)
        {
            try
            {

                int localidad = (int)lstLocalidad.SelectedValue;
                int cultivo = (int)lstCultivos.SelectedValue;
                long produccion = long.Parse(txtToneladas.Text);
                objProduccion.actualizar(localidad, cultivo, (int)produccion);

            }
           
            catch (Exception ex)
            {
                MessageBox.Show("INGRESE NUMEROS EN TONELADAS ...", "ERROR");
            }
        }

        private void cmdVer_Click(object sender, EventArgs e)
        {
            frmGrafico objGrafico = new frmGrafico();
            objGrafico.Show();
        }
    }
}

