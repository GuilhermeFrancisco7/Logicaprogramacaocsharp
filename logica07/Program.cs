using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logica07
{
    internal class Program
    {
        static async void Main(string[] args)
        {
            // Array
            
            string[] marcadecarro = { "Volvo", "BMW", "Ford", "BYD" };

            Console.WriteLine(marcadecarro);
            foreach (string carro in marcadecarro)
            {
                Console.WriteLine(carro);
              
            }
            for (int i = 0; i < marcadecarro.Length; i++) 
            {
                Console.WriteLine(marcadecarro[i]);
            }
            Console.WriteLine(string.Join(" , ", marcadecarro));


            // Mostrar apenas o valor de um índice
            Console.WriteLine(marcadecarro[2]);

            // Exibindo o comprimento do arry
            Console.WriteLine(marcadecarro.Length);

            // ordenação de forma Crescente string A - Z
            Array.Sort(marcadecarro);
            foreach(string ordenado in marcadecarro) 
            { 
                Console.WriteLine(ordenado);
            }
            //  Ordenação de forma Decrescente string Z - A
            Array.Reverse(marcadecarro);
            foreach (string ordenado in marcadecarro) 
            { 
                Console.WriteLine(ordenado);
            }
            // Análise do Array
            int[] numeros = { 5, 1, 8, 9 };
            Console.WriteLine(numeros.Max()); // maior Valor
            Console.WriteLine(numeros.Min()); // menor Valor
            Console.WriteLine(numeros.Sum()); // Soma todos os valores

            Console.ReadLine();

            
        }
    }
}
