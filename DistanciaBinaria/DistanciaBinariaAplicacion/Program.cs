// See https://aka.ms/new-console-template for more information
using DistanciaBinariaBiblioteca;

Console.WriteLine("Distancia binaria!");

Algoritmo algoritmo = new Algoritmo();
int N = 529;
int distanciaBinaria = algoritmo.CalculaDistanciaBinaria(N);
Console.WriteLine("N={0}, DistanciaBinaria={1}", N, distanciaBinaria);
