using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MinimalApi.Domain.Entities;

namespace Test.Domain.Entities
{
    [TestClass]
    public class VeiculoTest
    {
        [TestMethod]
        public void TestarGetSetPropriedades()
        {
            // Arrange
            var veiculo = new Veiculo();

            // Act
            veiculo.Id = 1;
            veiculo.Nome = "Kiateste";
            veiculo.Marca = "Picantoteste";
            veiculo.Ano = 2010;

            // Assert
            Assert.AreEqual(1,veiculo.Id);
            Assert.AreEqual("Kiateste",veiculo.Nome);
            Assert.AreEqual("Picantoteste",veiculo.Marca);
            Assert.AreEqual(2010,veiculo.Ano);

        }
    }
}