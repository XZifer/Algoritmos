using DistintoBiblioteca;

namespace DistintoPruebas
{
    [TestClass]
    public class DistintoUnitTest
    {
        [TestMethod]
        public void pruebaA211231obten3()
        {
            //Arrange = Arreglar o adecuar la PruebaUnitaria
            Algoritmo algoritmo = new Algoritmo();
            int[] A_evaluado = {2,1,1,2,3,1};
            int obtenido;
            int esperado = 3;
            //Act = Actuar o realizar la prueba
            obtenido = algoritmo.Solucion(A_evaluado);
            //Assert = Afirmar o verificar que la prueba cumple la condicion
            Assert.AreEqual(obtenido, esperado);
        }
    }
}