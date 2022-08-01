namespace PermCheckBiblioteca
{
    public class Algoritmo
    {
        public int PermutaCheck(int[] A)
        {
            int permuta = 0;
            Array.Sort(A);
            int siguiente;
            if (A.Length == 0 || A[0] != 1)
            {
                 permuta = 0;
            }
            for (int actual = 0; actual < A.Length; actual++)
            {
                siguiente = actual + 1;
                if (siguiente == A.Length && permuta == 0)
                {
                    permuta = 1;
                }
                else if ((A[siguiente] - A[actual]) > 1)
                {
                    permuta = 0;
                    break;
                }
            }
            return permuta;
        }
    }
}