using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaEstruturaCondicional 
{ 
    internal class Program 
    { 
        static void Main(string[] args) 
        { 
            Console.Write("Informe o valor de A: "); 
            double a = double.Parse(Console.ReadLine()); 

            Console.Write("Informe o valor de B: "); 
            double b = double.Parse(Console.ReadLine()); 

            Console.Write("Informe o valor de C: "); 
            double c = double.Parse(Console.ReadLine()); 

            if (a + b < c) 
            { 
                Console.WriteLine($"{a} + {b} = {a + b}"); 
                Console.WriteLine($"{a + b} é menor que {c}"); 
            } 
            else 
            { 
                Console.WriteLine($"{a} + {b} = {a + b}"); 
                Console.WriteLine($"{a + b} não é menor que {c}"); 
            } 
        } 
    } 
} 
