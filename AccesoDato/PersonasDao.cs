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
        public Dictionary<string, object> Insertar(Dictionary<string, object> datos)
        {
            Dictionary<string, object> resultado = new Dictionary<string, object>();

            comando.Connection = connection.AbrirConexion();
            comando.CommandText = "CrearPersonaWF";
            comando.Parameters.Add(new SqlParameter("@Nombre", SqlDbType.NVarChar, 50)).Value = datos["nombre"];
            comando.Parameters.Add(new SqlParameter("@ApellidoPaterno", SqlDbType.NVarChar, 50)).Value = datos["apellidoPaterno"];
            comando.Parameters.Add(new SqlParameter("@ApellidoMaterno", SqlDbType.NVarChar, 50)).Value = datos["apellidoMaterno"];
            comando.Parameters.Add(new SqlParameter("@FechaNacimiento", SqlDbType.Date, 50)).Value = DateTime.Now;
            comando.Parameters.Add(new SqlParameter("@Email", SqlDbType.NVarChar, 50)).Value = datos["email"];
            comando.Parameters.Add(new SqlParameter("@NumeroDOC", SqlDbType.NVarChar, 50)).Value = datos["numeroDoc"];
            comando.Parameters.Add(new SqlParameter("@Direccion", SqlDbType.NVarChar, 50)).Value = datos["direccion"];
            comando.Parameters.Add(new SqlParameter("@Celular", SqlDbType.NVarChar, 50)).Value = datos["celular"];

            SqlParameter parametroMensaje = new SqlParameter("@Mensaje", SqlDbType.NVarChar, 200);
            parametroMensaje.Direction = ParameterDirection.Output;
            comando.Parameters.Add(parametroMensaje);

            SqlParameter parametroError = new SqlParameter("@Error", SqlDbType.Int);
            parametroError.Direction = ParameterDirection.Output;
            comando.Parameters.Add(parametroError);

            comando.CommandType = CommandType.StoredProcedure;
            comando.ExecuteNonQuery();
            comando.Parameters.Clear(); //Limpiar parametros
            connection.CerrarConexion();

            resultado["Mensaje"] = parametroMensaje.Value.ToString();
            resultado["Error"] = (int)parametroError.Value;
            return resultado;

        }

        public void Eliminar(int personaID)
        {
            comando.Connection = connection.AbrirConexion();
            comando.CommandText = "DELETE Personas WHERE PersonaID = @PersonaID";
            comando.Parameters.Add(new SqlParameter("@PersonaID", SqlDbType.Int)).Value = personaID;
            comando.CommandType = CommandType.Text;
            comando.ExecuteNonQuery();
            comando.Parameters.Clear(); //Limpiar parametros
            connection.CerrarConexion();
        }

        public void Editar(Dictionary<string, object> datos)
        {
            comando.Connection = connection.AbrirConexion();
            comando.CommandText = "UPDATE Personas SET Nombre = @Nombre, FechaNacimiento = @FechaNacimiento, Email = @Email, NumeroDoc = @Documento, Direccion = @Direccion, Telefono = @Telefono WHERE PersonaID = @PersonaID";
            comando.Parameters.Add(new SqlParameter("@Nombre", SqlDbType.NVarChar, 50)).Value = datos["nombre"];
            //comando.Parameters.Add(new SqlParameter("@Apellido", SqlDbType.NVarChar, 50)).Value = datos["apellidoPaterno"];
            comando.Parameters.Add(new SqlParameter("@FechaNacimiento", SqlDbType.Date, 50)).Value = DateTime.Now;
            comando.Parameters.Add(new SqlParameter("@Email", SqlDbType.NVarChar, 50)).Value = datos["email"];
            comando.Parameters.Add(new SqlParameter("@Documento", SqlDbType.NVarChar, 50)).Value = datos["numeroDoc"];
            comando.Parameters.Add(new SqlParameter("@Direccion", SqlDbType.NVarChar, 50)).Value = datos["direccion"];
            comando.Parameters.Add(new SqlParameter("@Telefono", SqlDbType.NVarChar, 50)).Value = datos["celular"];
            comando.Parameters.Add(new SqlParameter("@PersonaID", SqlDbType.Int)).Value = datos["personaID"];
            comando.CommandType = CommandType.Text;
            comando.ExecuteNonQuery();
            comando.Parameters.Clear(); //Limpiar parametros
            connection.CerrarConexion();
        }
    }
}
