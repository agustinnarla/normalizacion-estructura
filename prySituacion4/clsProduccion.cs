using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace prySituacion4
{
    internal class clsProduccion
    {

        private OleDbConnection conector;
        private OleDbCommand comando;
        private OleDbDataAdapter adaptador;
        private DataTable tabla;
        private DataSet ds;


        public clsProduccion()
        {
            conector = new OleDbConnection(Properties.Settings.Default.CADENA);
            comando = new OleDbCommand();

            comando.Connection = conector;
            comando.CommandType = CommandType.TableDirect;
            comando.CommandText = "Produccion";

            adaptador = new OleDbDataAdapter(comando);
            tabla = new DataTable();
            adaptador.Fill(tabla);

            DataColumn[] dc = new DataColumn[2];
            dc[0] = tabla.Columns["localidad"];
            dc[1] = tabla.Columns["cultivo"];
            tabla.PrimaryKey = dc;

            ds = new DataSet();
        }

        public DataTable getAll()
        {
            return tabla;
        }

        public bool actualizar(int localidad, int cultivo, int tonelada)
        {
            bool varBandera = true;

            Object[] clave = new object[2];
            clave[0] = localidad;
            clave[1] = cultivo;

            DataRow filaProd = tabla.Rows.Find(clave);

            if (filaProd is null)
            {
                DataRow filita = tabla.NewRow();

                filita["localidad"] = localidad;
                filita["cultivo"] = cultivo;
                filita["produccion"] = tonelada;

                tabla.Rows.Add(filita);
                OleDbCommandBuilder cb = new OleDbCommandBuilder(adaptador);
                adaptador.Update(tabla);

            }
            else
            {
                varBandera = false;
            }

            return varBandera;

        }
        public void graficar(int localidad, Chart chart)
        {
            clsCultivos objCUL = new clsCultivos();
            DataTable tc = objCUL.getAll();

            chart.Series.Clear();

            Series serie = chart.Series.Add("PRODUCCION");

            foreach (DataRow fc in tc.Rows)
            {
                Object[] clave = new object[2];
                clave[0] = localidad;
                clave[1] = fc["cultivo"].ToString();

                int toneladas = 0;
                DataRow fp = tabla.Rows.Find(clave);

                if (fp != null)
                {
                    toneladas = (int)fp["produccion"];
                }

                serie.Points.AddXY(fc["nombre"], toneladas);
            }

        }
        public void Graficar(Chart grafiquito)
        {
            //clsCultivos objCUL = new clsCultivos();
            //clsProduccion objPRO = new clsProduccion();
            //DataTable tc = objCUL.getAll();
            //DataTable tp = objPRO.getAll();

            //DataTable prod = new DataTable();
            //prod.Columns.Add("Produccion");
            //prod.Columns.Add("Nombre");

            //grafiquito.Series.Clear();

            //Series serie = grafiquito.Series.Add("Toneladas");

            //foreach (DataRow fc in tc.Rows)
            //{
            //    int toneladas = 0;

            //    foreach (DataRow fp in tp.Rows)
            //    {
            //        if ((int)fp["Cultivo"] == (int)fc["Cultivo"])
            //        {
            //            toneladas += (int)fp["Produccion"];
            //        }
            //    }

            //    DataRow nuevo = prod.NewRow();
            //    nuevo["Produccion"] = toneladas; // cantidad total de

            //    nuevo["Nombre"] = fc["Nombre"].ToString(); // nombre del cultivo
            //    prod.Rows.Add(nuevo);

            //}
            //grafiquito.DataBindTable(tp.DefaultView, "Nombre");
            //grafiquito.Series[0].ChartType = SeriesChartType.Column; // tipo de gráfico
            //grafiquito.Series[0].Name = "Totales"; // nombre de la serie

            //grafiquito.Series.Clear();
            //crear una tabla temporal
            DataTable prod = new DataTable();
            prod.Columns.Add("Produccion");
            prod.Columns.Add("Nombre");

            clsProduccion objP = new clsProduccion();
            clsCultivos cultivo = new clsCultivos();
            DataTable cultivos = cultivo.getAll();
            DataTable PRODU = objP.getAll();
            //recorrer todos los cultivos existentes
            foreach (DataRow cult in cultivos.Rows)
            {
                long prod_total = 0; // para cada cultivo acumula la producción
                //recorre la tabla de producción
                foreach (DataRow pro in PRODU.Rows)
                {
                    if ((int)cult["Cultivo"] == (int)pro["Cultivo"])
                    {
                        //si es el mismo cultivo, acumula
                       prod_total += (int)pro["Produccion"];
                    }
                }
                //por cada cultivo se agrega un registro nuevo a la tabla temporal
                DataRow nuevo = prod.NewRow();
                nuevo["Produccion"] = prod_total;   // cantidad total de producción
                nuevo["Nombre"] = cult["Nombre"].ToString(); // nombre del cultivo
                prod.Rows.Add(nuevo);
            }
            //enlazar la tabla temporal al control Chart
            grafiquito.DataBindTable(prod.DefaultView, "Nombre");
            grafiquito.Series[0].ChartType = SeriesChartType.Column; // tipo de gráfico
            grafiquito.Series[0].Name = "Totales"; // nombre de la serie

        }
    }
}
