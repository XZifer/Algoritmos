using CuentaSaltosBiblioteca;

Console.WriteLine("Contando los saltoz de una Rana!");

Algoritmo algContarSaltos = new Algoritmo();
int X = 10;
int Y = 85;
int D = 30;  
int SaltosTotales =algContarSaltos.CuentaSaltos(X,Y,D);
Console.WriteLine("La Rana debe de saltar {0} para llegar",SaltosTotales);