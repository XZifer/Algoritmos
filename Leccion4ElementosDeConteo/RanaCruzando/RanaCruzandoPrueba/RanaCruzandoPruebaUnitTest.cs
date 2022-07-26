using RanaCruzandoBiblioteca;

namespace RanaCruzandoPrueba
{
    [TestClass]
    public class RanaCruzandoPruebaUnitTest
    {
        [TestMethod]
        public void pruebaX5A13142354obten()
        {
            //Arrange = Arreglar o adecuar la PruebaUnitaria
            Algoritmo algRanaCruzando = new Algoritmo();
            int X_evaluado = 5;
            int[] A = {1,3,1,4,2,3,5,4};
            int obtenido;
            int esperado = 6;
            //Act = Actuar o realizar la prueba
            obtenido = algRanaCruzando.Solucion(X_evaluado, A);
            //Assert = Afirmar o verificar que la prueba cumple la condicion
            Assert.AreEqual(obtenido, esperado);
        }
        [TestMethod]
        public void pruebaX6A13142354obten()
        {
            //Arrange = Arreglar o adecuar la PruebaUnitaria
            Algoritmo algRanaCruzando = new Algoritmo();
            int X_evaluado = 6;
            int[] A = { 1, 3, 1, 4, 2, 3, 5, 4 };
            int obtenido;
            int esperado = -1;
            //Act = Actuar o realizar la prueba
            obtenido = algRanaCruzando.Solucion(X_evaluado, A);
            //Assert = Afirmar o verificar que la prueba cumple la condicion
            Assert.AreEqual(obtenido, esperado);
        }
    }
}