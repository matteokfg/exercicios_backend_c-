using System;

public class Exercicio1
{
    public static void Main()
    {
        int convidadosNoivo = 300;
        int convidadosNoiva = 600;
        int convidadosPresentesNoivo = 400;
        int convidadosPresentesNoiva = 400;
        // verifica se todos os convidados vieram
        if (convidadosNoivo == convidadosPresentesNoivo && convidadosNoiva == convidadosPresentesNoiva)
        {
            Console.WriteLine("Todos os convidados compareceram e sem nenhum penetra");
        }
        // verifica quantos convidados do noivo vieram
        if (convidadosNoivo > convidadosPresentesNoivo)
        {
            Console.WriteLine($"Alguns convidados do noivo nao vieram ({convidadosNoivo-convidadosPresentesNoivo})");
        }
        else if (convidadosNoivo < convidadosPresentesNoivo)
        {
            Console.WriteLine($"Vieram penetras do noivo ({convidadosPresentesNoivo-convidadosNoivo})");
        }
        // verifica quantos convidados da noiva vieram
        if (convidadosNoiva < convidadosPresentesNoiva)
        {
            Console.WriteLine($"Vieram penetras da noiva ({convidadosPresentesNoiva-convidadosNoiva})");
        }
        else
        {
            Console.WriteLine($"Alguns convidados da noiva nao vieram ({convidadosNoiva-convidadosPresentesNoiva})");
        }
        // verifica a quantidade dos convidados que vieram (nulo, pouco ou mais)
        if (convidadosPresentesNoiva <= 10 && convidadosPresentesNoivo <= 10)
        {
            Console.WriteLine($"Poucas pessoas vieram.\n Noiva: {convidadosPresentesNoiva} / Noivo: {convidadosPresentesNoivo}");
        }
        else if (convidadosPresentesNoiva != 0 || convidadosPresentesNoivo != 0)
        {
            Console.WriteLine($"Vieram convidados. \n Noiva: {convidadosPresentesNoiva} / Noivo: {convidadosPresentesNoivo}");
        }
        else
        {
            Console.WriteLine("Nao veio nenhum convidado");
        }
    }
};
