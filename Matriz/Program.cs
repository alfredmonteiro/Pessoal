using System;

namespace Matriz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantidade de linhas da matriz:");
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine("Quantidade de colunas da matriz:");
            int n = int.Parse(Console.ReadLine());

            int[,] mat = new int[m, n];

            for (int i=0;i<m;i++)
            {
                string[] valores = Console.ReadLine().Split(' ');
                for (int j=0;j<n;j++)
                {
                    mat[i, j] = int.Parse(valores[j]);
                }
            }

            Console.WriteLine("Escreva o elemento procurado");
            int test = int.Parse(Console.ReadLine());

            int k=0, l=0;

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (mat[i,j] == test)
                    {
                        k = i;
                        l = j;

                        if (l > 0)
                        {
                            Console.WriteLine("Left: " + mat[k, l - 1]);
                        }
                        if (k > 0)
                        {
                            Console.WriteLine("Up: " + mat[k - 1, l]);
                        }
                        if (l < n - 1)
                        {
                            Console.WriteLine("Right: " + mat[k, l + 1]);
                        }
                        if (k < m - 1)
                        {
                            Console.WriteLine("Down: " + mat[k + 1, l]);
                        }
                        Console.WriteLine("==============================");
                    }
                }
            }

        }
    }
}
