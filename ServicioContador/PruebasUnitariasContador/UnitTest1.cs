using Microsoft.VisualStudio.TestTools.UnitTesting;
using ServicioWebContador;

namespace PruebasUnitariasContador
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void PruebaContador()
        {
            string textoEntrada = "Prueba TCS Desarrollador .NET, Alvaro Araujo Desarrollador";
            string palabra = "Desarrollador";
            int esperado = 2;

            ServicioContador servicio = new ServicioContador();
            int encontrados = servicio.ContadorDePalabras(textoEntrada, palabra);

            Assert.AreEqual(esperado, encontrados, string.Concat("Encontrados: ", encontrados));
        }
    }
}
