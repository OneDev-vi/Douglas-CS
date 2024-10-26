using System;

class Principal
{
    enum dias {segunda, terça, quarta, quinta, sexta, sabado, domingo};
    static void Main()
    {
        dias ds = dias.segunda; // 1
        dias ds2 = (dias)2; // 2
        dias sa = (dias)5;
        int se = (int)dias.quinta;
        Console.WriteLine(ds);
        Console.WriteLine(ds2);
        Console.WriteLine(sa);
        Console.WriteLine(se);
        
        //Console.Clear();
    }
}
