namespace ListaEstruturaRepetição
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double numero = 1;

            do
            {
                Console.Write("Entre com um número: ");
                numero = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine();
                Console.WriteLine($"O quadrado desse valor é: {numero * numero}");
                Console.WriteLine($"O cubo desse valor é: {numero * numero * numero}");
                Console.WriteLine($"A raiz quadrada desse valor é: {Math.Sqrt(numero)}");
                Console.WriteLine();

            } while (numero > 0);
        }
    }
}
