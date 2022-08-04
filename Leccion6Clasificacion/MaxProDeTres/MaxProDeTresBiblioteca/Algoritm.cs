namespace MaxProDeTresBiblioteca
{
    public class Algoritm
    {
        public int Solucion(int[] A)
        {
            int masGrande;
            int max = 0;
            Array.Sort(A);
            masGrande = A.Max();
            int extremoIzq = A[0]*A[1];
            int extremoDer = A[A.Length - 2] * A[A.Length - 3];
            if (masGrande > 0)
            {
                if (extremoIzq > extremoDer)
                {
                    max = masGrande * extremoIzq;
                }
                else
                {
                    max = masGrande * extremoDer;
                }
            }
            else
            {
                max = masGrande * extremoDer;
            }
            return max;
            
        }
    }
}