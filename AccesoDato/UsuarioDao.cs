using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDato
{
    public class UsuarioDao : ConnectionToSql
    {
        public bool Login(string usuario, string contrasenia)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = @"
                            select 
                            u.UsuarioID,
                            p.Nombre,
                            p.ApellidoMaterno,
                            p.ApellidoPaterno,
                            p.Email,
                            p.NumeroDoc,
                            u.Rol
                            from Usuarios as u 
                                inner join Personas as p on u.PersonaID = p.PersonaID
                                where Usuario=@usuario and Contrasenia = @contrasenia;
                    ";
                    command.Parameters.AddWithValue("@usuario", usuario);
                    command.Parameters.AddWithValue("@contrasenia", contrasenia);
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        return true;
                    }
                    else 
                    {
                        return false; 
                    }
                }
            }
        }

        //Privilegios

        public void AnyMethod()
        {

        }


    }
}
