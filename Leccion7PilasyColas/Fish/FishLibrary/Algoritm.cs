using System;

namespace FishLibrary
{
    public class Algoritm
    {
        public int LiveFish(int[] A, int[] B)
        {
            Stack<int> upstreamSchool = new Stack<int>();
            Stack<int> downstreamSchool = new Stack<int>();

            for (int i = 0; i < A.Length; i++)
            {
                if (B[i] == 0)
                {
                    upstreamSchool.Push(i);
                }
                else
                {
                    downstreamSchool.Push(i);
                }
                while (upstreamSchool.Count > 0 && downstreamSchool.Count > 0)
                {
                    int downstreamFish = downstreamSchool.Peek();
                    int upstreamFish = upstreamSchool.Peek();

                    if (downstreamFish < upstreamFish)
                    {
                        if (A[downstreamFish] > A[upstreamFish]) { upstreamSchool.Pop(); }
                        else { downstreamSchool.Pop(); }
                    }
                    else
                    {
                        break;
                    }
                }
            }
            return downstreamSchool.Count + upstreamSchool.Count;
        }
    }
}