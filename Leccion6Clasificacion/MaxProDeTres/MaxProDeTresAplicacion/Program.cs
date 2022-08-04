using MaxProDeTresBiblioteca;

Console.WriteLine("Maximo Producto De Tres, Por Indices De Un Arreglo");
Algoritm algoritm = new Algoritm();
int[] A = { -3, 1, 2, -2, 5, 6 };
int max;
Console.Write("{");
for (int i = 0; i < A.Length; i++)
{
    Console.Write(" {0}", A[i]);
}
Console.Write(" }");
max = algoritm.Solucion(A);
Console.WriteLine("El Maximo es: {0}",max);


