namespace BracketsLibrary
{
    public class Algoritm
    {
        public int Anidar(string S)
        {
            if (S == "" || S.Length%2 != 0)
            {
                return 0;
            }
            for (int i = 0,j = S.Length -1; i < j; i++, j--)
            {
                if ((S[i] == '(' && S[j] != ')') ||
                    (S[i] == '{' && S[j] != '}') ||
                    (S[i] == '[' && S[j] != ']'))
                {
                    return 0;
                }
                return 1;
            }
            return 0;
        }
    }
}