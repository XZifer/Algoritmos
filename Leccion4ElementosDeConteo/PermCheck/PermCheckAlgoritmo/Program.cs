using PermCheckBiblioteca;

Console.WriteLine(" ¿Permuta? : 1-Si 0-No");

Algoritmo AlgPermuta = new Algoritmo();
int[] A = {1};
int permuta = AlgPermuta.PermutaCheck(A);
Console.WriteLine(permuta);