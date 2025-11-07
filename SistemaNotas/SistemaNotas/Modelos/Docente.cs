using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaNotas.Modelos
{
    public class Docente
    {
        public string Cif {  get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }

        public DateTime FechaNac {  get; set; }

        public string Titulo { get; set; }

    }
}
