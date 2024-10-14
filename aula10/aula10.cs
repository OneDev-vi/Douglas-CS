using System;

class Principal
{
    enum manga {mmm, pão, sal, açucar};
    static void Main()
    {
        manga m = manga.mmm;
        manga ds = (manga)3;
        int ls = (int)manga.pão;
        Console.WriteLine(ds);
        Console.WriteLine(ls);
        Console.WriteLine((manga)ls);
        Console.WriteLine(m);
    }
}   
