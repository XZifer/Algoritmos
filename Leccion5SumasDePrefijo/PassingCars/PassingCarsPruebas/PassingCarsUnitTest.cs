using PassingCarsBiblioteca;

namespace PassingCarsPruebas
{
    [TestClass]
    public class PassingCarsUnitTest
    {
        [TestMethod]
        public void pruebaA01011obten5()
        {
            //Arrange = Arreglar o adecuar la PruebaUnitaria
            Algoritmo algAutosConsecutivos = new Algoritmo();
            int[] A_evaluado = { 0, 1, 0, 1, 1 };
            int obtenido;
            int esperado = 5;
            //Act = Actuar o realizar la prueba
            obtenido = algAutosConsecutivos.Solucion(A_evaluado);
            //Assert = Afirmar o verificar que la prueba cumple la condicion
            Assert.AreEqual(obtenido, esperado);
        }
        [TestMethod]
        public void pruebaA00011obten6()
        {
            //Arrange = Arreglar o adecuar la PruebaUnitaria
            Algoritmo algAutosConsecutivos = new Algoritmo();
            int[] A_evaluado = { 0, 0, 0, 1, 1 };
            int obtenido;
            int esperado = 6;
            //Act = Actuar o realizar la prueba
            obtenido = algAutosConsecutivos.Solucion(A_evaluado);
            //Assert = Afirmar o verificar que la prueba cumple la condicion
            Assert.AreEqual(obtenido, esperado);
        }
        [TestMethod]
        public void pruebaA10011obten4()
        {
            //Arrange = Arreglar o adecuar la PruebaUnitaria
            Algoritmo algAutosConsecutivos = new Algoritmo();
            int[] A_evaluado = { 1, 0, 0, 1, 1 };
            int obtenido;
            int esperado = 4;
            //Act = Actuar o realizar la prueba
            obtenido = algAutosConsecutivos.Solucion(A_evaluado);
            //Assert = Afirmar o verificar que la prueba cumple la condicion
            Assert.AreEqual(obtenido, esperado);
        }
    }
}