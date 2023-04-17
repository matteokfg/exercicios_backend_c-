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
        public static int[] LerEntradas(int NumeroDeEntradas, string msg = "Entrada: ")
        {
            int[] array_num = new int[NumeroDeEntradas];
            int entrada;

            for (int i = 0; i < NumeroDeEntradas; i++)
            {
                Console.Write(msg);
                entrada = Convert.ToInt32(Console.ReadLine());
                array_num[i] = entrada;
            }

            return array_num;
        }

        public static void ImprimirEntradas(int[] array_entradas_num)
        {
            Console.WriteLine("As entradas sao:");
            foreach (int i in array_entradas_num)
            {
                Console.WriteLine(" " + i + " ");
            }
        }

        public static int[] GerarEntradas(int numero_entradas)
        {
            int[] entradas = new int[numero_entradas];
            Random r = new Random(DateTime.Now.Millisecond);

            for (int i = 0; i < numero_entradas; i++)
            {
                int num_r = r.Next(0, 100);
                entradas[i] = num_r;
            }

            return entradas;

        }

        public static void Exercicio_01()
        {
            ImprimirEntradas(LerEntradas(10));
            // ImprimirEntradas(GerarEntradas(10));
        }

        public static bool ValidarMatricula(int nova, int[] matriculas)
        {
            bool existe = true;

            foreach (int matricula in matriculas)
            {
                if (matricula == nova)
                {
                    return false;
                }
            }

            return existe;
        }
        public static void Exercicio_02()
        {
            int[] matriculas = new int[10];

            for (int i = 0; i < matriculas.Length; i++)
            {
                Console.WriteLine("Numero da nova matricula: ");
                int novaMatricula = Convert.ToInt32(Console.ReadLine());
                if (ValidarMatricula(novaMatricula, matriculas))
                {
                    matriculas[i] = novaMatricula;
                }
                else
                {
                    i--;
                }
            } 
        }

        public static void Exercicio_03()
        {
            int v = 0;
            string entrada;
            int[] dados = new int[1];
            int[] arr = new int[1];
            do
            {
                Console.Write($"Coloque o valor do indice {v}: ");
                entrada = Console.ReadLine();
                if (entrada != "999")
                {
                    dados[v] = Convert.ToInt32(entrada);
                    v++;
                    dados = dados.Concat(arr).ToArray();
                }
            } while(entrada != "999");

            Console.WriteLine("O array invertido eh: ");
            for (int i = dados.Length-2; i >= 0; i--)
            {
                Console.WriteLine(dados[i]);
            }
        }
        static void Main(string[] args)
        {
            // Exercicio_01();
            // Exercicio_02();
            // Exercicio_03();
        }
    }
}

