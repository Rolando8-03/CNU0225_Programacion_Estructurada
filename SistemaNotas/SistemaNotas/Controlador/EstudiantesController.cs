using SistemaNotas.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaNotas.Controlador
{
    public class EstudiantesController
    {
        private List<Estudiantes> estudiantes = new List<Estudiantes>();
        public Boolean AgregarEstudiantes(string nombre, string codigo)
        {
            try
            {
                Estudiantes estudiante = new Estudiantes(nombre, codigo);
                estudiantes.Add(estudiante);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public List<Estudiantes> ObtenerTodasEstudiantes()
        {
            return estudiantes;
        }
        public Estudiantes ObtenerTodasEstudiantes(string nombre, string codigo)
        {
            //Búsqueda lambda por código y nombre
            Estudiantes estudiante = estudiantes.Find(c => c.Codigo == codigo);
            return estudiante;
        }
        public Boolean Eliminar(string nombre, string codigo)
        {
            Estudiantes estudiante = ObtenerTodasEstudiantes(nombre, codigo);
            if (estudiante == null)
            {
                return false;
            }
            estudiantes.Remove(estudiante);
            return true;

        }
        public List<Estudiantes> ObtenerTodasEstudiantes(string dato)
        {
            return estudiantes.FindAll(c => c.Nombre.Contains(dato));
        }
    }
}
