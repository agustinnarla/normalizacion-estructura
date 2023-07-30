using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prySituacion2
{
    public partial class frmActividades : Form
    {
        public frmActividades()
        {
            InitializeComponent();
        }
        clsActividades objActividad;

        private void cmdAceptar_Click(object sender, EventArgs e)
        {
            try
            {

                objActividad.Nombre = txtActividad.Text;
                objActividad.Obser = txtObservacion.Text;
                objActividad.Fecha = dtpFecha.Value;

                objActividad.agregar();

                MessageBox.Show("Datos Cargados");

            }
            catch (Exception ex)
            {
                MessageBox.Show("INGRESE BIEN LOS DATOS MAN ...", "ERROR");
            }
        }

        private void frmActividades_Load(object sender, EventArgs e)
        {
            objActividad = new clsActividades();
        }

        private void cmdConsultar_Click(object sender, EventArgs e)
        {
            clsActividades objActiv = new clsActividades();
            DataTable dtFila = objActiv.getAll();

            foreach (DataRow fila in dtFila.Rows)
            {
                if (fila["asunto"].ToString() == txtActividad.Text)
                {
                    txtObservacion.Text = fila["observacion"].ToString();
                    dtpFecha.Text = fila["fecha"].ToString();
                }
            }
        }
    }
}
