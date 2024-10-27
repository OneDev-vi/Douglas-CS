using System;

class Pricipal
{
    static void Main()
    {
        int[] sei = new int[6]{11,12,13,14,15,16};
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine(sei[i]);
        }
        foreach(int n in sei)
        {
            Console.WriteLine(n);
        }
    }
}
