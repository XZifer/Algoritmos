using CintaEquilibrioBiblioteca;

namespace CintaEquilibrioPrueba
{
    [TestClass]
    public class CintaEquiPruebaUnit
    {
        [TestMethod]
        public void prueba31243Obten1()
        {
            //Arrange = Arreglar o adecuar la PruebaUnitaria
            Algoritmo AlgMinimo = new Algoritmo();
            int[] A_evaluado = {3,1,2,4,3};
            int obtenido;
            int esperado = 1;
            //Act = Actuar o realizar la prueba
            obtenido = AlgMinimo.DiferenciaMinima(A_evaluado);
            //Assert = Afirmar o verificar que la prueba cumple la condicion
            Assert.AreEqual(obtenido, esperado);
        }

        [TestMethod]
        public void prueba_10001000Obten2000()
        {
            //Arrange = Arreglar o adecuar la PruebaUnitaria
            Algoritmo AlgMinimo = new Algoritmo();
            int[] A_evaluado = {-1000,1000};
            int obtenido;
            int esperado = 2000;
            //Act = Actuar o realizar la prueba
            obtenido = AlgMinimo.DiferenciaMinima(A_evaluado);
            //Assert = Afirmar o verificar que la prueba cumple la condicion
            Assert.AreEqual(obtenido, esperado);
        }
        [TestMethod]
        public void prueba113Obten1()
        {
            //Arrange = Arreglar o adecuar la PruebaUnitaria
            Algoritmo AlgMinimo = new Algoritmo();
            int[] A_evaluado = {1,1,3};
            int obtenido;
            int esperado = 1;
            //Act = Actuar o realizar la prueba
            obtenido = AlgMinimo.DiferenciaMinima(A_evaluado);
            //Assert = Afirmar o verificar que la prueba cumple la condicion
            Assert.AreEqual(obtenido, esperado);
        }
    }
}