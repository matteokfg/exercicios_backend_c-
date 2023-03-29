using System.Globalization;

namespace ListaEstruturaRepetição
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int contador = 0;
            double numero = 0;
            double maiorValor = -999999999999999999999999999999999999999999.9;

            while (contador < 10)
            {
                Console.Write("Digite um número: ");
                numero = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (numero > maiorValor)
                {
                    maiorValor = numero;
                }

                contador++;
            }

            Console.WriteLine();
            Console.WriteLine("O maior número digitado foi: " + maiorValor);
        }
    }
}
