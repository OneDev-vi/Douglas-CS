using System;

class Principal
{
    enum quantidade {pissa, lasanha, bolo, queijo};
    static void Main(String[] args)
    {
        inicio:
        Console.Clear();


        Console.WriteLine("Bem vindo ao restaurante 'O Pão do Cão'!");
        int comeu_pissa = 0;
        int comeu_lasanha = 0;
        int comeu_bolo = 0;
        int comeu_queijo = 0;
        Console.WriteLine("voçê pode comer apenas 4 coisas essa são. pisssa, lasanha, bolo, queijo");
        Console.WriteLine("Dijite um deles. e tudo minusculu");
        String opcao = Console.ReadLine();
        Console.WriteLine("agora dijite quantas fatias são de 1 a 5 fatias ou cubos como a lasanha ok");
        int fatias = Convert.ToInt32(Console.ReadLine());
        if (opcao == "pissa" || opcao == "Pissa")
        {
            switch (fatias)
            {
                case 1:
                    comeu_pissa++;
                    Console.WriteLine("Voçe comeu 1 fatia de pissa");
                    break;
                case 2:
                    comeu_pissa += 2;
                    Console.WriteLine("Voçe comeu 2 fatia de pissa");
                    break;
                case 3:
                    comeu_pissa += 3;
                    Console.WriteLine("Voçe comeu 3 fatia de pissa");
                    break;
                case 4:
                    comeu_pissa += 4;
                    Console.WriteLine("Voçe comeu 4 fatia de pissa");
                    break;
                case 5:
                    comeu_pissa += 5;
                    Console.WriteLine("Voçe comeu 5 fatia de pissa");
                    break;
                default:
                    fatias += comeu_bolo;
                    Console.WriteLine("voçe ja comeu toda a pissa caraca!");
                    break;
            }
        }

        if (opcao == "lasanha" || opcao == "Lasanha")
        {
            switch(fatias)
            {
                case 1:
                    comeu_lasanha++;
                    Console.WriteLine("Voçe comeu 1 cubo de lasanha");
                    break;
                case 2:
                    comeu_lasanha += 2;
                    Console.WriteLine("Voçe comeu 2 cubos de lasanha");
                    break;
                case 3:
                    comeu_lasanha += 3;
                    Console.WriteLine("Voçe comeu 3 cubos de lasanha");
                    break;
                case 4:
                    comeu_lasanha += 4;
                    Console.WriteLine("Voçe comeu 4 cubos de lasanha");
                    break;
                case 5:
                    comeu_lasanha += 5;
                    Console.WriteLine("Voçe comeu 5 cubos de lasanha");
                    break;
                default:
                    fatias += comeu_lasanha;
                    Console.WriteLine("caranba voçe comeu toda a lasanha!");
                    break;
            }
        }
        
        if (opcao == "bolo" || opcao == "Bolo")
        {
            switch(fatias)
            {
                case 1:
                    comeu_bolo++;
                    Console.WriteLine("Voçe comeu 1 fatia de bolo");
                    break;
                case 2:
                    comeu_bolo += 2;
                    Console.WriteLine("Voçe comeu 2 fatias de bolo");
                    break;
                case 3:
                    comeu_bolo += 3;
                    Console.WriteLine("Voçe comeu 3 fatias de bolo");
                    break;
                case 4:
                    comeu_bolo += 4;
                    Console.WriteLine("Voçe comeu 4 fatias de bolo");
                    break;
                case 5:
                    comeu_bolo += 5;
                    Console.WriteLine("Voçe comeu 5 fatias de bolo");
                    break;
                default:
                    fatias += comeu_bolo;
                    Console.WriteLine("Como que tu aguetou Comer todo aquele bola caraca meu nobre!");
                    break;
            }
        }

        if (opcao == "queijo" || opcao == "Queijo")
        {
            switch(fatias)
            {
                case 1:
                    comeu_queijo++;
                    Console.WriteLine("Voçe comeu 1 fatia de queijo");
                    break;
                case 2:
                    comeu_queijo += 2;
                    Console.WriteLine("Voçe comeu 2 fatias de queijo");
                    break;
                case 3:
                    comeu_queijo += 3;
                    Console.WriteLine("Voçe comeu 3 fatias de queijo");
                    break;
                case 4:
                    comeu_queijo += 4;
                    Console.WriteLine("Voçe comeu 4 fatias de queijo");
                    break;
                case 5:
                    comeu_queijo += 5;
                    Console.WriteLine("Voçe comeu 5 fatias de queijo");
                    break;
                default:
                    fatias += comeu_queijo;
                    Console.WriteLine("Como que tu aguetou comer todo aquele queijo caraca meu nobre!");
                    break;
            }
        }

        if (fatias == 1 || fatias == 2)
        {
            Console.WriteLine("Ate que voçe pouco");
        }
        else if (fatias == 3 || fatias == 4)
        {
            Console.WriteLine("Comeu bastante klkkkk");
        }
        else if (fatias == 5)
        {
            Console.WriteLine("Como que voçe comeu tudo?!");
        }
        else if (fatias > 5)
        {
            Console.WriteLine("Voçe comeu um monte klkkkk");
        }

        Console.WriteLine("\nDeseja voltar ao menu? (s/n)");
        Console.WriteLine("Basicamente se voçe dijita s vai basicamente faser que o programa execute novamente. e se voçe colocar n vai fechar o programa ok.");
        string resposta = Console.ReadLine();
    if (resposta == "s" || resposta == "sim" || resposta == "Sim" || resposta == "S")
        {
            goto inicio;
        }
        else if (resposta == "n" || resposta == "N" || resposta == "nao" || resposta == "não" || resposta == "Não")
        {
            Console.Clear();
            Console.WriteLine("Obrigado por utilizar o nosso restaurante!");
        }
    }
}
