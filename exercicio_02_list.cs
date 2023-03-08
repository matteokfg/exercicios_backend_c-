using System;
using System.Collections.Generic;
public class Exercicio_02_list
{
    public static void Main()
    {
        int n_convidado = 9;
        List<string> convidados = new List<string>();

        for (int i = 0; i < n_convidado; i++)
        {
            Console.WriteLine($"Nome do {i + 1} convidado:");
            convidados.Add(Console.ReadLine());
        }

        Console.WriteLine(convidados.Count);
        Console.WriteLine(convidados[0]);
        Console.WriteLine(convidados[1]);
        Console.WriteLine(convidados[convidados.Count-1]);
    }
}

