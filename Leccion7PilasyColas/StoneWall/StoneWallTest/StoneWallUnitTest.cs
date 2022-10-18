using StoneWallLibrary;

namespace StoneWallTest
{
    [TestClass]
    public class StoneWallUnitTest
    {
        [TestMethod]
        public void Prueba885798748Regresa7()
        {
            Algoritm alg = new();
            int[] H_evaluado = { 8,8,5,7,9,8,7,4,8 };
            int obtenido;
            int esperado = 7;
            obtenido = alg.MinBlocks(H_evaluado);
            Assert.AreEqual(obtenido, esperado);
        }
    }
}