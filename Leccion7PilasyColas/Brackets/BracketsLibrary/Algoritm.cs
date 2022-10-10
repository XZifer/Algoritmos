namespace BracketsLibrary
{
    public class Algoritm
    {
        public int Anidar(string S)
        {
            if (S.Length == 0){return 1;}
            List<char> corchetesLista = new List<char>();
            foreach (char c in S)
            {
                PilaSuperior(c, corchetesLista); 
            }
            if (corchetesLista.Count == 0){ return 1; }
            return 0;
        }

        private void PilaSuperior(char c, List<char> corchetesLista)
        {
            if (corchetesLista.Count == 0)
            {
                corchetesLista.Add(c);
                return;
            }
            bool agregarcorchetes = true;
            if (corchetesLista[corchetesLista.Count - 1] == '(' && c == ')' ||
                corchetesLista[corchetesLista.Count - 1] == '{' && c == '}' ||
                corchetesLista[corchetesLista.Count - 1] == '[' && c == ']' )
            {
                corchetesLista.RemoveAt(corchetesLista.Count - 1);
                agregarcorchetes = false;
            }
            if (agregarcorchetes){ corchetesLista.Add(c); }
        }
    }
}