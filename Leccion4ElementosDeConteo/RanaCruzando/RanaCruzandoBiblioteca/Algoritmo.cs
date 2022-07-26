namespace RanaCruzandoBiblioteca
{
    public class Algoritmo
    {
        public int Solucion(int X, int[] A)
        {
            //k es el tiempo
            //X es el ancho del rio
            //Declarando variable tiempo 
            int K = -1;
            int[] B = A.OrderBy(x => x).ToArray();
            B = B.Distinct().ToArray();
            Array.Resize(ref B, X);

            //comparar elemento de A con B
            for (int i = 0; i < A.Length; i++)
            {                
                if (B.Length == 0)
                {
                    i = A.Length;
                }
                else if (B.Length != 0 && i == A.Length -1)
                {
                    K = -1;
                }
                else
                {
                    foreach (int item in B)
                    {
                        if (A[i] == item)
                        {
                            B = B.Where(val => val != item).ToArray();
                        }                         
                    }
                    K++;
                }                
            }

            return K;
        }
    }
}