using System;
using System.Collections.Generic;
public class Eexercicio_array_02
{
    public static void Main()
    {
        int n_convidados = 9;
        // colocaria 900, mas como é um exemplo e nao um caso real, coloquei 9 para nao ocupar muita memoria e ser mais rapido
        string[] convidados = new string[n_convidados];

        for (int i = 0; i < convidados.Length; i++)
        {
            Console.WriteLine($"Escreva o nome do {i+1} convidado:");
            convidados[i] = Console.ReadLine();
        }
        
        Console.WriteLine(convidados.Length);
        Console.WriteLine(convidados[0]);
        Console.WriteLine(convidados[1]);
        Console.WriteLine(convidados[convidados.Length - 1]);
    }
}
