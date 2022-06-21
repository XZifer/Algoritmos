using MatrizDisparBiblioteca;

namespace MatrizDisparPrueba
{
    [TestClass]
    public class MatrizDisparPruebaUnitTest
    {
        [TestMethod]
        public void Prueba9393979Regresa7()
        {
            //Arrange = Arreglar o Adecuar la Prueba Unitaria
            Algoritmo AlgoritmoSinPar = new Algoritmo();
            int[] A_evaluado = {9,3,9,3,9,7,9};
            int obtenido;
            int esperado = 7;
            //Act = Actuar o Realizar la Prueba
            obtenido = AlgoritmoSinPar.obtenerElementoDeapar(A_evaluado);
            //Assert = Afirmar, verificar que la prueba cumple con la condicion A= {9,3,9,3,9,7,9} obtenerElementoDeapar = 7
            Assert.AreEqual(obtenido, esperado);
        }
    }
}