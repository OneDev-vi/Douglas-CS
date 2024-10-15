using System;

class Principal
{
    static void Main()
    {
        Console.WriteLine("Qual a nota do aluno??");
        double notas = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("A média das notas é: " + notas);
        string apro = "Reprovado";
        if (notas >= 60)
        {
            apro = "Aprovado";
        }
        else
        {
            apro = "Reprovado";
        }


        Console.WriteLine("Status: {0}", apro);
    }
}
