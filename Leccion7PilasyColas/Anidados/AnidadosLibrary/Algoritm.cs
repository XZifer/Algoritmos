namespace AnidadosLibrary
{
    public class Algoritm
    {
        public int Anida(string S)
        {
            Stack<char> open = new Stack<char>();
            Stack<char> close = new Stack<char>();
            if (S == "")
            {
                return 1;
            }
            foreach (char c in S)
            {
                if (c == '(')
                {
                    open.Push(c);
                }
                else if (c == ')')
                {
                    close.Push(c);
                }
                while (open.Count > 0 && close.Count > 0)
                {
                    open.Pop();
                    close.Pop();
                }
            }
            if (open.Count + close.Count > 0)
            {
                return 1;
            }
            return 0;
        }
    }
}