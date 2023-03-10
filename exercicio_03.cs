using System;
using System.Collections.Generic;
public class Exercicio_03
{
    public static void Main()
    {
        string entrada;

        List<string> frutas = new List<string>();
        List<string> frutasSemRepetidas = new List<string>();

        Console.WriteLine("Entre com a lista de frutas separadas por ',':");
        entrada = Console.ReadLine();

        frutas = entrada.Split(",").ToList();

        foreach (var el in frutas)
        {
            string frut = el.ToLower();

            string primeiraLetra = frut.Substring(0, 1).ToUpper();

            frut = primeiraLetra + frut.Substring(1, frut.Length-1);

            if (frutasSemRepetidas.Count == 0)
            {
                frutasSemRepetidas.Add(frut);
            }
            // list.Contains(el) tbm funciona
            else
            {
                if (frutasSemRepetidas.IndexOf(frut) == -1)
                {
                    frutasSemRepetidas.Add(frut);
                }
            }
        }

        Console.WriteLine("Resultado: "+Environment.NewLine);
        foreach (var fruta in frutasSemRepetidas)
        {
            Console.WriteLine(fruta);
        }
    }
}
