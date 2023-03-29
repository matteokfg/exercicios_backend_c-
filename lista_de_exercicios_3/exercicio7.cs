namespace ListaEstruturaRepetição
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double numero;

            do
            {
                Console.Write("Informe um número entre 1 e 4: ");
                numero = double.Parse(Console.ReadLine());

                if (numero < 1 || numero > 4)
                {
                    Console.WriteLine("Entrada inválida.");
                    Console.WriteLine();
                }

            } while (numero < 1 || numero > 4);

            Console.WriteLine();
            Console.WriteLine("O número digitado foi: " + numero);
        }
    }
}
