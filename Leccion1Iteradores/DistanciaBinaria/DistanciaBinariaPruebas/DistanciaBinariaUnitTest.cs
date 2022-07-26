using DistanciaBinariaBiblioteca;

namespace DistanciaBinariaPruebas
{
    [TestClass]
    public class DistanciaBinariaUnitTest
    {
        [TestMethod]
        public void Prueba9Regresa2()
        {
            //Arrange = Arreglar o adecuar la prueba unitaria
            Algoritmo algoritmoDistanciaBinaria = new Algoritmo();
            int evaluado = 9;
            int obtenido;
            int esperado = 2;
            //Act = Actuar o realizar la prueba
            obtenido = algoritmoDistanciaBinaria.CalculaDistanciaBinaria(evaluado);
            //Assert = Afirmar, verificar que la prueba cumple la condicion N=9 distanciabinaria=2
            Assert.AreEqual(esperado, obtenido);
        }

        [TestMethod]
        public void Prueba1041Regresa5()
        {
            //Arrange = Arreglar o adecuar la prueba unitaria
            Algoritmo algoritmoDistanciaBinaria = new Algoritmo();
            int evaluado = 1041;
            int obtenido;
            int esperado = 5;
            //Act = Actuar o realizar la prueba
            obtenido = algoritmoDistanciaBinaria.CalculaDistanciaBinaria(evaluado);
            //Assert = Afirmar, verificar que la prueba cumple la condicion N=9 distanciabinaria=2
            Assert.AreEqual(esperado, obtenido);
        }

        [TestMethod]
        public void Prueba32Regresa0()
        {
            //Arrange = Arreglar o adecuar la prueba unitaria
            Algoritmo algoritmoDistanciaBinaria = new Algoritmo();
            int evaluado = 32;
            int obtenido;
            int esperado = 0;
            //Act = Actuar o realizar la prueba
            obtenido = algoritmoDistanciaBinaria.CalculaDistanciaBinaria(evaluado);
            //Assert = Afirmar, verificar que la prueba cumple la condicion N=9 distanciabinaria=2
            Assert.AreEqual(esperado, obtenido);
        }
    }
}