﻿namespace CintaEquilibrioBiblioteca
{
    public class Algoritmo
    {
        public int DiferenciaMinima(int[] A)
        {
            int minimo = Math.Abs(A.Max()-A.Min());
            if (A.Length == 1 || A.Length == 0)
            {
                return 1;
            }
            else
            {
                                
                int elemento = 0;
                int resta = 0;
                int parteA = A[elemento];
                int parteB = A.Sum() - parteA;
                int ultimoElemento = A[A.Length - 1];
                while (elemento < A.Length-1)
                {
                    resta = Math.Abs(parteA - parteB);
                    if (resta < minimo)
                    {
                        minimo = resta;
                    }
                    elemento++;
                    parteA += A[elemento];
                    parteB -= A[elemento];
                }
                return minimo;
            }
                #region Opcion 1
                //for (int i = 0; i < A.Length - 1; i++)
                //{
                //    int resta = 0;
                //    int parteA = 0;
                //    int parteB = 0;
                //    for (int j = i; j >= 0; j--)
                //    {
                //        parteA += A[j];
                //    }
                //    for (int j = i + 1; j < A.Length; j++)
                //    {
                //        parteB += A[j];
                //    }
                //    resta = Math.Abs(parteA - parteB);
                //    if (resta < minimo)
                //    {
                //        minimo = resta;
                //    }
                //}
                #endregion
        }
    }
}