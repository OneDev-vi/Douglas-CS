using System;

namespace aula2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 2 ou 3");
            int resposta = Convert.ToInt32(Console.ReadLine());
            switch(resposta)
            {
                case 1:
                    Console.WriteLine("1");
                    break;
                case 2:
                    Console.WriteLine("2");
                    break;
                case 3:
                    Console.WriteLine("3");
                    break;
                case 4:
                    Console.WriteLine("4");
                    break;
                case 5:
                    Console.WriteLine("5");
                    break;
                //case 6:
                case 100:
                    Console.WriteLine("100");
                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }
            Console.ReadLine();
        }
    }
}
