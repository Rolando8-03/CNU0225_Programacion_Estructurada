using ClassLibrary1.Modelos;
using System;


namespace ClassLibrary1.DAO
{
    public class ProductoDAO
    {
        private static int TAM = 10;
        private Producto [] carrito = new Producto[TAM];
        private int pos = 0;
        public void AgregarProducto(Producto prod)
        {
            try
            {
                carrito[pos++] = prod;
            }
            catch (IndexOutOfRangeException)
            { Console.WriteLine("No se puede agregar más de 10 elementos"); }
        }
        public Producto[] GetProducts()
        {
            return carrito;
        }
    }
}
