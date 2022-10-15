namespace AnidadosLibrary
{
    public class Algoritm
    {
        public int Anida(string S)
        {
            Stack<int> open = new Stack<int>();
            Stack<int> close = new Stack<int>();
            if (S == "")
            {
                return 1;
            }
            else if ( S[0] == ')' || S[S.Length-1] == '(')
            {
                return 0;
            }
            for (int i= 0; i < S.Length; i++)
            {
                if (S[i] == '(')
                {
                    open.Push(i);
                }
                else if (S[i] == ')')
                {
                    close.Push(i);
                }
                if (open.Count > 0 && close.Count > 0)
                {   
                    int openposition = open.Peek();
                    int closeposition = close.Peek();
                    if (openposition < closeposition)
                    {
                        open.Pop();
                        close.Pop();
                    }
                }
            }
            if (open.Count + close.Count == 0)
            {
                return 1;
            }
            return 0;
        }
    }
}