namespace PermutacionBiblioteca
{
    public class Algoritmo
    {
        public int Permuta(int[] A)
        {
            //Seleccionamos el tamaño de la matriz
            //ordenamos la matriz
            //verificamos que la matriz sea permutable
            int falta = 0;
            Array.Sort(A);
            int siguiente;
            if (A.Length == 0 || A[0] != 1)
            {
                falta = 1;
                return falta;
            }
            for (int actual = 0; actual < A.Length ; actual++)
             {
                siguiente = actual + 1;
                if (siguiente == A.Length && falta == 0)
                {
                    falta = A[actual] +1;
                }
                else if ((A[siguiente] - A[actual]) > 1)
                {
                    falta = A[actual] + 1;
                    break;
                }
             }
            return falta;

            //int falta = 0;
            //Array.Sort(A);
            //int siguiente;
            //for (int i = 0; i < A.Length - 1; i++)
            //{
            //    siguiente = A[i + 1];
            //    if (i + 1 == A.Length && falta == 0)
            //    {
            //        falta = A[i] + 1;
            //    }
            //    else if ((siguiente - A[i]) > 1)
            //    {
            //        falta = A[i] + 1;
            //    }
            //}
            //return falta;
        }
    }
}