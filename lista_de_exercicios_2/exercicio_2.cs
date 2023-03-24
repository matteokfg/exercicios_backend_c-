using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaEstruturaCondicional
{ 
    public class Program 
    { 
        static void Main(string[] args) 
        { 
            double a = 0; 
            double b = 0; 
            double c = 0; 
            string entrada = ""; 

            do 
            { 
                Console.Write("Primeiro lado: (utilizar virgula para casa decimal)"); 
                a = double.Parse(Console.ReadLine()); 

                Console.Write("Segundo lado: (utilizar virgula para casa decimal)"); 
                b = double.Parse(Console.ReadLine()); 

                Console.Write("Terceiro lado: (utilizar virgula para casa decimal)"); 
                c = double.Parse(Console.ReadLine()); 

                if ((a < (b + c)) && (b < (a + c)) && (c < (a + b)) && (a > 0) && (b > 0) && (c > 0)) 
                { 
                    if ((a == b) && (a == c)) 
                    { 
                        Console.WriteLine("Equilatero"); 
                    } 
                    else 
                    { 
                        if ((a == b) || (a == c) || (b == c)) 
                        { 
                            Console.WriteLine("Isosceles"); 
                        } 
                        else 
                        { 
                            Console.WriteLine("Escaleno"); 
                        } 
                    } 
                } 
                else 
                { 
                    Console.WriteLine("Nao eh triangulo"); 
                } 
  
                Console.WriteLine(" Continuar -> 1 \n Sair -> 2"); 
                entrada = Console.ReadLine(); 

            } while (entrada != "2"); 
        } 
    } 
} 
