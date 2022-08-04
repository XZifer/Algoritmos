using MaxProDeTresBiblioteca;

namespace MaxProDeTresPruebas
{
    [TestClass]
    public class MaxProDeTresUnitTest
    {
        [TestMethod]
        public void PruebaA_312_256Obten60()
        {
            //Arrange
            Algoritm algoritm = new Algoritm();
            int[] A_evaluada = { -3, 1, 2, -2, 5, 6 };
            int obtenido;
            int esperado = 60;
            //Act
            obtenido = algoritm.Solucion(A_evaluada);
            //Assert
            Assert.AreEqual(obtenido, esperado);
        }
    }
}