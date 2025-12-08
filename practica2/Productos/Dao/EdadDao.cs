
namespace Productos.Dao
{
    public class EdadDao
    {
        public static int[] edades = new int[10];
        public static int pos = 0;
        public static double Promedio() 
        {
            double suma = 0, promedio = 0;
            for (int i = 0; i < pos; i++)
            {
                suma += edades[i];
            }
            promedio = suma / pos;
            return promedio;
        }
    }
}
