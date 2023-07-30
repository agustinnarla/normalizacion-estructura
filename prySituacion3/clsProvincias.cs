using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prySituacion3
{
    internal class clsProvincias
    {
        private OleDbConnection conector;
        private OleDbCommand comando;
        private OleDbDataAdapter adaptador;
        private DataTable tabla;

        DataSet DS;
        String TablaProvincia = "Provincias";
        String TablaDepartamento = "Departamentos";

        public clsProvincias()
        {
            conector = new OleDbConnection(Properties.Settings.Default.CADENA);
            comando = new OleDbCommand();

            comando.Connection = conector;
            comando.CommandType = CommandType.TableDirect;
            comando.CommandText = "Provincias";

            adaptador = new OleDbDataAdapter(comando);
            tabla = new DataTable();
            adaptador.Fill(tabla);

            DataColumn[] dc = new DataColumn[1];
            dc[0] = tabla.Columns["Provincia"];
            tabla.PrimaryKey = dc;
        }

        public DataTable getAll()
        {
            return tabla;
        }
        public int ObtenerProvincia(int departamento)
        {
            // devuielve el número de provincia de un departamento
            DataRow dr = DS.Tables[TablaDepartamento].Rows.Find(departamento);
            if (dr == null)
            {
                throw new Exception("CProvincia: No existe del departamento");
            }
            return (int)dr["Provincia"];
        }
    }
}
