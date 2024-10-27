using System;
class Pricipal
{
    int a = 10;
    static void Main()
    {
        inicio:
        int[] sei = new int[6]{11,12,13,14,15,16};
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine(sei[i]);
        }
        foreach(int n in sei)
        {
            Console.WriteLine(n);
        }
        
        Console.WriteLine("voçe quer calcular novamte?, sim ou não");
        string sn = Console.ReadLine();
        if (sn == "s" || sn == "S" || sn == "sim" || sn == "Sim")
        {
            goto inicio;
            Console.Clear();
        }
        else
        {
            Console.WriteLine("Obrigado por usar o nosso programa!");
        }
    }
}
