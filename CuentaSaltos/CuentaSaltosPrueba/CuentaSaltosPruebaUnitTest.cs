using CuentaSaltosBiblioteca;

namespace CuentaSaltosPrueba
{
    [TestClass]
    public class CuentaSaltosPruebaUnitTest
    {
        [TestMethod]
        public void pruebaX10Y85D30Obten3()
        {
            //Arrange = Arreglar o adecuar la PruebaUnitaria
            Algoritmo AlgCuentaSaltos = new Algoritmo();
            int X_evaluado = 10;
            int Y_evaluado = 85;
            int D_fijo = 30;
            int obtenido;
            int esperado = 3;
            //Act = Actuar o realizar la prueba
            obtenido = AlgCuentaSaltos.CuentaSaltos(X_evaluado,Y_evaluado,D_fijo);
            //Assert = Afirmar o verificar que la prueba cumple la condicion
            Assert.AreEqual(obtenido,esperado);
        }
    }
}