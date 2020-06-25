using System;
using System.Collections.Generic;


namespace Primeiro
{
    class Employee
    {
        public  int Id { get; set; }
        public  string Name { get; set; }
        public  double Salary { get; set; }

        public Employee(int id, string name, double salary)

        {
            Name = name;
            Id = id;
            Salary = salary;

        }

        public void IncreaseSalary(double percentage)
        {
            percentage += percentage / 100;
        }

        public override string ToString()
        {
            return "nome: "
                + Name
                + "\n Id: "
                + Id
                + "\n Salario: "
                + Salary;
        }
    }
}
