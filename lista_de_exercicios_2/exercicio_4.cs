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
            double altura, peso; 
            string sexo; 

            Console.Write("Qual a sua altura(m): "); 
            altura = Convert.ToDouble(Console.ReadLine()); 

            Console.Write("Qual o seu sexo: "); 
            sexo = Convert.ToString(Console.ReadLine()); 

            if (sexo == "F") 
            { 
                peso = (62.1 * altura) - 44.7; 
                Console.WriteLine($"O peso ideal de uma pessoa do sexo {sexo}, com {altura}m, eh {peso}kg"); 
            } 
            else if (sexo == "M") 
            { 
                peso = (72.7 * altura) - 58; 
                Console.WriteLine($"O peso ideal de uma pessoa do sexo {sexo}, com {altura}m, eh {peso}kg"); 
            } 
            else 
            { 
                Console.WriteLine("Sexo nao identificado. Coloque M, para masculino, ou F, para feminino."); 
            } 
        } 
    } 
} 
