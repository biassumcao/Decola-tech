using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ordenacao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordenacao.Tests
{
    [TestClass()]
    public class OrdenacaoTests
    {
        [TestMethod()]
        public void bubbleSortTest()
        {
            int[] vetor = { 4, 6, 2, 7, 1 };
            int [] esperado = { 1, 2, 4, 6, 7 };

            var ordenacao = new Ordenacao();
            int [] resultado = ordenacao.bubbleSort(vetor);
            Assert.AreEqual(esperado, resultado);
        }
    }
}