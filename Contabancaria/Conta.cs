using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contabancaria
{
    public class Conta
    {
        private string nome;
        private double saldo;


        public Conta(string nome, double saldo)
        {
            this.nome = nome;
            this.saldo = saldo;
        }

        public string getNome() { return this.nome;  }
        public double getSaldo() { return this.saldo;  }

        public void Debito(double valor)
        {
            if(valor < saldo && valor > 0)
            {
                saldo = saldo - valor;
            }

        }

        public void Credito(double valor)
        {
            if(valor > 0)
            {
                saldo = valor + saldo;
            }

        }

    }
}
