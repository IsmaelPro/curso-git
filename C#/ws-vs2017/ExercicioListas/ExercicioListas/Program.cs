using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace ExercicioListas
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<Employee> list = new List<Employee>();
            Console.Write("Quantos funcionários serão registrados: ");
            int c = int.Parse(Console.ReadLine());

            for (int i = 0; i < c; i++)
            {
                Console.Write("Digite O Id do funcionário: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Digite O nome do funcionário: ");
                string name = Console.ReadLine();
                Console.Write("Digite O salário do funcionário: ");
                double salary = double.Parse(Console.ReadLine());
                list.Add(new Employee (id, name, salary));
                

            }

            
            


        }
    }
}
