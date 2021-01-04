using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("São quantos funcionarios?");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();

            List<Funcionario> list = new List<Funcionario>();

            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine("Funcionário #"+i);
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("ID: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Salário: ");
                double salario = double.Parse(Console.ReadLine());
                list.Add(new Funcionario(id,nome,salario));
            }

            Console.WriteLine("Qaul o ID do funcionário que terá aumento?");
            int aumento = int.Parse(Console.ReadLine());

            Funcionario f1 = list.Find(x => x.Id == aumento);
            if(f1 != null)
            {
                Console.WriteLine("Qual porcentagem do aumento?");
                double p=double.Parse(Console.ReadLine());
                f1.incrementoSalario(p);
            }
            else
                Console.WriteLine("Empregado não existe!");

            Console.WriteLine();
            Console.WriteLine("Atualização realizada com sucesso!");

            foreach (Funcionario obj in list)
            {
                Console.WriteLine(obj);
            }

        }
    }
}
