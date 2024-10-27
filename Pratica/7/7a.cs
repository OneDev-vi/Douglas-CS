using System;

class Principal
{
    //enum caramba {manga, sal, manga2, cachasa_kkkkkk};
    static void Main(string[] args)
    {
        inicio:
        Console.WriteLine("===================================");
        Console.WriteLine("-----------------------------------");
        Console.WriteLine("==========LolJas do core===========");
        Console.WriteLine("-----------------------------------");
        Console.WriteLine("===================================");
        Console.WriteLine("====Moletõu do fnaf Preço: 100R$===");
        Console.WriteLine("-----------------------------------");
        Console.WriteLine("===Camiseta do fnafão Preço: 50R$==");
        Console.WriteLine("-----------------------------------");
        Console.WriteLine("====Xicara do coresão Preço: 35====");
        Console.WriteLine("-----------------------------------");
        Console.WriteLine("===================================");
        Console.WriteLine("===-Escolha uma das opçoes acima===");
        string opcao = Console.ReadLine();
        Console.WriteLine("-----------------------------------");
        Console.WriteLine("===================================");
        Console.WriteLine("agora escolha o valor a pagar");
        double a_pagar = double.Parse(Console.ReadLine());
        Console.WriteLine("-----------------------------------");
        Console.WriteLine("===================================");
        int valor = 0;
        switch (opcao)
        {
            case "moletõu do fnaf":
                Console.WriteLine("obrigado por escolher o moletõn do fnaf");
                valor++;
                break;
            case "camiseta do fnafão":
                Console.WriteLine("obrigado por escolher a camiseta do fnafão");
                valor += 2;
                break;
            case "xicara do coresão":
                Console.WriteLine("obrigado por escolher a xicara do coresão");
                valor += 3;
                break;
            default:
                Console.WriteLine("Não temos essa opção aqui porfavor escolha outra ok");
                valor += 4;
                break;
        }
        Console.WriteLine("-----------------------------------");
        Console.WriteLine("===================================");
        Console.WriteLine("qual o valor que voçe deseja pagar ");
        if (opcao == "moletõu do fnaf" || opcao == "Moletõu do fnaf"){
            Console.WriteLine("qual o valor que voçe deseja pagar ");
            if (a_pagar >= 100){
                Console.WriteLine("Obrigado por pagar o valor que voçe deseja com a moletõn do fnafão");
                Console.WriteLine("sua compra foi bem sucedida");
            }
            else if (a_pagar <= 99)
            {
                Console.WriteLine("Voçe não tem dinheiro para pagar isso");
            }
        }
        else if (opcao == "camiseta do fnafão" || opcao == "Camiseta do fnafão")
        {
            Console.WriteLine("qual o valor que voçe deseja pagar ");
            if (a_pagar >= 50)
            {
                Console.WriteLine("Obrigado por pagar o valor que voçe deseja com a camiseta do fnafão");
                Console.WriteLine("sua compra foi bem sucedida");
            }
            else if (a_pagar <= 49)
            {
                Console.WriteLine("Voçe não tem dinheiro para pagar isso");
            }
        }
        if (opcao == "xicara do coresão" || opcao == "Xicara do coresão")
        {
            Console.WriteLine("obrigado por compra a xicara do fnaf");
            Console.WriteLine("sua compra foi bem sucedida");
            if (a_pagar >= 35){
                Console.WriteLine("Obrigado por pagar o valor que voçe deseja com a xicara do coresão");
                Console.WriteLine("sua compra foi bem sucedida");
            }
            else if (a_pagar <= 34)
            {
                Console.WriteLine("Voçe não tem dinheiro para pagar isso");
            }
        }
        if (valor == 1){
            Console.WriteLine("voçe comprou moleton te fnaf agora voçe ganhou uma camiseta aaaeee!!!");
        }
        if (valor == 2){
            Console.WriteLine("voçe comprou camiseta te fnaf agora voçe ganhou uma xicara de fnaf aaaeee!!!");
        }
        Console.WriteLine("Voçe quer comprar mais uma coisa?, sim ou não");
        string sim_nao = Console.ReadLine();
        if (sim_nao == "s" || sim_nao == "sim" || sim_nao == "Sim" || sim_nao == "S")
        {
            goto inicio;
        }
        else
        {
            Console.WriteLine("Obrigado por usar o nosso loja de jogos!");
        }
    }
}
