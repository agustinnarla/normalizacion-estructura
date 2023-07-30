using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace prySituacion2
{
    internal class clsActividades
    {
       

        private string varNombre;
        private DateTime varFecha;
        private string varObser;
        private int varActividad;
        public string Nombre
        {
            get { return varNombre; }
            set { varNombre = value; }
        }
        public int ID
        {
            get { return varActividad; }
            set { varActividad = value; }
        }
        public DateTime Fecha
        {
            get { return varFecha; }
            set { varFecha = value; }
        }
        public string Obser
        {
            get { return varObser; }
            set { varObser = value; }
        }
        private OleDbConnection conector;
        private OleDbCommand comando;
        private OleDbDataAdapter adaptador;
        private DataTable tabla;
        public clsActividades()
        {
            conector = new OleDbConnection(Properties.Settings.Default.CADENA);
            comando = new OleDbCommand();

            comando.Connection = conector;
            comando.CommandType = CommandType.TableDirect;
            comando.CommandText = "Actividad";

            adaptador = new OleDbDataAdapter(comando);
            tabla = new DataTable();
            adaptador.Fill(tabla);

            DataColumn[] dc = new DataColumn[1];
            dc[0] = tabla.Columns["idActividad"];
            tabla.PrimaryKey = dc;
        }
        public void agregar()
        {
            try
            {
                
                DataRow filaactividades = tabla.Rows.Find(varActividad);

                if (filaactividades is null)
                {

                    //crea un nuevo datarow con lo mismo de la tabla 
                    DataRow fila = tabla.NewRow();

                    fila["idActividad"] = varActividad;
                    fila["asunto"] = varNombre;
                    fila["fecha"] = varFecha;
                    fila["observacion"] = varObser;
                    tabla.Rows.Add(fila);

                    OleDbCommandBuilder cb = new OleDbCommandBuilder(adaptador);
                    adaptador.Update(tabla);

                }
                else
                {
                    varActividad = 0;
                    varNombre = "";
                    varObser = "";
                    varFecha = DateTime.Now;
                    
                }
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }
           
            
        }
        public DataTable getAll()
        {
            return tabla;
        }
        public void cmdEliminar(int varActividad)
        {
            try
            {
                DataRow filaeliminar = tabla.Rows.Find(varActividad);

                if (filaeliminar is null)
                {
                    filaeliminar.Delete();
                    OleDbCommandBuilder cb = new OleDbCommandBuilder(adaptador);
                    adaptador.Update(tabla);
                }
                
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public void Consultar(string asunto)
        {
            
        }
        
       
    }


}
