namespace MaxProDeTresBiblioteca
{
    public class Algoritm
    {
        public int Solucion(int[] A)
        {
            int[] B = A;
            int masGrande;
            int max = 0;
            Array.Sort(B);
            masGrande = A.Max();
            int ladoNegativo = B[0]*B[1];
            int ladoPositivo = B[B.Length - 2] * B[B.Length - 3];
            if (ladoNegativo > ladoPositivo)
            {
                max = masGrande * ladoNegativo;
                return max;
            }
            else
            {
                max = masGrande * ladoPositivo;
                return max;
            }
            
        }
    }
}