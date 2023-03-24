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
            Console.Write("Informe a quantidade de horas aula do primeiro professor: "); 
            double horas1 = double.Parse(Console.ReadLine()); 

            Console.Write("Informe o valor por hora recebido pelo primeiro professor: "); 
            double valor1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); 

            Console.Write("Informe a quantidade de horas aula do segundo professor: "); 
            double horas2 = double.Parse(Console.ReadLine()); 

            Console.Write("Informe o valor por hora recebido pelo segundo professor: "); 
            double valor2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); 

 
            double salario1 = horas1 * valor1; 
            double salario2 = horas2 * valor2; 
  
            if (salario1 > salario2) 
            { 
                Console.WriteLine("O primeiro professor recebe um salário total maior"); 
            } 
            else if (salario2 > salario1) 
            { 
                Console.WriteLine("O segundo professor recebe um salário total maior"); 
            } 
            else 
            { 
                Console.WriteLine("Os dois professores recebem um salário total igual"); 
            } 
        } 
    } 
}
