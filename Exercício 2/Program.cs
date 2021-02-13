using System;

namespace Exercício_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros;
            

            int n = int.Parse(Console.ReadLine());

            numeros = new int[n];

            string[] vetor = Console.ReadLine().Split(' ');

            for (int i =0;i<n;i++)
            {
                
                numeros[i] = int.Parse(vetor[i]);
            }

            int c = 0;

            Console.WriteLine();

            for (int i=0;i<n;i++)
            {
                if(numeros[i]%2==0)
                {
                    Console.Write(numeros[i] + " ");
                    c++;
                }
            }

            Console.WriteLine();
            Console.WriteLine(c);
        }
    }
}
