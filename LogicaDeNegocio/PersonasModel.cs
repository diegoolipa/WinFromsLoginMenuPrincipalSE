using AccesoDato;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaDeNegocio
{
    public class PersonasModel
    {
        private PersonasDao personaDao = new PersonasDao();

        public DataTable MostrarPersona()
        {
            DataTable tabla = new DataTable();
            tabla = personaDao.Mostrar();
            return tabla;
        }
    }
}
