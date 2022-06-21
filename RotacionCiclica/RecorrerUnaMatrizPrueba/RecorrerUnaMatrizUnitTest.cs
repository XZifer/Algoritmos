using RecorrerUnaMatrizBiblioteca;

namespace RecorrerUnaMatrizPrueba
{
    [TestClass]
    public class RecorrerUnaMatrizUnitTest
    {
        
        [TestMethod]
        public void Prueba3Regresa97638()
        {
            //Arrange = Arreglar o adecuar la prueba unitaria
            Algoritmo algoritmoRecorrerMatriz = new Algoritmo();
            int Kevaluado = 3;
            string obtenido;
            string esperado = "9,7,6,3,8";
            //Act = Actuar o realizar la prueba
            obtenido = algoritmoRecorrerMatriz.RecorrerMatriz(Kevaluado);
            //Assert = Afirmar, verificar que la prueba cumple la condicion k=3 RecorrerMatriz=[9,7,6,3,8]
            Assert.AreEqual(esperado, obtenido);
        }
        [TestMethod]
        public void Prueba1Regresa63897()
        {
            //Arrange = Arreglar o adecuar la prueba unitaria
            Algoritmo algoritmoRecorrerMatriz = new Algoritmo();
            int Kevaluado = 1;
            string obtenido;
            string esperado = "6,3,8,9,7";
            //Act = Actuar o realizar la prueba
            obtenido = algoritmoRecorrerMatriz.RecorrerMatriz(Kevaluado);
            //Assert = Afirmar, verificar que la prueba cumple la condicion k=1 RecorrerMatriz=[6,3,8,9,7]
            Assert.AreEqual(esperado, obtenido);
        }
        [TestMethod]
        public void Prueba4Regresa89763()
        {
            //Arrange = Arreglar o adecuar la prueba unitaria
            Algoritmo algoritmoRecorrerMatriz = new Algoritmo();
            int Kevaluado = 4;
            string obtenido;
            string esperado = "8,9,7,6,3";
            //Act = Actuar o realizar la prueba
            obtenido = algoritmoRecorrerMatriz.RecorrerMatriz(Kevaluado);
            //Assert = Afirmar, verificar que la prueba cumple la condicion k=4 RecorrerMatriz=[8,9,7,6,3]
            Assert.AreEqual(esperado, obtenido);
        }
    }
}