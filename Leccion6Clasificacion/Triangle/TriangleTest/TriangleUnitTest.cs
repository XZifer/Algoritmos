using TriangleLibrary;

namespace TriangleTest
{
    [TestClass]
    public class TriangleUnitTest
    {
        [TestMethod]
        public void Prueba10251820Regresa1()
        {
            Algorit al = new();
            int[] A_evaluar = { 10,2,5,1,8,20 };
            int obtenido;
            int esperado = 1;
            obtenido = al.Triangulo(A_evaluar);
            Assert.AreEqual(obtenido, esperado);    
        }

        [TestMethod]
        public void Prueba105051Regresa0()
        {
            Algorit al = new();
            int[] A_evaluar = { 10,50,5,1 };
            int obtenido;
            int esperado = 0;
            obtenido = al.Triangulo(A_evaluar);
            Assert.AreEqual(obtenido, esperado);
        }
        [TestMethod]
        public void Prueba533Regresa1()
        {
            Algorit al = new();
            int[] A_evaluar = { 5,3,3 };
            int obtenido;
            int esperado = 1;
            obtenido = al.Triangulo(A_evaluar);
            Assert.AreEqual(obtenido, esperado);
        }
    }
}