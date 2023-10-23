using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDato;

namespace LogicaDeNegocio

{
    public class UsuarioModel
    {
        UsuarioDao usuarioDao = new UsuarioDao();

        public bool LoginUsuario(string usuario, string contrasenia)
        {
            return usuarioDao.Login(usuario, contrasenia);
        }
    }
}
