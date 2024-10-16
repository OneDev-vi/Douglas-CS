using System;

class Principal
{
    static void Main()
    {
        Console.WriteLine("Voçe vai no mercado e voce so tem 10 Reais e voçe fica em duvida entre pasoca ou pão qual voçe escolhe?");
        string op = Console.ReadLine();
        int op1 = Convert.ToInt32(Console.ReadLine());
        switch(op)
        {
            case "pão":
                Console.WriteLine("Voce escolheu pão!");
                break;
            case "pasoca":
                Console.WriteLine("Voce escolheu pasoca!");
                break;
            default:
                Console.WriteLine("Opção inválida!");
                break;
        }
        if (op == "pão")
        {
            Console.WriteLine("Você acaba de gastar um pão!");
        }
        else if (op == "pasoca")
        {
            Console.WriteLine("Você acaba de gastar uma pascoa!");
        }
        else
        {
            Console.WriteLine("Opção inválida!");
        }
        switch(op1)
        {
            case 1:
            case 2:
                Console.WriteLine("1");
                break;
            case 3:
            case 4:
                Console.WriteLine("2");
                break;
            case 5:
            case 6:
                Console.WriteLine("3");
                break;
            default:
                Console.WriteLine("Opção inválida!");
                break;
            int l = 3;
        }
        Console.ReadLine();
    }
}
