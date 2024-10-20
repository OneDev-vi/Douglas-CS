using System;

class Principal
{
    static void Main(String[] args)
    {
        int[] ps2 = new int[11];
        int i = 0;
        //ps2[i] = i;
        while (i < 11)
        {
            ps2[i] = i;
            Console.WriteLine(ps2[i]);
            i++;
        }
        Console.WriteLine("Fim do programa!");
        //s
        /*
        if (i < 11)
        {
            for (ps2[i] = 0; ps2[i] < 11; ps2[i]++)
            {
                Console.WriteLine(ps2[i]);
            }
        }
        */
    }
}
