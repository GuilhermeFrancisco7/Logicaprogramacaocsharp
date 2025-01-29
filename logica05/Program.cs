using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logica05
{
    internal class Program
    {
        static void Main(string[] args)
        {
           /* for (int i = 0; i <= 10; i++) 
            {
                Console.WriteLine(i);
            }*/

            /*  for(; ; )
              {
                  Console.WriteLine("Este é u loop Infinito");

              }
              */

            // While
           int contador = 1;

            /* while (contador <= 5)
             {
                 Console.WriteLine(contador);
                 contador++;  // incrementa o contador
             }
            */
            int novocontador = 2;

            do {
                Console.WriteLine(novocontador);
                novocontador++;  // incrementa o contador
            }
            while (novocontador <= 10);

            // laço Foreach
            // uma lista de strings

            List<string> nomes = new List<string> { "Ana", "Carlos", "João", "Maria"};

            // Usando o foreach para percorrer a lista
            foreach (string nome in nomes)
            {
                Console.WriteLine(nome);    // imprime cada nome
            }
            // Um vetor de números inteiros
            int[] numeros = { 1, 2, 3, 4, 5 };
            foreach (int numero in numeros)
                { Console.WriteLine(numero); // Imprime cada número }
                Console.ReadLine();
        }
        

    }
}
