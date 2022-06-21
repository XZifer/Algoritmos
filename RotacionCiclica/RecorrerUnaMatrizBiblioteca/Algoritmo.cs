namespace RecorrerUnaMatrizBiblioteca
{
    public class Algoritmo
    {
        public string RecorrerMatriz(int k)
        {
            //Creamos una lista
            List<string> matriz = new List<string>();
            matriz.Add("3");
            matriz.Add("8");
            matriz.Add("9");
            matriz.Add("7");
            matriz.Add("6");
            //Recorremos el numero de veces K la matriz
            for (int i = 0; i < k; i++)
            {
                string numeroaRecorrer = matriz[matriz.Count - 1];
                matriz.Remove(numeroaRecorrer);
                matriz.Insert(0,numeroaRecorrer);
                
            }
            //imprimir cada uno de los valores de la lista
            string cadena = matriz.Aggregate((x, y) => x + "," + y);
            return cadena;
        }
    }
}