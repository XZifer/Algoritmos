namespace MatrizDisparBiblioteca
{
    public class Algoritmo
    {
        public int obtenerElementoDeapar(int[] A)
        {
            //iterando sobre los elementos de la matriz dada
            List<int> B = A.ToList();
            int ele_actual;
            int ele_siguiente;
            for (int i = 0; i < B.Count; i++)
            {
                i = 0;
                int siguiente = i + 1;
                ele_actual = B[i];
                ele_siguiente = B[siguiente];
                while (B[i] != B[siguiente])
                {
                    siguiente++;
                }
                ele_actual = B[i];
                ele_siguiente = B[siguiente];
                //B = B.Where((source, index) => index != B[i]).ToArray();
                //B = B.Where((source, index) => index != B[siguiente]).ToArray();
                B.RemoveAt(siguiente);
                B.RemoveAt(i);
            }
            
            return B[0];
        }
        
    }
}