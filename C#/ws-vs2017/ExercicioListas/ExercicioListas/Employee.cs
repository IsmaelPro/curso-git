using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioListas
{
    class Employee
    {
        public static int Id { get; set; }
        public  static string Name { get; set; }
        public  static double Salary { get; set; }

        public Employee (int id, string name, double salary)

        {
            Name = name;
            Id = id;
            Salary = Salary;

        }

        public void IncreaseSalary(double percentage)
        {
            percentage += percentage / 100; 
        }

        public override string ToString()
        {
            return Name
                + Id
                + Salary;
        }

    }
}
