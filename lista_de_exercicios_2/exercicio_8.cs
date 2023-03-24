using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization; 

namespace ListaEstruturaCondicional 
{ 
    internal class Program 
    {
        static void Main(string[] args)
        { 
            int num1, num2, resultado; 
            string operacao; 

            Console.Write("Coloque o primeiro numero: "); 
            num1 = Convert.ToInt32(Console.ReadLine()); 

            Console.WriteLine($"Escolha a operacao: {Environment.NewLine}" + 
                $" Soma -> A {Environment.NewLine}" + 
                $" Subtracao -> S {Environment.NewLine}" + 
                $" Multiplicacao -> M {Environment.NewLine}" + 
                $" Divisao Inteira -> Q"); 
            operacao = Console.ReadLine(); 

            Console.Write("Coloque o segundo numero: "); 
            num2 = Convert.ToInt32(Console.ReadLine()); 

            if (operacao == "A") 
            { 
                resultado = num1 + num2; 
                Console.WriteLine($"O resultado eh: {resultado}"); 
            } 
            else if (operacao == "S") 
            { 
                resultado = num1 - num2; 
                Console.WriteLine($"O resultado eh: {resultado}"); 
            } 
            else if (operacao == "M") 
            { 
                resultado = num1 * num2; 
                Console.WriteLine($"O resultado eh: {resultado}"); 
            } 
            else if (operacao == "Q") 
            { 
                resultado = Convert.ToInt32(num1 / num2); 
                Console.WriteLine($"O resultado eh: {resultado}"); 
            } 
            else 
            { 
                Console.WriteLine("Ops, nao temos essa operacao"); 
            } 
        } 
    } 
} 
