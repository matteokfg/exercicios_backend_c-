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
        int codigo = 7; 

        Console.Write("Coloque o codigo do produto: "); 
        codigo =Convert.ToInt32(Console.ReadLine()); 
  
        if (codigo == 1) 
        { 
            Console.WriteLine("Alimento nao-perecivel"); 
        } 
        else if ((codigo >= 2) && (codigo <= 4)) 
        { 
            Console.WriteLine("Alimento perecivel"); 
        } 
        else if ((codigo == 5) && (codigo == 6)) 
        { 
            Console.WriteLine("Vestuario"); 
        } 
        else if ((codigo >= 8) && (codigo <= 15)) 
        { 
            Console.WriteLine("Higiene pessoal"); 
        } 
        else 
        { 
            Console.WriteLine("Codigo Invalido"); 
        } 
        } 
    } 
} 
