using System;

class Principal
{
    static void Main(String[] args)
    {
        //int[] num2 = new int[5]{12, 14, 16, 18, 20, 22};
        int[,] num = new int[2, 2];
        int [,] num2 = new int [2 ,2]{{10, 20}, {30, 40}};
        Console.WriteLine(num2[2, 2]);
        /*
        num2[0,0] = 100;
        num2[0,1] = 200;
        num2[1,0] = 300;
        num2[1,1] = 400;
        Console.WriteLine(num2[0,0]); // Outputs: 100
        */
        /*
        2, 5 : 3 || 5
        
        */
        
        num[0,0] = 12; //0
        num[0,1] = 14; //1
        num[0,2] = 16; //2

        num[1,0] = 235; //0
        num[1,1] = 234; //1
        num[1,2] = 122; //2

        num[2,0] = 346; //0
        num[2,1] = 123; //1
        num[2,2] = 542; //2
        Console.WriteLine(num[2, 2]); // Outputs: 16
    }
}
