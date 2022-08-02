using DistintoBiblioteca;

Console.WriteLine("Cuantos Distintos?");

int[] A = { 2, 1, 1, 2, 3, 1 };
int distintos;
Console.WriteLine("Cuantos numeros Distintos tiene el Arreglo A:");
Console.WriteLine("A = {2,1,1,2,3,1}");
Algoritmo algoritmo = new Algoritmo();
distintos = algoritmo.Solucion(A);
Console.WriteLine("Distintos:{0}",distintos);
