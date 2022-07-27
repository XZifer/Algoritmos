﻿namespace CuentaSaltosBiblioteca
{
    public class Algoritmo
    {
        public int CuentaSaltos(int X, int Y, int D)
        {
            //Declarando variable numero de saltos
            //Mientras que la posicion de la rana no es mayor que la posicion de la meta
            int numeroSaltos = 0;
            if (X >= Y)
            {
                numeroSaltos = 0;
            }
            else
            {
                numeroSaltos = (Y - X)/D;
                if ((numeroSaltos*D)+X < Y)
                {
                    numeroSaltos++;
                }
            }
            return numeroSaltos;
            #region Opcion 1
            //while (X < Y)
            //{
            //    X = X + D;
            //    numeroSaltos++;
            //}
            #endregion
        }
    }
}