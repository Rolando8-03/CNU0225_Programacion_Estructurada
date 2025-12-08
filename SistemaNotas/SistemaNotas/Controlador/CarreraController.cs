
using Newtonsoft.Json;
using SistemaNotas.Modelos;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SistemaNotas.Controlador
{
    //Create, Read, Update, Delete
    public class CarreraController
    {
        private List<Carrera> carreras = new List<Carrera>();

        public Boolean Agregar(string nombre, string codigo)
        {
            try
            {
                Carrera carrera = new Carrera(codigo, nombre);
                carreras.Add(carrera);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        /// <summary>
        /// Obtiene todos los registros de carrera
        /// </summary>
        /// <returns></returns>
        public List<Carrera> GetCarreras()
        {
            return carreras;
        }
        /// <summary>
        /// Busca un elemento y muestra todos los registros encontrados
        /// </summary>
        /// <param name="dato"></param>
        /// <returns></returns>
        public List<Carrera> GetCarreras(string dato)
        {
            return carreras.FindAll(c => c.Nombre.Contains(dato));
        }

        public Carrera GetCarrera(string codigo, string nombre)
        {
            Carrera carrera = carreras.Find(c => c.Codigo == codigo);
            return carrera;
        }

        public Boolean Eliminar(string nombre, string codigo)
        {
            Carrera carrera = GetCarrera(codigo, nombre);
            if (carrera == null)
            {
                return false;
            }
            carreras.Remove(carrera);
            return true;
        }

        // Guarda el listado completo en un archivo JSON (UTF-8)
        public bool GuardarJson(string rutaArchivo)
        {
            try
            {
                var json = JsonConvert.SerializeObject(carreras, Formatting.Indented);
                File.WriteAllText(rutaArchivo, json, Encoding.UTF8);
                return true;
            }
            catch
            {
                return false;
            }
        }

        // Carga el listado desde un archivo JSON (si no existe, deja la lista vacía)
        public List<Carrera> CargarJson(string rutaArchivo)
        {
            try
            {
                if (!File.Exists(rutaArchivo))
                {
                    carreras = new List<Carrera>();
                    return carreras;
                }

                var json = File.ReadAllText(rutaArchivo, Encoding.UTF8);
                carreras = JsonConvert.DeserializeObject<List<Carrera>>(json) ?? new List<Carrera>();
                return carreras;
            }
            catch
            {
                // Puede registrar el error aquí si lo desea.
                carreras = new List<Carrera>();
                return carreras;
            }
        }

    }
}
