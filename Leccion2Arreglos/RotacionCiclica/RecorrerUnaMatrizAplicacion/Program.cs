using RecorrerUnaMatrizBiblioteca;

Console.WriteLine("Recorriendo una Matriz!");

Algoritmo algoritmoRecorrerMatriz = new Algoritmo();
int k = 3;
int[] A = { 3, 8, 9, 7, 6 };
int[] matrizRecorrida = algoritmoRecorrerMatriz.RecorrerMatriz(A,k);
Console.WriteLine(k);
foreach (int i in matrizRecorrida)
{
    Console.Write(i + ",");
}
