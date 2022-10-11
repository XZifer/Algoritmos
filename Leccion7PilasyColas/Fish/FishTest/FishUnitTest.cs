using FishLibrary;

namespace FishTest
{
    [TestClass]
    public class FishUnitTest
    {
        [TestMethod]
        public void Prueba1Regresa2()
        {
            Algoritm algoritm = new();
            int[] A_evaluado = { 4,3,2,1,5 };
            int[] B_evaluado = { 0,1,0,0,0 };
            int obtenido;
            int esperado = 2;
            obtenido = algoritm.LiveFish(A_evaluado, B_evaluado);
            Assert.AreEqual(obtenido, esperado);
        }
    }
}