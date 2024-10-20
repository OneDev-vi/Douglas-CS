using System;

class Principal
{
    static void Main(String[] args)
    {
        int[] manga = new int[16];
        int i = 0;
        int o = 0;
        if (i < 16)
        {
            for (manga[i] = 0; manga[i] < 16; manga[i]++)
            {
                
                Console.WriteLine(manga[i]);
            }
        }
        for(i = 0; i < manga.Length; i++)
        {
            manga[i] = i;
        }
        for(i = 0; i < manga.Length; i++)
        {
            Console.WriteLine("valor do seila imãor {0} e {1}", i, manga[i]);
        }
        for (o = 0; o < 11; o++)
        {
            Console.WriteLine("\n" + o);
        }
    }
}
