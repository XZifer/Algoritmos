namespace PermutacionBiblioteca
{
    public class Algoritmo
    {
        public int Permuta(int[] A)
        {
            //Seleccionamos el tamaño de la matriz
            int permuta = 0;
            //ordenamos la matriz
            Array.Sort(A);
            //verificamos que la matriz sea permutable
            int numsiguiente;
            for (int i = 0; i < A.Length -1; i++)
             {
                numsiguiente = A[i+1];
                if ((numsiguiente - A[i]) > 1)
                {
                    permuta = 0;
                    i = A.Length;
                }
                else
                {
                    permuta = 1;
                }
             }
            //imprimir cada uno de los valores de la lista
            
            return permuta;
        }
    }
}