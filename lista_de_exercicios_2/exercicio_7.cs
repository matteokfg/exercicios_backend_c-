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
            Console.Write("Informe a sua data de nascimnto (dd/MM/yyyy): "); 
            DateTime dataNascimento = DateTime.Parse(Console.ReadLine()); 

            DateTime hoje = DateTime.Today; 

            int idade = hoje.Year - dataNascimento.Year; 

            if (idade >= 18) 
            { 
                Console.Write($"Você tem {idade} anos, portanto já pode votar "); 
                Console.WriteLine("e conseguir a Carteira de Habilitação"); 
            } 
            else if (idade >= 16) 
            { 
                Console.Write($"Você tem {idade} anos, portanto já pode votar, mas "); 
                Console.WriteLine("ainda não pode conseguir a Carteira de Habilitação"); 
            } 
            else 
            { 
                Console.Write($"Você tem {idade} anos, portanto ainda não pode votar "); 
                Console.WriteLine("nem conseguir a Carteira de Habilitação"); 
            } 
        } 
    } 
} 
