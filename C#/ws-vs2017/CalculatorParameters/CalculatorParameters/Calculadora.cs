
using System;
namespace CalculatorParameters
{
    class Calculadora
    {
        public static int Sum(params int[] numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }

        public static void Triple(int origin, out int triple)
        {
            triple = origin * 3;
        }

        public static void  Duplo(ref int x)
        {
            x = x * 2;
        }
    }
}
