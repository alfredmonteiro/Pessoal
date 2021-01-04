using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Funcionario
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }

        public Funcionario(int id, string name, double salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }



        public void incrementoSalario(double porcentagem)
        {
            Salary += Salary*porcentagem/100;    
        }

        public override string ToString()
        {
            return Name + " , " + Salary + " , " + Id;
        }

    }
}
