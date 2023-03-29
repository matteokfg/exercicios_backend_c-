using System.Globalization;

namespace ListaEstruturaRepetição
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double valor = 0;
            double maiorValor = -999999999999999999999999999999999999999999.9;
            double menorValor = 9999999999999999999999999999999999999999999.9;

            for (int i = 1; i <= 15; i++)
            {
                Console.Write($"Entre com o {i}º número real: ");
                valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (valor > maiorValor)
                {
                    maiorValor = valor;
                }
                if (valor < menorValor)
                {
                    menorValor = valor;
                }
            }

            Console.WriteLine();
            Console.WriteLine("O maior valor digitado foi: " + maiorValor);
            Console.WriteLine("O menor valor digitado foi: " + menorValor);
        }
    }
}
