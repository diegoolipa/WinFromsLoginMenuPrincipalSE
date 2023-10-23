using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comun.Cache
{
    public static class UsuarioLoginCache
    {
        public static int IdUser { get; set; }
        public static string Nombre { get; set; }
        public static string ApellidoPaterno { get; set; }
        public static string ApellidoMaterno { get; set; }
        public static string Correo { get; set; }
        public static string NumDocumento { get; set; }
        public static string Rol { get; set; }
    }
}
