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

            Console.Write("Informe um valor que esteja na faixa de 1 a 9: "); 

            double valor = double.Parse(Console.ReadLine()); 

  

            if (valor >= 1 && valor <= 9) 

            { 

                Console.WriteLine("O valor está na faixa permitida"); 

            } 

            else 

            { 

                Console.WriteLine("O valor está fora da faixa permitida"); 

            } 

        } 

    } 

} 
