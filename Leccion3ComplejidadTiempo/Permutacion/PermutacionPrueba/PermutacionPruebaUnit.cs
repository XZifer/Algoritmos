using PermutacionBiblioteca;

namespace PermutacionPrueba
{
    [TestClass]
    public class PermutacionPruebaUnit
    {
        [TestMethod]
        public void Prueba4132Regresa5()
        {
            //Arrange = Arreglar o adecuar la prueba unitaria
            Algoritmo algoritmoPermuta = new Algoritmo();
            int[] A_evaluada = {4,1,3,2};
            int obtenido;
            int esperado = 5;
            //Act = Actuar o realizar la prueba
            obtenido = algoritmoPermuta.Permuta(A_evaluada);
            //Assert = Afirmar, verificar que la prueba cumple la condicion A_evaluada=[4,1,3,2]
            Assert.AreEqual(esperado, obtenido);

        }
        [TestMethod]
        public void Prueba4122Regresa3()
        {
            //Arrange = Arreglar o adecuar la prueba unitaria
            Algoritmo algoritmoPermuta = new Algoritmo();
            int[] A_evaluada = {4,1,2,2};
            int obtenido;
            int esperado = 3;
            //Act = Actuar o realizar la prueba
            obtenido = algoritmoPermuta.Permuta(A_evaluada);
            //Assert = Afirmar, verificar que la prueba cumple la condicion A_evaluada=[4,1,2,2]
            Assert.AreEqual(esperado, obtenido);
        }
    }
}