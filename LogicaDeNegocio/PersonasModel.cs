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

        public Dictionary<string, object> InsertarPerosna(Dictionary<string, object> datos)
        {
            Dictionary<string, object> resultado = personaDao.Insertar(datos);
            return resultado;
        }

        public void EliminarPersona(int personaID)
        {
            personaDao.Eliminar(personaID);
        }

        
        public void EditarPersona(Dictionary<string, object> datos)
        {
            personaDao.Editar(datos);
        }
    }
}
