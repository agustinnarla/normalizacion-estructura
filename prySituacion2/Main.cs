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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        clsActividades objActividades = new clsActividades();
        int varActividad;
        private void cmdAgregar_Click(object sender, EventArgs e)
        {
            frmActividades frmActividades = new frmActividades();
            frmActividades.Show();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            DataTable tabla = objActividades.getAll();

            
            foreach (DataRow filadatos in tabla.Rows)
            {
                grlDatos.Rows.Add(filadatos["Asunto"], filadatos["Fecha"], filadatos["Observacion"]);
            }
        }

        private void grlDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmdEliminar_Click(object sender, EventArgs e)
        {
           
        }

        private void grlDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
    }
}
