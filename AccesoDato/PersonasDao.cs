using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDato
{
    public class PersonasDao
    {
        private ConexionSqlDos connection = new ConexionSqlDos();

        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable Mostrar()
        {
            comando.Connection = connection.AbrirConexion();
            //comando.CommandText = "ListaPersona";
            comando.CommandText = "select * from Personas";
            comando.CommandType = CommandType.Text;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            comando.Parameters.Clear(); //Limpiar parametros
            connection.CerrarConexion();
            return tabla;
        }
    }
}
