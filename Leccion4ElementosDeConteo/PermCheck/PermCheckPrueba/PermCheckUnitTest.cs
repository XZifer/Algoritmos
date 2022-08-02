using PermCheckBiblioteca;

namespace PermCheckPrueba
{
    [TestClass]
    public class PermCheckUnitTest
    {
        [TestMethod]
        public void Prueba4132Regresa1()
        {
            //Arrange = Arreglar o adecuar la prueba unitaria
            Algoritmo algoritmoPermuta = new Algoritmo();
            int[] A_evaluada = { 4, 1, 3, 2 };
            int obtenido;
            int esperado = 1;
            //Act = Actuar o realizar la prueba
            obtenido = algoritmoPermuta.PermutaCheck(A_evaluada);
            //Assert = Afirmar, verificar que la prueba cumple la condicion A_evaluada=[4,1,3,2]
            Assert.AreEqual(esperado, obtenido);

        }
        [TestMethod]
        public void Prueba413Regresa0()
        {
            //Arrange = Arreglar o adecuar la prueba unitaria
            Algoritmo algoritmoPermuta = new Algoritmo();
            int[] A_evaluada = {4, 1, 3};
            int obtenido;
            int esperado = 0;
            //Act = Actuar o realizar la prueba
            obtenido = algoritmoPermuta.PermutaCheck(A_evaluada);
            //Assert = Afirmar, verificar que la prueba cumple la condicion A_evaluada=[4,1,3,2]
            Assert.AreEqual(esperado, obtenido);

        }
        [TestMethod]
        public void Prueba1Regresa1()
        {
            //Arrange = Arreglar o adecuar la prueba unitaria
            Algoritmo algoritmoPermuta = new Algoritmo();
            int[] A_evaluada = {1};
            int obtenido;
            int esperado = 1;
            //Act = Actuar o realizar la prueba
            obtenido = algoritmoPermuta.PermutaCheck(A_evaluada);
            //Assert = Afirmar, verificar que la prueba cumple la condicion A_evaluada=[4,1,3,2]
            Assert.AreEqual(esperado, obtenido);

        }
    }
}