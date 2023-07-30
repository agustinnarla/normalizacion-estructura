using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prySituacion3
{
    internal class clsIncendios
    {
        private OleDbConnection conector;
        private OleDbCommand comando;
        private OleDbDataAdapter adaptador;
        private DataTable tabla;

        private OleDbConnection conector2;
        private OleDbCommand comando2;
        private OleDbDataAdapter adaptador2;
        private DataTable tabla2;
        DataSet DS;
        String TablaIncendio = "Incendios";
        String TablaTipoIncendio = "TipoIncendio";
        public clsIncendios()
        {
            conector = new OleDbConnection(Properties.Settings.Default.CADENA);
            comando = new OleDbCommand();
            DS = new DataSet();
            comando.Connection = conector;
            comando.CommandType = CommandType.TableDirect;
            comando.CommandText = "Incendios";

            adaptador = new OleDbDataAdapter(comando);
            tabla = new DataTable();
            adaptador.Fill(tabla);

            DataColumn[] dc = new DataColumn[2];
            dc[0] = tabla.Columns["Departamento"];
            dc[1] = tabla.Columns["TipoIncendio"];
            tabla.PrimaryKey = dc;
            /////////////
            conector2 = new OleDbConnection(Properties.Settings.Default.CADENA);
            comando2 = new OleDbCommand();

            comando2.Connection = conector;
            comando2.CommandType = CommandType.TableDirect;
            comando2.CommandText = "TipoIncendio";

            adaptador2 = new OleDbDataAdapter(comando);
            tabla2 = new DataTable();
            adaptador2.Fill(tabla2);

            DataColumn[] dc2 = new DataColumn[1];
            dc2[0] = tabla.Columns["TipoIncendio"];
            tabla.PrimaryKey = dc2;

        }

        public DataTable getAll()
        {
            return tabla;
        }
        public int ObtenerIncendiosPorDepartamento(int departamento, ListView lvw)
        {
            int Total = 0; // cantidad total de incendios del departamento
            int Cantidad = 0; // cantidad de incendios por tipo

            lvw.Items.Clear();
            // recorrer los tipos de Incendio
            foreach (DataRow dr in DS.Tables[TablaTipoIncendio].Rows)
            {
                Cantidad = 0;
                // texto del item (primera columna de LsitView)
                ListViewItem item = lvw.Items.Add(dr["Descripcion"].ToString());
                // recorrer la tabla de incendios
                foreach (DataRow drI in DS.Tables[TablaIncendio].Rows)
                {
                    if (departamento == (int)drI["Departamento"] &&
                        (int)dr["TipoIncendio"] == (int)drI["TipoIncendio"])
                    {
                        Cantidad += (int)drI["Cantidad"];
                    }
                }

                // texto del subitem (segunda columna)
                item.SubItems.Add(Cantidad.ToString());
                // acumular el total
                Total += Cantidad;
            }

            return Total;
        }


        public int ObtenerIncendiosPorProvincia(int provincia, ListView lvw)
        {
            int Total = 0; // cantidad total de incendios de la provincia
            int Cantidad = 0; // cantidad de incendios por tipo
            int prov_dep;
            clsProvincias prov = new clsProvincias();

            lvw.Items.Clear();
            // recorrer los tipos de Incendio
            foreach (DataRow dr in DS.Tables[TablaTipoIncendio].Rows)
            {
                Cantidad = 0;
                // texto del item (primera columna de LsitView)
                ListViewItem item = lvw.Items.Add(dr["Descripcion"].ToString());
                // recorrer la tabla de incendios
                foreach (DataRow drI in DS.Tables[TablaIncendio].Rows)
                {
                    prov_dep = prov.ObtenerProvincia((int)drI["Departamento"]);

                    if (provincia == prov_dep &&
                        (int)dr["TipoIncendio"] == (int)drI["TipoIncendio"])
                    {
                        Cantidad += (int)drI["Cantidad"];
                    }
                }

                // texto del subitem (segunda columna)
                item.SubItems.Add(Cantidad.ToString());
                // acumular el total
                Total += Cantidad;
            }
           
            return Total;
        }

        public int ObtenerIncendios(ListView lvw)
        {
            int Total = 0; // cantidad total de incendios 
            int Cantidad = 0; // cantidad de incendios por tipo

            lvw.Items.Clear();
            // recorrer los tipos de Incendio
            foreach (DataRow dr in DS.Tables[TablaTipoIncendio].Rows)
            {
                Cantidad = 0;
                // texto del item (primera columna de LsitView)
                ListViewItem item = lvw.Items.Add(dr["Descripcion"].ToString());
                // recorrer la tabla de incendios
                foreach (DataRow drI in DS.Tables[TablaIncendio].Rows)
                {
                    if ((int)dr["TipoIncendio"] == (int)drI["TipoIncendio"])
                    {
                        Cantidad += (int)drI["Cantidad"];
                    }
                }

                // texto del subitem (segunda columna)
                item.SubItems.Add(Cantidad.ToString());
                // acumular el total
                Total += Cantidad;
            }

            return Total;
        }


    }
}
