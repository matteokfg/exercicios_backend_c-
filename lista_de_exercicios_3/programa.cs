using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ListadeExercicio
{
    internal class Programa
    {
        public static void Exercicio_2()
        {
            int n;
            Console.WriteLine("Quantos numeros?");
            n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"{Environment.NewLine} {n}º numeros pares" + Environment.NewLine);
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"{2*i}");
            }
            Console.WriteLine($"{Environment.NewLine} {n}º numeros impares" + Environment.NewLine);
            for (int i = 1; i < 2*n; i+=2)
            {
                Console.WriteLine($"{i}");
            }
        }

        public static void Exercicio_4()
        {
            for (int i = 0; i<10; i++)
            {
                for(int j = 0; j <= 10; j++)
                {
                    Console.WriteLine($"{i} x {j} = {i*j}");
                }
                Console.WriteLine(Environment.NewLine);
            }
        }

        public static void Exercicio_6()
        {
            int idade;
            int count_21 = 0, count_50 =0;
            do
            {
                Console.Write("Coloque a idade: ");
                idade = Convert.ToInt32(Console.ReadLine());

                if (idade >= 0)
                {
                    if (idade < 21)
                    {
                        count_21 += 1;
                    }
                    else if (idade > 50)
                    {
                        count_50 += 1;
                    }
                }
            } while (idade != -99);
            Console.WriteLine($"Pessoas com menos de 21 anos: {count_21} {Environment.NewLine}Pessoas com mais de 50 anos: {count_50}");
        }

        public static void Exercicio_8()
        {
            string nome;
            string rev_nome = "";

            Console.WriteLine("Coloque o nome: ");
            nome = Console.ReadLine();

            for (int i = nome.Length - 1; i >= 0; i--)
            {
                rev_nome += nome[i];
            }
            Console.WriteLine(rev_nome);
        }

        public static void Exercicio_10()
        {
            double media=0;

            Console.WriteLine("Quantos alunos tem na sual aula? ");
            int qt_alunos = Convert.ToInt32(Console.ReadLine());

            for(int i = 0; i< qt_alunos; i++)
            {
                Console.WriteLine($"Nota do aluno {i + 1}");
                double nota = Convert.ToDouble(Console.ReadLine());

                media += nota;
            }
            media /= qt_alunos;
            Console.WriteLine($"A media da sala eh: {media}");
        }

        public static void Exercicio_12()
        {
            for (int i = 1;i <= 100;i++)
            {
                Console.WriteLine(i);
            }

            int p = 1;
            while (p<=100)
            {
                Console.WriteLine(p);
                p++;
            }

            int l = 1;
            do
            {
                Console.WriteLine(l);
                l++;
            }while (l<101);
        }

        public static void Exercicio_14()
        {
            int entrada;
            do
            {
                Console.WriteLine($" 1- Km/h para m/s {Environment.NewLine} 2- m/s para Km/h {Environment.NewLine} 3- Sair");
                entrada = Convert.ToInt32(Console.ReadLine());

                if ((entrada==1)||(entrada==2))
                {
                    if (entrada==1)
                    {
                        Console.Write("Qual o valor em Km/h? ");
                        double velocidade = Convert.ToDouble(Console.ReadLine());
                        velocidade /= 3.6;
                        Console.WriteLine($"A velocidade eh {velocidade} m/s");
                    }
                    else
                    {
                        Console.Write("Qual o valor em m/s? ");
                        double velocidade = Convert.ToDouble(Console.ReadLine());
                        velocidade *= 3.6;
                        Console.WriteLine($"A velocidade eh {velocidade} Km/h");
                    }
                }
            }while (entrada!=3);
        }
        static void Main(string[] args)
        {
            //Exercicio_2();
            //Exercicio_4();
            //Exercicio_6();
            //Exercicio_8();
            //Exercicio_10();
            //Exercicio_12();
            //Exercicio_14();
        }
    }
}

