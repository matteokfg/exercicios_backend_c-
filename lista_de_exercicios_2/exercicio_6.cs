using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaEstruturaCondicional
{
    public class Exer_circuito
    {
        public static void Main(string[] args)
        {
            double valor;
            char etiqueta;

            Console.WriteLine("Qual o valor do produto: ");
            valor = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Qual a etiqueta do produto (A, C, D, J): ");
            etiqueta = Convert.ToChar(Console.ReadLine().ToUpper());

            switch (etiqueta)
            {
                case 'A':
                    Console.WriteLine("A vista em dinheiro ou cheque, recebe 10% de desconto");
                    valor = valor * 0.9;
                    Console.WriteLine($"O valor final do produto eh: R$ {valor}");
                    break;
                case 'C':
                    Console.WriteLine("A vista no cartão de crédito, recebe 15% de desconto");
                    valor = valor * 0.85;
                    Console.WriteLine($"O valor final do produto eh: R$ {valor}");
                    break;
                case 'D':
                    Console.WriteLine("Em duas vezes, preço normal de etiqueta sem juros");
                    valor = valor / 2;
                    Console.WriteLine($"O valor final do produto eh: 2 vezes de R$ {valor}");
                    break;
                case 'J':
                    Console.WriteLine("Em duas vezes, preço normal de etiqueta mais juros de 10%");
                    valor = valor * 1.1;
                    valor = valor / 2;
                    Console.WriteLine($"O valor final do produto eh: 2 vezes de R$ {valor}");
                    break;
                default:
                    Console.WriteLine("Etiqueta nao encontrada");
                    break;
            }
        }
    }
}
