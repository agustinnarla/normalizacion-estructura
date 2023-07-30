using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prySituacion3
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        clsProvincias objProv;
        clsDepartamentos objDepa;
        clsIncendios objIncendio;
        clsTipodeIncandios objTipo;

        int varContador;
        int varTotal;
        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            objProv = new clsProvincias();
            objDepa = new clsDepartamentos();
            objIncendio = new clsIncendios();
            objTipo = new clsTipodeIncandios();
             
            tvArbolito.ImageList = Fotitos;

            TreeNode nodo1 = new TreeNode("Incendios", 0, 2);
            tvArbolito.Nodes.Add(nodo1);

            DataTable dtProvincias = objProv.getAll();
            DataTable dtDepartamentos = objDepa.getAll();

            foreach (DataRow filaP in dtProvincias.Rows)
            {
                TreeNode nodo2 = new TreeNode(filaP["nombre"].ToString(), 1, 1);

                tvArbolito.Nodes[0].Nodes.Add(nodo2);
               

                foreach (DataRow filaD in dtDepartamentos.Rows)
                {
                    if ((int)filaP["Provincia"] == (int)filaD["Provincia"])
                    {
                        TreeNode nodo3 = new TreeNode(filaD["nombre"].ToString(), 1, 1);
                        nodo2.Nodes.Add(nodo3);
                    }

                }

            }

        }

        private void tvArbolito_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void tvArbolito_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {

        }

        private void tvArbolito_AfterSelect(object sender, TreeViewEventArgs e)
        {

            int Total;
            // determinar el nivel del nodo seleccionado
            TreeNode nodo = e.Node;
            switch (nodo.Level)
            {
                case 0: // es el nodo raiz
                    Total = objIncendio.ObtenerIncendios(lstCantidad);
                    stDatos.Items["lblTotal"].Text = Total.ToString();
                    break;

                case 1: // es un nodo de Provincia
                    Total = objIncendio.ObtenerIncendiosPorProvincia(int.Parse(nodo.Name), lstCantidad);
                    stDatos.Items["lblTotal"].Text = "Provincia " + nodo.Text + ": " + Total.ToString();
                    break;

                case 2: // es un nodo de Departamento
                    Total = objIncendio.ObtenerIncendiosPorDepartamento(int.Parse(nodo.Name), lstCantidad);
                    stDatos.Items["lblTotal"].Text = "Departamento " + nodo.Text + ": " + Total.ToString();
                    break;
            }

        }
    }
}
