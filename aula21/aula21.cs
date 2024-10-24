using System;

class Pricipal
{
    static void Main(String[] args)
    {
        int se = 20;
        int senha = 5432;
        Console.WriteLine("Digite a senha:");
        int entrada = Convert.ToInt32(Console.ReadLine());
        if (entrada == senha)
        {
            Console.WriteLine("Acesso permitido!");
            do{
                Console.Clear();
                Console.WriteLine("parabens voçe descubrio a senha aeeee!!");
                entrada++;
            }while(entrada != senha);
        }
        else
        {
            Console.WriteLine("não foi dessa vez otario kkkk");
        }
    }
}
