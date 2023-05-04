using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ListadeExercicio
{
    internal class Programa
    {
        public static int[,] LerEntradasMatriz(int l, int c)
        {
            int[,] matriz = new int[l, c];

            for (int i = 0; i < l; i++)
            {
                for (int j = 0;j < c; j++)
                {
                    Console.WriteLine("Valor: ");
                    matriz[i,j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            return matriz;
        }

        public static void ImprimirMatriz(int[,] matriz)
        {
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write(matriz[i, j] + "| ");
                }
                Console.WriteLine(Environment.NewLine);
            }
        }

        public static int[,] GerarMatriz(int l, int c)
        {
            int[,] matriz = new int[l, c];
            Random r = new Random(DateTime.Now.Millisecond);

            for (int i = 0;i<matriz.GetLength(0); i++)
            {
                for (int j = 0;j<matriz.GetLength(1); j++)
                {
                    int valor_r = r.Next(0, 10);
                    matriz[i, j] = valor_r;
                }
            }

            return matriz;
        }

        public static void SomarMatrizes(int[,] mA, int[,] mB)
        {
            
            if ((mA.GetLength(0) == mB.GetLength(0)) && (mA.GetLength(1) == mB.GetLength(1)))
            {
                int[,] matrizR = new int[mA.GetLength(0), mA.GetLength(1)];
                for (int l = 0; l < mA.GetLength(0); l++)
                {
                    for (int c = 0; c < mB.GetLength(1); c++)
                    {
                        matrizR[l,c] = mA[l, c] + mB[l, c];
                    }
                }

                Console.WriteLine("Resultado: ");
                ImprimirMatriz(matrizR);
            }
            else
            {
                Console.WriteLine("Matrizes de tamanhos diferentes, impossivel somar");
            }
        }

        public static void Exercicio_1()
        {
            string entrada;
            do
            {
                Console.WriteLine("Qual a quantidade de linhas da 1 matriz? ");
                int l1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Qual a quantidade de colunas da 1 matriz? ");
                int c1 = Convert.ToInt32(Console.ReadLine());

                //int[,] matriz1 = GerarMatriz(l1, c1);

                int[,] matriz1 = LerEntradasMatriz(l1, c1);

                ImprimirMatriz(matriz1);

                Console.WriteLine("Qual a quantidade de linhas da 2 matriz? ");
                int l2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Qual a quantidade de colunas da 2 matriz? ");
                int c2 = Convert.ToInt32(Console.ReadLine());

                //int[,] matriz2 = GerarMatriz(l2, c2);

                int[,] matriz2 = LerEntradasMatriz(l2, c2);

                ImprimirMatriz(matriz2);

                Console.WriteLine("--------------------SOMA-----------------------");

                SomarMatrizes(matriz1, matriz2);

                Console.WriteLine("Continuar ou sair? ");
                entrada = Console.ReadLine();
            } while (entrada != "sair");
        }

        public static int[,] MultiplicarMatriz(int[,] mA, int[,] mB)
        {
            if ((mA.GetLength(0) == mB.GetLength(0)) && (mA.GetLength(1) == mB.GetLength(1)))
            {
                int[,] matrizR = new int[mA.GetLength(0), mA.GetLength(1)];
                for (int l = 0; l < mA.GetLength(0); l++)
                {
                    for (int c = 0; c < mB.GetLength(1); c++)
                    {
                        matrizR[l, c] = mA[l, c] * mB[l, c];
                    }
                }

                return matrizR;
            }
            else
            {
                Console.WriteLine("Matrizes de tamanhos diferentes, impossivel somar");
                return null;
            }
        }

        public static void Exercicio_2()
        {
            Console.WriteLine("Primeira matriz -"+Environment.NewLine);
            //int[,] matriz1 = GerarMatriz(3, 3);
            int[,] matriz1 = LerEntradasMatriz(3, 3);
            ImprimirMatriz(matriz1);

            Console.WriteLine("Vezes");

            Console.WriteLine(Environment.NewLine + "Segunda matriz -" + Environment.NewLine);
            //int[,] matriz2 = GerarMatriz(3, 3);
            int[,] matriz2 = LerEntradasMatriz(3, 3);
            ImprimirMatriz(matriz2);

            int[,] matrizR = MultiplicarMatriz(matriz1, matriz2);

            Console.WriteLine("Resultado: ");
            ImprimirMatriz(matrizR);
        }


        public static int[,] envolta_do_X(int y, int x, int[,] matriz)
        {
            matriz[y, x] = -19;
            
            for (int i = -1; i < 2; i++)
            {
                for (int j = -1; j < 2; j++)
                {
                    if ((i != 0) || (j != 0))
                    {
                        try
                        {
                            matriz[y + i, x + j] += 1;
                        }
                        catch (IndexOutOfRangeException e)
                        {
                            continue;
                        }
                    }
                }
            }
            
            return matriz;
        }

        public static void ImprimirTabela(int[,] tabela)
        {
            Console.Write($"  = ");
            for (int k = 0; k < tabela.GetLength(1); k++)
            {
                Console.Write($"{k + 1}| ");
            }
            Console.WriteLine(Environment.NewLine);
            for (int i = 0; i < tabela.GetLength(0); i++)
            {
                Console.Write($"{i + 1} = ");
                for (int j = 0; j < tabela.GetLength(1); j++)
                {
                    if (tabela[i, j] < 0)
                    {
                        Console.Write("X" + "| ");
                    }
                    else
                    {
                        Console.Write(tabela[i, j] + "| ");
                    }

                }
                Console.WriteLine(Environment.NewLine);
            }
        }
        public static void Exercicio_4()
        {
            int[,] tabela = new int[10, 10];

            for (int p = 0; p < tabela.GetLength(0); p++)
            {
                Console.Write($"Coloque a posicao, entre 1 e 10, Y do {p+1} ponto: ");
                int y = Convert.ToInt32(Console.ReadLine()) - 1;
                if ((y < 0) || (y >= 10))
                {
                    Console.WriteLine(Environment.NewLine + "Numero fora de index" + Environment.NewLine);
                    p--;
                    continue;
                }

                Console.Write($"Coloque a posicao, entre 1 e 10, X do {p + 1} ponto: ");
                int x = Convert.ToInt32(Console.ReadLine()) - 1;

                if ((x < 0) || (x >= 10))
                {
                    Console.WriteLine(Environment.NewLine + "Numero fora de index" + Environment.NewLine);
                    p--;
                    continue;
                }

                tabela = envolta_do_X(y, x, tabela);
            }

            ImprimirTabela(tabela);
        }

        static void Main(string[] args)
        {
            //Exercicio_1();
            //Exercicio_2();
            //Exercicio_4();
        }
    }
}

