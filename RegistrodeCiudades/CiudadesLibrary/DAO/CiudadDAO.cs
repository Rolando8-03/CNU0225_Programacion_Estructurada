using System;
using CiudadesLibrary.Modelos;

namespace CiudadesLibrary.DAO
{
    public class CiudadDAO
    {
        private Ciudad[] listado = new Ciudad[10];
        private int pos = 0;
        public void AgregarCiudad(Ciudad ciudad)
        {
            try
            {
                listado[pos] = ciudad;
                pos++;
            }
            catch (System.IndexOutOfRangeException)
            {
                Console.WriteLine("No se puede agregar más de 10 elementos");
            }
        }
        public Ciudad[] MostrarCiudad()
        {
            return listado;
        }
    }
}
