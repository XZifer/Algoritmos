namespace FishLibrary
{
    public class Algoritm
    {
        public int LiveFish(int[] A, int[] B)
        {
            int lives = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (i == 0 && B[i] == 0 ||
                    i == A.Length - 1 && B[i] == 1)
                {
                    lives++;
                    A[i] = 0;
                }
                else 
                {
                    for (int j = i + 1; j < A.Length; j++)
                    {

                    }
                }
            }
            return lives;
        }
    }
}