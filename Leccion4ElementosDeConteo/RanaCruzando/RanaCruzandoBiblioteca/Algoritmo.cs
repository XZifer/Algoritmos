namespace RanaCruzandoBiblioteca
{
    public class Algoritmo
    {
        public int Solucion(int X, int[] A)
        {
            #region My Solution A
            //int K = 0;
            //int[] B = A.OrderBy(x => x).ToArray();
            //B = B.Distinct().ToArray();
            //if (X > A.Max() | X > B.Length )
            //{
            //    K = -1;
            //}
            //else
            //{

            //    foreach (int item in B)
            //    {
            //        if (A.Contains(item))
            //        {
            //            int index = Array.IndexOf(A, item);
            //            if (index > K)
            //            {
            //                K = index;
            //            }
            //            else if (index == X + 1)
            //            {
            //                return index;
            //            }
            //        }
            //    }
            //}
            //return K;
            #endregion
            #region My Solution B timeAx2
            //int[] B = new int[X];
            //int sum = 0;
            //for (int i = 1; i <= X; i++)
            //{
            //    sum += i;
            //    B[i-1] = i;
            //}
            //int K = 0;
            //foreach (var a in A)
            //{
            //    if (B.Contains(a))
            //    {
            //        B = B.Where(val => val != a).ToArray();
            //        sum -= a;
            //        if (sum == 0)
            //        {
            //            return K;
            //        }
            //    }
            //    K++;
            //}
            //return -1;
            #endregion
            #region solution 100%
            var dict = new Dictionary<int, int>();
            for (int i = 1; i <= X; i++)
            {
                dict.Add(i, 1);
            }

            var sum = dict.Keys.Sum();

            int j = 0;
            foreach (int num in A)
            {
                if (dict.ContainsKey(num))
                {
                    dict.Remove(num);
                    sum -= num;

                    if (sum == 0)
                    {
                        return j;
                    }
                }

                j++;
            }
            return -1;
            #endregion
        }
    }
}