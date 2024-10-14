using System;

class Principal
{
    static void Main()
    {
        int soma = 2 + 2;
        int vezes = 4 * 4;
        int dividir1 = 4 / 2;
        float dividir2 = 10 / 2.5f;
        int menos = 100 - 50;
        int comp = 4 * 2 + (5 + 5) - 5 + 4 * 5;
        bool res = 20 > 11;
        bool a = 10 > 2 && 10 > 8;
        bool b = 10 > 11 || 10 > 4;
        bool c = 20 > 25 && 20 > 1;
        bool d = 100 > 111 || 100 > 50;
        bool f = 10 > 23 || 10 > 20;
        bool d1 = 10 != 11;
        bool i = 2 == 2;
        bool i1 = 2 == 3;
        Console.WriteLine(soma);
        Console.WriteLine(vezes);
        Console.WriteLine(dividir1);
        Console.WriteLine(dividir2);
        Console.WriteLine(menos);
        Console.WriteLine(comp);
        Console.WriteLine(res);
        Console.WriteLine(a);
        Console.WriteLine(b);
        Console.WriteLine(c);
        Console.WriteLine(d);
        Console.WriteLine(f);
        Console.WriteLine(d1);
        Console.WriteLine(i);
        Console.WriteLine(i1);
    }
}