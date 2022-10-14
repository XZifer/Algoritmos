using AnidadosLibrary;

namespace AnidadosTest
{
    [TestClass]
    public class AnidadosUnitTest
    {
        [TestMethod]
        public void Prueba1Regresa1()
        {
            Algoritm algoritm = new();
            string S_evaluado = "(()())";
            int obtenido;
            int esperado = 1;
            obtenido = algoritm.Anida(S_evaluado);
            Assert.AreEqual(obtenido, esperado);    
        }
        [TestMethod]
        public void Prueba2Regresa0()
        {
            Algoritm algoritm = new();
            string S_evaluado = "(()";
            int obtenido;
            int esperado = 0;
            obtenido = algoritm.Anida(S_evaluado);
            Assert.AreEqual(obtenido, esperado);
        }
    }
}