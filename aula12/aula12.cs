using System;

class Principal
{
    static void Main()
    {
        /*
        Console.WriteLine("Hello, World!"); // Imprime a frase

        if (10 < 1)
        {
            Console.WriteLine("sim");
        }
        else
        {
            Console.WriteLine("Não");
        }
        Console.WriteLine();
        Console.ReadLine(); // Aguarda a entrada do usuário para fechar a janela
        */
        Console.WriteLine("Qual a nota do aluno 1?");
        double nota1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Qual a nota do aluno 2?");
        double nota2 = double.Parse(Console.ReadLine());
        double soma = (nota1 + nota2) / 2;
        Console.WriteLine("A média das notas é: " + soma);
        if (soma >= 7)
        {
            Console.WriteLine("Aluno aprovado!");
        }
        else if (soma <= 6)
        {
            Console.WriteLine("Aluno reprovado!");
        }
    }
}
