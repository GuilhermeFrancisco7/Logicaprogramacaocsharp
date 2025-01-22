using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logica01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Varáveis
            char letra = 'A';
            string nome = "João";
            float temperatura = 36.5f;
            double salario = 12345.67;
            bool estaChovendo = true;

            // Alterando as Variáveis

            letra = 'B';
            nome = "Maria";
            temperatura = 37.0f;
            salario = 15000.50;
            estaChovendo = false;

            // Constantes
            const char simbolo = '$';
            const string saudacao = "Bem-vindo ao C#!";
            const float pi = 3.14159f;
            const double altura = 1.76;
            const bool eVerdade = false;

            

            Console.WriteLine(" Valores originais:");
            Console.WriteLine($"Letra : {letra}");
            Console.WriteLine($"Nome : {nome}");
            Console.WriteLine($"Temperatura : {temperatura}");
            Console.WriteLine($"Salário : {salario}");
            Console.WriteLine($"Está Chovendo?  {estaChovendo}");
           
            Console.WriteLine($"Símbolo : {simbolo}");
            Console.WriteLine($"Saudação: {saudacao}");
            Console.WriteLine($"Pi : {pi}");
            Console.WriteLine($"Altura: {altura}");
            Console.WriteLine($"É Verdade : {eVerdade}");
            Console.ReadLine();

            Console.ReadLine();




        }
    }
}
