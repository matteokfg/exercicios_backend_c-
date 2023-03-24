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
            Console.Write("Informe seu nome: "); 
            string nome = Console.ReadLine(); 

            Console.Write("Informe seu sexo (F/M): "); 
            char sexo = char.Parse(Console.ReadLine()); 

            if (sexo.ToString().ToUpper() == "M") 
            {
                Console.WriteLine("Ilmo Sr. " + nome); 
            }
            else if (sexo.ToString().ToUpper() == "F") 
            {
                Console.WriteLine("Ilma Sra. " + nome); 
            }
            else 
            {
                Console.WriteLine("O sexo não foi informado corretamente."); 
            }
        }
    }
}
