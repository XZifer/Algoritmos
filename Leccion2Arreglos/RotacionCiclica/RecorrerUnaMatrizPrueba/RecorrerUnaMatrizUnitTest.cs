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
            int[] Aevaluada = {3,8,9,7,6};
            int[] obtenido;
            int[] esperado = {9,7,6,3,8};
            //Act = Actuar o realizar la prueba
            obtenido = algoritmoRecorrerMatriz.RecorrerMatriz( Aevaluada,Kevaluado);
            //Assert = Afirmar, verificar que la prueba cumple la condicion k=3 RecorrerMatriz=[9,7,6,3,8]
            CollectionAssert.AreEqual(esperado, obtenido);
        }
        [TestMethod]
        public void Prueba1Regresa63897()
        {
            //Arrange = Arreglar o adecuar la prueba unitaria
            Algoritmo algoritmoRecorrerMatriz = new Algoritmo();
            int Kevaluado = 1;
            int[] Aevaluada = { 3, 8, 9, 7, 6 };
            int[] obtenido;
            int[] esperado = { 6, 3, 8, 9, 7 };
            //Act = Actuar o realizar la prueba
            obtenido = algoritmoRecorrerMatriz.RecorrerMatriz(Aevaluada,Kevaluado);
            //Assert = Afirmar, verificar que la prueba cumple la condicion k=1 RecorrerMatriz=[6,3,8,9,7]
            CollectionAssert.AreEqual(esperado, obtenido);
        }
        [TestMethod]
        public void Prueba4Regresa89763()
        {
            //Arrange = Arreglar o adecuar la prueba unitaria
            Algoritmo algoritmoRecorrerMatriz = new Algoritmo();
            int Kevaluado = 4;
            int[] Aevaluada = { 3, 8, 9, 7, 6 };
            int[] obtenido;
            int[] esperado = { 8, 9, 7, 6, 3 };
            //Act = Actuar o realizar la prueba
            obtenido = algoritmoRecorrerMatriz.RecorrerMatriz(Aevaluada,Kevaluado);
            //Assert = Afirmar, verificar que la prueba cumple la condicion k=4 RecorrerMatriz=[8,9,7,6,3]
            CollectionAssert.AreEqual(esperado, obtenido);
        }

        [TestMethod]
        public void PruebaVacioRegresaVacio()
        {
            //Arrange = Arreglar o adecuar la prueba unitaria
            Algoritmo algoritmoRecorrerMatriz = new Algoritmo();
            int Kevaluado = 100;
            int[] Aevaluada = { };
            int[] obtenido;
            int[] esperado = { };
            //Act = Actuar o realizar la prueba
            obtenido = algoritmoRecorrerMatriz.RecorrerMatriz(Aevaluada, Kevaluado);
            //Assert = Afirmar, verificar que la prueba cumple la condicion k=4 RecorrerMatriz=[8,9,7,6,3]
            CollectionAssert.AreEqual(esperado, obtenido);
        }

        [TestMethod]
        public void PruebaKIgualNRegresaA()
        {
            //Arrange = Arreglar o adecuar la prueba unitaria
            Algoritmo algoritmoRecorrerMatriz = new Algoritmo();
            int Kevaluado = 3;
            int[] Aevaluada = { 1, 2, 3, 5, 1 };
            int[] obtenido;
            int[] esperado = { 3, 5, 1, 1, 2 };
            //Act = Actuar o realizar la prueba
            obtenido = algoritmoRecorrerMatriz.RecorrerMatriz(Aevaluada, Kevaluado);
            //Assert = Afirmar, verificar que la prueba cumple la condicion k=4 RecorrerMatriz=[8,9,7,6,3]
            CollectionAssert.AreEqual(esperado, obtenido);
        }
    }
}