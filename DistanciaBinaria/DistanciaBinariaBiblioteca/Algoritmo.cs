namespace DistanciaBinariaBiblioteca
{
    public class Algoritmo
    {
        public int CalculaDistanciaBinaria(int N)
        {
            //Paso1:Convertir entero N en binario y guardarlo en string/arreglo de bits,etc.
            string binario = Convert.ToString(N, 2);
            //Paso2:Recorrer el arreglo calculando la distancia binaria
            Console.WriteLine("N[{0}],binario[{1}]", N, binario);
            string elementoActual;
            string elementoSiguiente;
            int contador = 0;
            int distanciaMaxima = 0;
            bool tengoQueContar = false;
            //Paso2.1 Recorrer el arreglo
            for (int posicion = 0; posicion < binario.Length -1; posicion++)
            {
                elementoActual = binario.Substring(posicion, 1);
                elementoSiguiente = binario.Substring(posicion+1, 1);
                if (elementoActual == "1" && elementoSiguiente == "0") //Paso2.2 detectar cuando hay un cambio de 1 a 0
                {
                    tengoQueContar = true;
                }
                if (elementoActual == "0" && elementoSiguiente == "1") //Paso2.3 detectar cuando hay un cambio de 0 a 1
                {
                    tengoQueContar = false;
                    if (contador>distanciaMaxima)
                    {
                        distanciaMaxima = contador;
                    }
                    contador = 0;
                }
                //Paso2.2.2 si tengoQueContar = true entonces contador+1
                if (tengoQueContar)
                {
                    contador++;
                }
                //Paso2.2.1 guardar la si es mayor que la distanciaMaxima 10000100101
            }
                
            //Paso3:Devolver el resultado

            //Valor por default
            return distanciaMaxima;
        }
    }
}