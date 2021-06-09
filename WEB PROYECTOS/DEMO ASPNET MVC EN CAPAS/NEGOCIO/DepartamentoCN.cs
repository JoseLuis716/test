using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DATOS;
using ENTIDAD;

namespace NEGOCIO
{
    public class DepartamentoCN
    {
        private static DepartamentoDALC ob = new DepartamentoDALC();
        public static void Agregar(Departamento dpto)
        {
            ob.Agregar(dpto);

        }
        public static List<Departamento> ListarDepartamentos()
        {
            return ob.ListarDepartamentos();
        }
        public static Departamento GetDepartamento(int id)
        {
            return ob.GetDepartamento(id);
        }
        public static void Editar(Departamento dpto)
        {
            ob.Editar(dpto);
        }
        public static void Eliminar(int id)
        {
            ob.Eliminar(id);
        }
    }
}
