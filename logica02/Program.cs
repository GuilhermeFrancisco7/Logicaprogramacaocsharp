using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logica02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Definindo as constantes
            const int valor1 = 10;
            const int valor2 = 5;

            // Soma
            int soma = valor1 + valor2;
            Console.WriteLine($"Soma: {valor1} + {valor2} = {soma}");

            // Subtração
            int subtracao= valor1 - valor2;
            Console.WriteLine($"Subtração: {valor1} - {valor2} = {subtracao}");

            // Multiplicação
            int multiplicacao = valor1 * valor2;
            Console.WriteLine($"Multiplicação: {valor1} * {valor2} = {multiplicacao}");

            // Divisão
            int divisao = valor1 / valor2;
            Console.WriteLine($"Divisão: {valor1} / {valor2} = {divisao}");

            // Resto de Divisão
            int resto = valor1 % valor2;
            Console.WriteLine($"Resto de Divisão: {valor1} % {valor2} = {resto}");

            // Potenciação (usando math.Pow para calcular a potência)
            double potencia = Math.Pow(valor1, valor2);
            Console.WriteLine($"potencia: {valor1} elevado a {valor2} = {potencia}");

            // Ordem de Grandeza

            // Exemplo 1: Sem parênteses
            int resultado1 = 3 + 5 * 2; // Multiplicação tem prioridade
            Console.WriteLine($"Resultado 1 (Sem  Parênteses): 3 + 5 *2 = {resultado1}");

            // Exemplo 1: com parênteses
            int resultado2 = (3 + 5) * 2; // Parênteses alteram a ordem
            Console.WriteLine($"Resultado 2 (com  Parênteses): (3 + 5) *2 = {resultado2}");

            // Exemplo 2: Sem parênteses
            double resultado3 = 8 / 4 + 3; // Divisão tem prioridade
            Console.WriteLine($"Resultado 3 (Sem  Parênteses): 8 / 4 + 3 = {resultado3}");

            // Exemplo 2: Com parênteses
            double resultado4 = 8 / (4 + 3); // Parênteses alteram a ordem
            Console.WriteLine($"Resultado 4 (comm  Parênteses): 8 / (4 + 3) = {resultado4}");


            Console.ReadLine();
        }



    }
}
