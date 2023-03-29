using System.Globalization;

namespace ListaEstruturaRepetição
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ano = 2006;
            double salario = 2000.00;
            double aumento = salario * 0.015;
            salario += aumento;

            while (ano < DateTime.Now.Year)
            {
                aumento = 2 * aumento;
                salario += aumento;
                ano++;
            }

            Console.WriteLine();
            Console.WriteLine("O salário atual do funcionário é: " + salario.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
