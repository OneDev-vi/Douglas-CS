using System;

class Program
{
    static void Main()
    {
        int[] arry = new int[11];
        int i = 0;
        /*
        while(i < 11){
            arry[i] = i;
            Console.WriteLine(i);
            i++;
        }
        */
        do
        {
            arry[i] = i;
            Console.WriteLine(arry[i]);
            i++;
        }while(i < -1);
    }
}
