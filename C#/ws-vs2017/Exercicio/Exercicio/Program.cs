using System;

namespace Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            int nquartos = 10;
            Aluguel[] aluguel = new Aluguel[nquartos];
            Console.Write("Quantas pessoas vão se hospedar? ");
            int n = int.Parse(Console.ReadLine());
            
       

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Hóspede #" + i);
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Numero do quarto: ");
                int numero = int.Parse(Console.ReadLine());
                aluguel[numero - 1] = new Aluguel { Nome = nome, Email = email, Quarto = numero };

            }

            for (int i = 0; i < nquartos; i++)
            {
                if (aluguel[i] != null)
                {
                    Console.WriteLine("Quartos ocupados:");
                    Console.Write((i + 1) + ": ");
                    Console.WriteLine("Nome: " 
                        + aluguel[i].Nome 
                        + "/// Email: " 
                        + aluguel[i].Email);
                    
                }
            }
            
        }
    }
}
