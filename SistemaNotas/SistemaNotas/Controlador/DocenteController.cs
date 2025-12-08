using Newtonsoft.Json;
using SistemaNotas.Modelos;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace SistemaNotas.Controlador
{
    public class DocenteController
    {
        private List<Docente> listado = new List<Docente>();

        public Boolean Agregar(string cif, string nombres, string apellidos, DateTime fechaNac, string titulo)
        {
            Boolean resultado = false;
            try
            {
                Docente docente = new Docente();
                docente.Cif = cif;
                docente.Nombres = nombres;
                docente.Apellidos = apellidos;
                docente.FechaNac = fechaNac;
                docente.Titulo = titulo;
                listado.Add(docente);
                resultado= true;
            }catch (Exception)
            {
                resultado =false;
            }
            return resultado;
        }

        public List<Docente> GetDocentes()
        {
            return listado;
        }

        // Guarda el listado completo en un archivo JSON (UTF-8)
        public bool GuardarJson(string rutaArchivo)
        {
            try
            {
                var json = JsonConvert.SerializeObject(listado, Formatting.Indented);
                File.WriteAllText(rutaArchivo, json, Encoding.UTF8);
                return true;
            }
            catch
            {
                return false;
            }
        }

        // Carga el listado desde un archivo JSON (si no existe, deja la lista vacía)
        public List<Docente> CargarJson(string rutaArchivo)
        {
            try
            {
                if (!File.Exists(rutaArchivo))
                {
                    listado = new List<Docente>();
                    return listado;
                }

                var json = File.ReadAllText(rutaArchivo, Encoding.UTF8);
                var data = JsonConvert.DeserializeObject<List<Docente>>(json);
                listado = data ?? new List<Docente>();
                return listado;
            }
            catch
            {
                listado = new List<Docente> { }; return listado;
            }
        }

    }
}
