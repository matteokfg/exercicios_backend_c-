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

        public static List<int> Exercicio_04_a(string frase= "Numero de Matricula ")
        {
            List<int> lista = new List<int>();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(frase);
                lista.Add(Convert.ToInt32(Console.ReadLine()));
            }

            return lista;
        }

        public static void LerMatriculas(List<int> lista_matriculas)
        {
            bool presente = false;
            Console.WriteLine("Aperte quaquer botao para continuar... ");
            Console.ReadKey();

            Console.Write("Matricula a ser verificada: ");
            int matricula = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < (lista_matriculas.Count - 1 ); i++)
            {
                if (lista_matriculas[i]==matricula)
                {
                    presente = true;
                }
            }
            if (presente)
            {
                Console.WriteLine("Matricula presente!");
            }
            else
            {
                Console.WriteLine("Matricula nao presente.");
            }
        }

        public static void Exercicio_05()
        {
            double nota1, nota2, media;
            List<double> notas_1 = new List<double>();
            List<double> notas_2 = new List<double>();
            List<double> medias = new List<double>();

            do
            {
                Console.WriteLine(" --- Novo aluno! --- "+Environment.NewLine);
                Console.WriteLine("Colocar nota 1: ");
                nota1 = Convert.ToDouble(Console.ReadLine());
                if (nota1 != -1)
                {
                    notas_1.Add(nota1);

                    Console.WriteLine("Colocar nota 2: ");
                    nota2 = Convert.ToDouble(Console.ReadLine());
                    notas_2.Add(nota2);

                    media = (nota1 + nota2) / 2;
                    medias.Add(media);
                }
            } while (nota1 != -1);

            for(int i = 0; i < medias.Count; i++)
            {
                if (medias[i] < 6)
                {
                    Console.WriteLine($"REPROVADO aluno {i + 1} | Com media: {medias[i]}");
                }
                else
                {
                    Console.WriteLine($"APROVADO aluno {i + 1} | Com media: {medias[i]}");
                }
            }
        }
        
        public static void Exercicio_06(List<int> valores)
        {
            int soma = 0;

            for(int i = 0;i < (valores.Count - 1); i++)
            {
                if ((valores[i]%2) == 1)
                {
                    soma += valores[i];
                }
            }

            Console.WriteLine($"A soma dos valores impares da lista eh: {soma}");
        }

        public static void Exercicio_07(List<int> valores)
        {

            int moda = int.MinValue;
            uint quantidade_moda = 0;

            for (int i = 0; i < (valores.Count - 1); i++)
            {
                if (moda == valores[i])
                {
                    continue;
                }

                uint contador = 1;
                for (int j = 0; j < (valores.Count - 1); j++)
                {
                    if ((valores[i] == valores[j]) && (i!=j))
                    {
                        contador++;
                    }
                }

                if (quantidade_moda<contador)
                {
                    moda = valores[i];
                    quantidade_moda = contador;
                }

            }

            Console.WriteLine($"A moda eh: {moda} {Environment.NewLine} Com quantidade: {quantidade_moda}");
        }

        public static void Exercicio_07_com_dic(List<int> valores)
        {
            bool is_unico = false;
            List<int> valores_unicos = new List<int>();
            Dictionary<int, int> dicValorModa = new Dictionary<int, int>();
            int s;

            for (int i = 0; i < (valores.Count - 1); i++)
            {
                if (dicValorModa.TryGetValue(valores[i], out s))
                    continue;

                int count = 1;
                for (int j = 0; j < valores.Count - 1; j++)
                {
                    if ((valores[i] == valores[j]) && (i != j))
                    {
                        count++;
                    }

                }

                dicValorModa.Add(valores[i], count);

            }

            int modaKey = 0;
            int modaCount = 0;
            foreach (var keypair in dicValorModa)
            {
                if (keypair.Value > modaCount)
                {
                    modaCount = keypair.Value;
                    modaKey = keypair.Key;
                }

            }

            Console.WriteLine($"Moda = {modaKey} ModaCount: {dicValorModa[modaKey]}");
        }

        static void Main(string[] args)
        {
            // LerMatriculas(Exercicio_04_a());
            // Exercicio_05();
            // Exercicio_06(Exercicio_04_a("Valor: "));
            // Exercicio_07(Exercicio_04_a("Valor: "));
            // Exercicio_07_com_dic(Exercicio_04_a("Valor: "));
        }
    }
}

