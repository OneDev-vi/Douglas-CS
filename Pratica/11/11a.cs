using System;

class Principal
{
    static void Main(string[] args)
    {
        int[] Jr = new int[20];
        int[] de = new int[2];
        int[] vetor01 = new int[10];
        int[] copy = new int[5]{5,10,15,20,25};
        int[] vetor0 = new int[10]{1,2,3,4,5,6,7,8,9,10};
        int[] vetor1 = new int[5]{10,20,30,40,50};
        int[] vetor2 = new int[10];/*{1,2,3,4,5,6,7,8,9,10}*/
        int[] vetor002 = new int[5]{2,4,6,8,10};
        int[] vetor02 = new int[5];
        int[] vetor3 = new int[10];
        int[,] matiz00 = new int[2,5]{{2,4,6,8,10},{12,14,16,18,20}};
        int[,] matriz = new int[2,5]{{10,20,30,40,50},{60,70,80,90,100}};
        //aqui estão os vetores e matrizis
        Random java = new Random();
        Console.WriteLine("------------------------------------");
        Console.WriteLine("Aqui esta sendo randonizado");
        Console.WriteLine("------------------------------------");
        for (int i = 0; i < Jr.Length; i++)
        {
            Jr[i] = java.Next(0, 100);
            Console.WriteLine("O numero que foi randonizado foi {0}", Jr[i]);
        }
        Console.WriteLine("------------------------------------");
        Console.WriteLine("Aqui estão os valores do vetor0");
        Console.WriteLine("------------------------------------");
        foreach (int n in vetor0)
        {
            Console.WriteLine("Aqui estão os valores o vetor0 {0}", n);
        }
        //public static int BinarySearch(array, valor);
        Console.WriteLine("------------------------------------");
        Console.WriteLine("BinarySearch");
        Console.WriteLine("------------------------------------");
        int valr = 5;
        int poo = Array.BinarySearch(vetor1, valr);
        Console.WriteLine("o valor do valor é {0} e a poçisão achada do vetor foi {1} e se ele não achou ele void retornar um valor negativo ok", valr, poo);

        //public static void Copy(Array_de_origem, Array_de_Destino, Quantidade_de_elementos);
        Console.WriteLine("------------------------------------");
        Console.WriteLine("Copy");
        Console.WriteLine("------------------------------------");
        Array.Copy(copy, vetor2, copy.Length);
        foreach (int n in vetor2)
        {
            Console.WriteLine(n);
        }
        //public static void CopyTo(Array_de_destino, Apatir_desta_poçisão);
        Console.WriteLine("------------------------------------");
        Console.WriteLine("CopyTo");
        Console.WriteLine("------------------------------------");
        vetor002.CopyTo(vetor01, 1);
        foreach (int n in vetor01)
        {
            Console.WriteLine(n);
        }
        Console.WriteLine("------------------------------------");
        //public long GetLongLenght(Dimenção);
        Console.WriteLine("GetLongLength");
        Console.WriteLine("------------------------------------");
        /*
        long qtdv = de.GetLongLenght(0);
        //long qtdm = matiz00.GetLongLenght(1);
        Console.WriteLine("sei lá o que {0} e sei la oque {1}", qtdv qtdm);
        */
        //public int GetLowerBound(dimenção);
        Console.WriteLine("------==---0-0----------------------");
        Console.WriteLine("GetLowerBound");
        Console.WriteLine("------==---0-0----------------------");
        int menor = vetor1.GetLowerBound(0);
        int meno2 = matriz.GetLowerBound(1);
        Console.WriteLine("O menor indice do vetor1 é {0} e o menor indice da matriz é {1}", menor, meno2);
        Console.WriteLine("------==---0-0----------------------");
        //public int GetUpperBound(dimenção);
        Console.WriteLine("------------------------------------");
        Console.WriteLine("GetUpperBound");
        Console.WriteLine("------------------------------------");
        int mair = vetor1.GetUpperBound(0);
        int mair2 = matriz.GetUpperBound(1);
        Console.WriteLine("o maior indice do vetor1 é {0} e da matriz é {1}", mair, mair2);
        Console.WriteLine("------------------------------------");
        //public object GetValue(long indice);
        Console.WriteLine("------------------------------------");
        Console.WriteLine("GetValue");
        Console.WriteLine("------------------------------------");
        int aaa = Convert.ToInt32(vetor1.GetValue(2));
        int mmm = Convert.ToInt32(matriz.GetValue(1,4));
        Console.WriteLine("vlor do indice pego do vetor1 foi {0} e da matroz foi {1}", aaa, mmm);
        Console.WriteLine("------------------------------------");
        Console.WriteLine("IndexOf");
        public static int IndexOf(array, valor);
        Console.WriteLine("------------------------------------");
    }
}
