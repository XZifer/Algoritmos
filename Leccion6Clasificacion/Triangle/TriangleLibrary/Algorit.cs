namespace TriangleLibrary
{
    public class Algorit
    {
        public int Triangulo(int[] A)
        {
            int resultado = 0;
            for (int p = 0; p < A.Length - 2; p++)
            {
                for (int q = 1; q < A.Length - 1; q++)
                {
                    for (int r = 2; r < A.Length; r++)
                    {
                        if (A[p] + A[q] > A[r] && A[q] + A[r] > A[p] && A[r] + A[p] > A[q])
                        {
                            resultado = 1;
                            return resultado;
                        }
                    }
                }
            }
            return resultado;
        }
    }
}