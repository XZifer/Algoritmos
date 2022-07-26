namespace MatrizDisparBiblioteca
{
    public class Algoritmo
    {
        public int obtenerElementoDeapar(int[] A)
        {
            if (A.Length == 0)
            {
                return A.Length;
            }
            while (A.Length != 1)
            {  
                int actual = 0;
                for (int siguiente = actual +1; siguiente < A.Length; siguiente++)
                {
                    if (A[actual] == A[siguiente])
                    {
                        A = A.Where((source, index) => index != siguiente).ToArray();
                        A = A.Where((source, index) => index != actual).ToArray();
                        break;
                    }
                }
            }
            return A[0];            
        }

        //List<int> B = A.ToList();
        //int ele_actual;
        //int ele_siguiente;
        //for (int i = 0; i < B.Count; i++)
        //{
        //    i = 0;
        //    int siguiente = i + 1;
        //    ele_actual = B[i];
        //    ele_siguiente = B[siguiente];
        //    while (B[i] != B[siguiente])
        //    {
        //        siguiente++;
        //    }
        //    ele_actual = B[i];
        //    ele_siguiente = B[siguiente];
        //    B.RemoveAt(siguiente);
        //    B.RemoveAt(i);
        //}

        //return B[0];
    }
}