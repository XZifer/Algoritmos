using PermCheckBiblioteca;

Console.WriteLine(" ¿Permuta? : 1-Si 0-No");

Algoritmo AlgPermuta = new Algoritmo();
int[] A = { 4, 1, 3, 2 };
int falta = AlgPermuta.PermutaCheck(A);
Console.WriteLine(falta);