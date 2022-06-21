using RecorrerUnaMatrizBiblioteca;

Console.WriteLine("Recorriendo una Matriz!");

Algoritmo algoritmoRecorrerMatriz = new Algoritmo();
int k = 3;
string matrizRecorrida = algoritmoRecorrerMatriz.RecorrerMatriz(k);
Console.WriteLine("k={0}, MatrizRecorrida={1}", k, matrizRecorrida);
