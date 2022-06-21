using MatrizDisparBiblioteca;

Console.WriteLine("Obteniendo sin par de la matriz");

Algoritmo AlgMatrizDispar = new Algoritmo();
int[] A = { 9, 3, 9, 3, 9, 7, 9 };
int sinPar = AlgMatrizDispar.obtenerElementoDeapar(A);
Console.WriteLine("El elemento de la matriz A con valor {0} no tiene par",sinPar);