using System;
using System.Globalization;


namespace Course
{
    class Conta
    {
        public int Numero { get; private set; }
        public string Nome { get; set; }
        public double SaldoConta { get; private set; }

        public Conta(int nConta, string nome)
        {
            Numero = nConta;
            Nome = nome;
           
        }
        public Conta(int nConta, string nome, double saldo) : this(nConta, nome)
        {
            SaldoConta = saldo;
        }

        public void Deposito(double saldo)
        {
             SaldoConta += saldo;
        }

        public void Saque (double saldo)
        {
            SaldoConta -= (saldo + 5.0);
        }

        public override string ToString()
        {
            return "Conta "
                + Numero
                + ", Titular: "
                + Nome
                + ", Saldo: $"
                + SaldoConta.ToString("F2", CultureInfo.InvariantCulture);
        }
    }

}
