namespace Monto.DAO
{
    public static class Calculo
    {
        /// <summary>
        /// Calcular monto por paso de valor
        /// </summary>
        /// <param name="precio"></param>
        /// <returns></returns>
        public static double CalcularMonto(double precio)
        {
            precio *= 1.15;
            return precio;
        }
        /// <summary>
        /// Calcular monto por paso de referencia
        /// </summary>
        /// <param name="precio"></param>
        /// <returns></returns>
        public static double CalcularMonto(ref double precio)
        {
            precio *= 1.15;
            return precio;
        }
    }
}
