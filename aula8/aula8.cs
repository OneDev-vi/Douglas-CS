using System;

class Principal
{
    static void Main()
    {
        int v1;
        int v2;
        int soma;
        string nome;
        const int a = 32;
        Console.WriteLine("Qual o seu nome??> ");
        nome = Console.ReadLine();
        Console.WriteLine("Olá, " + nome + "! Esse é um novo programa em C#");
        Console.WriteLine("Digite o primeiro número: ");
        v1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Digite o segundo número: ");
        v2 = Convert.ToInt32(Console.ReadLine());
        soma = v1 + v2;
        Console.WriteLine("A soma dos dois números é: " + soma);
        int e = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(e);
        
        Console.ReadKey();
    }
}
