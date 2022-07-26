namespace RecorrerUnaMatrizBiblioteca
{
    public class Algoritmo
    {
        public int [] RecorrerMatriz(int [] A,int K)
        {
            if (A.Length == 0)
            {
                return A;
            }
            List<int> matriz = new List<int>();
            matriz = A.ToList();
            for (int i = 0; i < K; i++)
            {
                int numeroaRecorrer = matriz[matriz.Count - 1];
                matriz.RemoveAt(matriz.Count - 1);
                matriz.Insert(0, numeroaRecorrer);
            }
            return matriz.ToArray();
            
        }
    }
}