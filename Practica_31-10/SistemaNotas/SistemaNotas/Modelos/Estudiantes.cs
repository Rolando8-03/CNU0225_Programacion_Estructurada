namespace SistemaNotas.Modelos
{
    public class Estudiantes
    {
        public string Nombre { get; set; }
        public string Codigo { get; set; }
        public Estudiantes() { }
        public Estudiantes(string nombre_estudiante, string codigo_estudiante)
        {
            Nombre = nombre_estudiante;
            Codigo = codigo_estudiante;
        }
    }
}
