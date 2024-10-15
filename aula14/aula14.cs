using System;

class Principal
{
    static void Main()
    {
        Console.WriteLine("============================");
        Console.WriteLine("----------------------------");
        Console.WriteLine("==Preços de casa do jorgin==");
        Console.WriteLine("----------------------------");
        Console.WriteLine("============================");
        Console.WriteLine("-Casa Pequena Preço:R$50000-");
        Console.WriteLine("============================");
        Console.WriteLine("--Casa Media Preço:100000---");
        Console.WriteLine("============================");
        Console.WriteLine("--Casa Grande Preço:150000--");
        Console.WriteLine("============================");
        Console.WriteLine("=====Mansão-Preço:200000====");
        Console.WriteLine("----------------------------");
        Console.WriteLine("============================");
        Console.WriteLine("Escolha uma das casas acima-");
        string casaEscolhida = Console.ReadLine();
        Console.WriteLine("--Escolha o prço da casa!---");
        int preços = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("-----------------------------");
        Console.WriteLine("=============================");
        if (casaEscolhida == "Casa Pequena")
        {
            Console.WriteLine("Voçe escolheu a casa pequena!");
            if (preços >= 50000)
            {
                Console.WriteLine("Preço adequado para a casa pequena!");
            }
            else if (preços <= 49999)
            {
                Console.WriteLine("Com esse preço não foi possivel comprar a casa.");
            }
        else
        {
            Console.WriteLine("Opção inválida!");
        }
        }
        int ser = 12;
        if (casaEscolhida == "Casa Media")
        {
            Console.WriteLine("Voçe escolheu a casa média!");
            if (preços >= 100000)
            {
                Console.WriteLine("Preço adequado para a casa média!");
            }
            else if (preços <= 99999)
            {
                Console.WriteLine("Com esse preço não foi possivel comprar a casa.");
            }
        else
        {
            Console.WriteLine("Opção inválida!");
        }
        }
    
        if (casaEscolhida == "Casa Grande")
        {
            Console.WriteLine("Voçê escolheu a casa grande!");
            if (preços >= 150000)
            {
                Console.WriteLine("Preço adequado para a casa grande!");
            }
            else if (preços <= 149999)
            {
                Console.WriteLine("Com esse preço não foi possivel comprar a casa.");
            }
        else
        {
            Console.WriteLine("Opção inválida!");
        }
        }
        int sdf = 213;
        if (casaEscolhida == "Mansão")
        {
            Console.WriteLine("Voçê escolheu a mansão!");
            if (preços >= 200000)
            {
                Console.WriteLine("Preço adequado para a mansão!");
            }
            else if (preços <= 199999)
            {
                Console.WriteLine("Com esse preço não foi possivel comprar a mansão.");
            }
        else
        {
            Console.WriteLine("Opção inválida!");
        }
        }
        Console.ReadLine();
    }
}
