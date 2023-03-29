namespace ListaEstruturaRepetição
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 1;
            int num2 = 1;
            int produto = 0;

            while (num1 != 0 && num2 != 0)
            {
                Console.Write("Informe o primeiro fator da multiplicação: ");
                num1 = int.Parse(Console.ReadLine());
                Console.Write("Informe o segundo fator da multiplicação: ");
                num2 = int.Parse(Console.ReadLine());

                produto = num1 * num2;

                Console.WriteLine();
                Console.WriteLine("O produto dos números digitados é: " + produto);
                Console.WriteLine();
            }
        }
    }
}
