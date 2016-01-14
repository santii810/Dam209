using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADAT_UD3_EJ2
{
    class GestorBD
    {
        private String stringConexión = Properties.Settings.Default.CentroMedicoConnectionString.ToString();
        public CentroMedicoDataSet1 ds = new CentroMedicoDataSet1(); // DataSet tipado
        public void obtenerUsuarios()
        {
            // Abrir conexión:
            SqlConnection conexion = new SqlConnection(stringConexión);
            conexion.Open();
            // Definir adaptador:
            SqlDataAdapter adapter = new SqlDataAdapter("Select * from Usuarios", conexion);
            // Inserta aquí los resultados:
            adapter.Fill(ds.Usuarios);
            conexion.Close();
        }
        public void obtenerHistoriales()
        {
            // Abrir conexión:
            SqlConnection conexion = new SqlConnection(stringConexión);
            conexion.Open();
            // Definir adaptador:
            SqlDataAdapter adapter = new SqlDataAdapter("Select * from Historiales", conexion);
            // Inserta aquí los resultados:
            adapter.Fill(ds.Historiales);
            conexion.Close();
        }
    }
}
