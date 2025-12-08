
namespace SistemaNotas.Modelos
{
    public class Carrera
    {
        public string Nombre { get; set; }
        public string Codigo { get; set; }

        public Carrera() { }

        public Carrera(string codigo, string nombre)
        {
            Codigo = codigo;
            Nombre = nombre;
        }

    }
}
