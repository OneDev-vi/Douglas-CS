using System;

class Principal
{
    static int num1 = 2; //variaveis globais
    static void Main()
    {
        int num2 = 3;
        Console.WriteLine("Enter the principal amount:");
        //double principal = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine(num1);
        Console.WriteLine(num2);
        Principal p = new Principal();
    }

    void seila()
    {
        int num3 = 232;
        int caus = 4;
        Console.WriteLine(caus);
        Console.WriteLine(num1);
    }
}