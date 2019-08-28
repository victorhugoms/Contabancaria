using Microsoft.VisualStudio.TestTools.UnitTesting;
using Contabancaria;

namespace UnitTestProjectContaBancaria
{
    [TestClass]
    public class Contateste
    {
        [TestMethod]
        public void DebitoComValorValido()
        {
            double saldoInicial = 10;
            double valorDebito = 2;
            double saldoEsperado = 8;

            Conta conta = new Conta("jão", saldoInicial);
            conta.Debito(valorDebito);

            double saldoReal= conta.getSaldo();

            Assert.AreEqual(saldoEsperado, saldoReal, 0.001, "Debito Realizado de forma incorreta");
        }

        [TestMethod]
        public void CreditoComValorValido()
        {

            double saldoInicial = 10;
            double valorCredito = 10;
            double saldoEsperado = 20;

            Conta conta = new Conta("jão", saldoInicial);
            conta.Credito(valorCredito);

            double saldoReal = conta.getSaldo();

            Assert.AreEqual(saldoEsperado, saldoReal, 0.001, "Credito Realizado de forma incorreta");
        }
        [TestMethod]
        public void DebitoComValorMaiorQueSaldo()
        {

            double saldoInicial = 2;
            double valorDebito = 10;
            double saldoEsperado = 8;

            Conta conta = new Conta("jão", saldoInicial);
            conta.Debito(valorDebito);

            double saldoReal = conta.getSaldo();

            Assert.AreEqual(saldoEsperado, saldoReal, 0.001, "Debito Realizado de forma incorreta");
        }



    }
}
