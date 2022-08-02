using System.Linq;

namespace PassingCarsBiblioteca
{
    public class Algoritmo
    {
        public int Solucion(int[] A)
        {
            #region Opcion1
            //int contador = 0;
            //for (int p = 0; p < A.Length - 1; p++)
            //{
            //    for (int q = p +1; q < A.Length; q++)
            //    {
            //        if (A[p] == 0 && A[q] == 1)
            //        {
            //            contador++;
            //            if (contador > 1000000000)
            //            {
            //                return -1;
            //            }
            //        }
            //    }
            //}
            //return contador;
            #endregion
            #region Opcion2
            //int contador = 0;
            //for (int p = 0; p < A.Length -1; p++)
            //{
            //    if (A[p] == 0)
            //    {
            //        for (int q = p + 1; q < A.Length; q++)
            //        {
            //            if (A[q] == 1)
            //            {
            //                contador++;
            //                if (contador > 1000000000)
            //                {
            //                    return -1;
            //                }
            //            }
            //        }
            //    }
            //}
            //return contador;
            #endregion
            #region Opcion3
            //int contador = 0;
            //for (int p = 0; p < A.Length -1; p++)
            //{
            //    if (A[p] == 0)
            //    {
            //        int q = p + 1;
            //        int[] array = new int[A.Length - q];
            //        Array.Copy(A,q,array,0,A.Length-q);
            //        contador += array.Sum();
            //        if (contador > 1000000000)
            //        {
            //            return -1;
            //        }
            //    }
            //}
            //return contador;
            #endregion
            #region Opcion4
            //int contador = 0;
            //for (int i = 0; i < A.Length; i++)
            //{
            //    if (A[i] == 0)
            //    {
            //        for (int j = i; j < A.Length; j++)
            //        {
            //            if (A[j] == 1)
            //            {
            //                contador += 1;
            //            }
            //        }
            //    }
            //}
            //if (contador >= 1000000000)
            //{
            //    return -1;
            //}
            //else
            //{
            //    return contador;
            //}
            #endregion
            int l = A.Length;
            int countZero = 0;
            int countPairs = 0;
            int exceed = 1000000000;

            for (int i = 0; i < l; i++)
            {
                if (A[i] == 1)
                {
                    countPairs += countZero;
                }
                else
                {
                    countZero++;
                }
            }

            if (countPairs > exceed || countPairs < 0)
            {
                return -1;
            }
            else
            {
                return countPairs;
            }
        }
    }
}