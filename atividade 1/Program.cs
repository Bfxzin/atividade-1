using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite um valor entre 1 e 9:");
        int valor = int.Parse(Console.ReadLine());

        if (valor >= 1 && valor <= 9)
        {
            Console.WriteLine("O valor está na faixa permitida");
        }
        else
        {
            Console.WriteLine("O valor está fora da faixa permitida");
        }
    }
}

//atividade 1//