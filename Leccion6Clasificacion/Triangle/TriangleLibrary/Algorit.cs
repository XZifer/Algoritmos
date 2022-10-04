namespace TriangleLibrary
{
    public class Algorit
    {
        public int Triangulo(int[] A)
        {
            #region Original
            //for (int p = 0; p < A.Length - 2; p++)
            //{
            //    for (int q = p + 1; q < A.Length - 1; q++)
            //    {
            //        for (int r = q +1; r < A.Length; r++)
            //        {
            //            try
            //            {
            //                checked
            //                {
            //                    if (A[p] + A[q] > A[r] &&
            //                    A[q] + A[r] > A[p] &&
            //                    A[r] + A[p] > A[q])
            //                    {
            //                        return 1;
            //                    }
            //                }
            //            }
            //            catch (OverflowException)
            //            {

            //                return 1;
            //            }
            //        }
            //    }
            //}
            //return 0;
            #endregion
            A = A.Where(x => x > 0).ToArray();
            if (A.Length < 3)return 0;
            Array.Sort(A);
            for (int i = A.Length - 1; i > 1; i--)
            {
                long R = A[i];
                long Q = A[i - 1];
                long P = A[i - 2];
                if (Q + P > R)
                    return 1;
            }
            return 0;
        }
    }
}