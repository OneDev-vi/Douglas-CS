using System;

class Principal
{
    static void Main()
    {
        int num = 12;
        int num2 = 12;
        num = num << 1; // << ele vai dobrar
        num2 = num2 >> 1; // >> ele vai dividir pela metade
        Console.WriteLine(num); // Outputs: 24
        Console.WriteLine(num2); // Outputs: 6
    }
}
