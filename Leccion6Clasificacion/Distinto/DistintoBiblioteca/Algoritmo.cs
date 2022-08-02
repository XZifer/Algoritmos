namespace DistintoBiblioteca
{
    public class Algoritmo
    {
        public int Solucion(int[] A)
        {
            int distinto;
            distinto = A.Distinct().Count();
            return distinto;
        }
    }
}