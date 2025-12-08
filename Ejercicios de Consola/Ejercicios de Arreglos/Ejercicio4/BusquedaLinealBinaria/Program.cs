using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusquedaLinealBinaria
{
    class Estudiante
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Estudiante> lista = new List<Estudiante>()
            {
                new Estudiante{Id=1, Nombre="Ana"},
                new Estudiante{Id=2, Nombre="Brenda"},
                new Estudiante{Id=3, Nombre="Carlos"},
                new Estudiante{Id=4, Nombre="Daniel"},
                new Estudiante{Id=5, Nombre="Elena"},
                new Estudiante{Id=6, Nombre="Fernando"},
                new Estudiante{Id=7, Nombre="Gabriela"},
                new Estudiante{Id=8, Nombre="Hector"},
                new Estudiante{Id=9, Nombre="Irene"},
                new Estudiante{Id=10, Nombre="Jose"}
            };

            Console.Write("Ingrese un ID para buscar (lineal): ");
            int idBuscado = int.Parse(Console.ReadLine());

            bool encontrado = false;

            foreach (var est in lista)
            {
                if (est.Id == idBuscado)
                {
                    Console.WriteLine($"Estudiante encontrado: {est.Nombre}");
                    encontrado = true;
                }
            }

            if (!encontrado)
            {
                Console.WriteLine("Estudiante no encontrado.");
            }

            // Búsqueda binaria por nombre
            lista.Sort((a, b) => a.Nombre.CompareTo(b.Nombre));

            Console.Write("Ingrese un nombre para buscar (binaria): ");
            string nombreBuscado = Console.ReadLine();

            int izquierda = 0;
            int derecha = lista.Count - 1;
            bool hallado = false;

            while (izquierda <= derecha)
            {
                int medio = (izquierda + derecha) / 2;

                if (lista[medio].Nombre.Equals(nombreBuscado, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"Estudiante encontrado: {lista[medio].Nombre} (ID {lista[medio].Id})");
                    hallado = true;
                    break;
                }
                else if (string.Compare(lista[medio].Nombre, nombreBuscado, true) < 0)
                {
                    izquierda = medio + 1;
                }
                else
                {
                    derecha = medio - 1;
                }
            }

            if (!hallado)
            {
                Console.WriteLine("Nombre no encontrado.");
            }
        }
    }
}
