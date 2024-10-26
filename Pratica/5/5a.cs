using System;

class Principal
{
    enum dias {segunda, terça, quarta, quinta, sexta, sabado, domingo};
    static void Main()
    {
        dias ds = dias.segunda;
        Console.WriteLine(ds);
    }
}
