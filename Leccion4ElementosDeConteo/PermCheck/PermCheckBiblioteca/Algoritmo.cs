namespace PermCheckBiblioteca
{
    public class Algoritmo
    {
        public int PermutaCheck(int[] A)
        {
            // 1 si es permutable
            // 0 no es permutable
            //sin repetir elementos
            int permuta =0;
            Array.Sort(A);
            int siguiente;
            if (A[0] != 1 | A.Length == 0)
            {
                return permuta;
            }
            else if (A.Length == 1 && A[0] == 1)
            {
                return 1;
            }
            for (int actual = 0; actual < A.Length -1; actual++)
            {
                siguiente = actual + 1;
                
                if ((A[siguiente] - A[actual]) == 1 )
                {
                    permuta = 1;
                }
                else
                {
                    permuta = 0;
                    break;
                }
            }
            return permuta;
        }
    }
}