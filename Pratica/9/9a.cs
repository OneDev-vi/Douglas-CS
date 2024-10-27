using System;

class Program
{
    static void Main(string[] args)
    {
        int[] num = new int[21];
        int i = 0;
        while (i < 21)
        {
            Console.WriteLine(i);
            num[i] = i;
            i++;
        }

        do
        {
            Console.WriteLine(i);
            i++;
        }while(i < 0);
    }
}
