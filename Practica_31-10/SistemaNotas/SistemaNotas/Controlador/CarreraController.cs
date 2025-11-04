using SistemaNotas.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace SistemaNotas.Controlador
{
    //Create, Read, Update, Delete (CRUD) operations for Carrera
    public class CarreraController
    {
        private List<Carrera> carreras = new List<Carrera>();
        public Boolean Agregar(string nombre, string codigo)
        {
            try
            {
                Carrera carrera = new Carrera(nombre, codigo);
                carreras.Add(carrera);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public List<Carrera> ObtenerTodas()
        {
            return carreras;
        }
        public Carrera ObtenerTodas(string nombre, string codigo)
        {
            //Búsqueda lambda por código y nombre
            Carrera carrera = carreras.Find(c => c.Codigo == codigo);
            return carrera;
        }
        public Boolean Eliminar(string nombre, string codigo)
        {
            Carrera carrera = ObtenerTodas(nombre, codigo);
            if (carrera == null)
            {
                return false;
            }   
            carreras.Remove(carrera);
            return true;

        }
        public List<Carrera> ObtenerTodas(string dato)
        {
            return carreras.FindAll(c => c.Nombre.Contains(dato));
        }
    }
}