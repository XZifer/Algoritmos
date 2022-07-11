using PermutacionBiblioteca;

Console.WriteLine("Obteniendo Permuta");

Algoritmo AlgPermuta = new Algoritmo();
int[] A = {4,1,3,2};
int permuta = AlgPermuta.Permuta(A);
Console.WriteLine(permuta);