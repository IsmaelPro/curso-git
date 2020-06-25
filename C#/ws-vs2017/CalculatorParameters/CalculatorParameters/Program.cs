using System;

namespace CalculatorParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Usando Param em um código \n");
            int s = Calculadora.Sum(1, 2, 3);
            int s2 = Calculadora.Sum(4, 5, 6);

            Console.WriteLine(s);
            Console.WriteLine(s2);

            Console.WriteLine("/////////////////////////\n");

            Console.WriteLine("Usando ref  e out em um código:");


            int a = 10;
            int triple;
            Calculadora.Triple(a, out triple);
            Console.WriteLine("Número triplicado usando função triple com out: " + triple);
            Calculadora.Duplo(ref a);
            Console.WriteLine("a usando ref na função Duplo: " + a);



        }
    }
}
