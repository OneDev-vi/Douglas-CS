using System;

class Principal
{
    enum r4 {manga, cerveja, maconha};
    static bool t5 = true;
    static void Main()
    {
        r4 y6 = r4.manga;
        r4 y7 = (r4)3;
        int y8 = (int)r4.cerveja;
        Console.WriteLine(y7);
        Console.WriteLine(y8);
        Console.WriteLine(y6);
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

        Console.WriteLine(t5);
        /*
        int eff = 232323;
        enum a {asa, dsd, aqw, por};
        Console.WriteLine(a.a);
        //a ds = (a)3;
        //Console.WriteLine(ds);
        */
    }
    void asj()
    {
        int sal = 243;
    }
}
