namespace StoneWallLibrary
{
    public class Algoritm
    {
        public int MinBlocks(int[] H)
        {
            int minimo = H.Max();
            int ladrillos = 0;
            for (int i = 1; i < H.Length; i++)
            {
                if (H[i] != minimo && H[i - 1] != H[i])
                {
                    ladrillos++;
                    if (minimo > H[i])
                    {
                        minimo = H[i];
                    }
                }

            }
            return ladrillos;
        }
    }
}