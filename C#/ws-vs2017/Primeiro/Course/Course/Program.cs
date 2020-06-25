using System;
using System.Globalization;
namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta c;
            Console.Write("Entre o número da conta: ");
            int conta = int.Parse(Console.ReadLine());
            Console.Write("Entre o Titular da conta: ");
            string nome = Console.ReadLine();
            
            Console.Write("Deseja fazer um depósito inicial? ");
            string dp = Console.ReadLine();
            if (dp == "s" || dp == "S")
            {
                Console.Write("Entre o valor de depósito inicia: ");
                double idp = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                c = new Conta(conta, nome, idp);
            }
            else
            {
                c = new Conta(conta, nome);
            }
            Console.WriteLine("\nDados da Conta:\n" + c);

            Console.Write("Entre um valor para depósito: ");
            double saldod = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            c.Deposito(saldod);

            Console.WriteLine("Dados da conta atualizados:\n" + c);

            Console.Write("Entre um valor para saque: ");
            double saldos = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            c.Saque(saldos);

            Console.WriteLine("Dados da conta atualizados:\n" + c);
        }
    }
}
