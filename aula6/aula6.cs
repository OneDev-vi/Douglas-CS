using System;

class Principal
{
    static void Main()
    {
        
        int a , b , c;
        a = 10;
        b = 20;
        c = 30;
        Console.WriteLine("\na\t = {0}\n \nb\t = {1}\n \nc\t = {2}\n",a,b,c);
        int dc = 1;
        double valorcompra = 5;
        double valorvenda;
        double lucro = 0.90;
        string produto = "Manga";
        valorvenda = valorcompra + (valorcompra * lucro);
        int egshg = 6576; //inutio
        Console.WriteLine("Produto.............{0, 15}", produto);
        Console.WriteLine("val.compra..........{0, 15 : c}", valorcompra);
        Console.WriteLine("lucro...............{0, 15:p}", lucro);
        Console.WriteLine("val.venda...........{0, 15:c}", valorvenda);
    }
}