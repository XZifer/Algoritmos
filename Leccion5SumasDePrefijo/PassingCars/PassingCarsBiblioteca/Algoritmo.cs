namespace PassingCarsBiblioteca
{
    public class Algoritmo
    {
        public int Solucion(int[] A)
        {
            int contador = 0;
            for (int p = 0; p < A.Length; p++)
            {
                for (int q = 1; q < A.Length; q++)
                {
                    if (p < q && A[p] == 0 && A[q] == 1)
                    {
                        contador++;
                    }
                }
            }
            if (contador > 1000000)
            {
                contador = -1;
            }
            return contador;
        }
    }
}