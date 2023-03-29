namespace ListaEstruturaRepetição
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero = 0;
            int somaPar = 0;
            int somaImpar = 0;

            while (numero <= 1000)
            {
                Console.Write("Entre com um número inteiro e positivo: ");
                numero = int.Parse(Console.ReadLine());
                if (numero % 2 == 0)
                {
                    somaPar += numero;
                }
                else
                {
                    somaImpar += numero;
                }
            }

            Console.WriteLine();
            Console.WriteLine("A soma dos números pares digitados é: " + somaPar);
            Console.WriteLine("A soma dos números ímpares digitados é: " + somaImpar);
        }
    }
}
