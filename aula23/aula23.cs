using System;

class Program
{
    static void Main(string[] args)
    {
        Random java = new Random();
        //int SAL = random.Next(10, 20);
        Console.WriteLine("Random Java: " + java);
        //Console.WriteLine("Random C#: " + SAL);
        Console.WriteLine(java);
        int[] vector0 = new int[11]{0,1,2,3,4,5,6,7,8,9,10};
        int[] vector = new int[5]{1,2,3,4,5};
        int[] vector01 = new int[5]{5,7,9,2,5};
        int[] vector2 = new int[5]{5,10,15,20,25};
        int[] vector3 = new int[10];
        int[] vector4 = new int[5]{1,2,3,4,5,};
        int[,] matriz = new int[2,5]{{10,15,20,25,30},{30,35,40,50,55}};
        //long[] long1 = new long[10]{1,2,3,4,5,6,7,8,9,10};
        //long[,] long2 = new long[2,5]{{1,2,3,4,5} , {10,11,12,13,14,15}};
        Random random = new Random();
        for (int i = 0; i < vector.Length; i++)
        {
            vector[i] = random.Next(0, 100);
            Console.WriteLine(vector[i]);
            Console.WriteLine("------------------------------");
        }
        Console.WriteLine("==============================");
        //elementos do vector1
        Console.WriteLine("Elementos do vetor 1");
        foreach (int n in vector)
        {
            Console.WriteLine(n);
        }
        Console.WriteLine("==============================");
        //public static int BinarySearch(array, valor);
        Console.WriteLine("BinarySearch");
        int precurado = 8;
        int pos = Array.BinarySearch(vector0, precurado);
        Console.WriteLine("O valor {0} esta na posição {1}", precurado, pos);
        Console.WriteLine("==============================");

        //public void Copy(Arry_de_origin, Array_De_destino, Quantidade_de_Elementos)
        Console.WriteLine("==============================");
        Console.WriteLine("Copy");
        Console.WriteLine("Copia dos elementos do vetor 01 para o vetor 2");
        Array.Copy(vector01, vector2, vector01.Length);

        foreach(int n in vector2)
        {
            Console.WriteLine(n);
        }
        Console.WriteLine("==============================");
        //public void CopyTo(Array_de_destino, A_partir_desta_poçisão || A_partir_de_qual_posição)
        Console.WriteLine("==============================");
        Console.WriteLine("CopyTo");
        vector01.CopyTo(vector3, 0);
        foreach(int n in vector2)
        {
            Console.WriteLine(n);
        }
        Console.WriteLine("==============================");
        //public int GetLowerBound(Dimenção);
        Console.WriteLine("GetLowerBound");
        int MenorIndeceDoVetor = vector.GetLowerBound(0); // Arry de uma dimenção
        int MenorIndeceDaMatris_D1 = matriz.GetLowerBound(1); //voçe pode colocar o indice um 0 ou 1, oara voçe pegar do indice que voçe querda matris .Array de duas dimenções
        Console.WriteLine("O Menor indice do vector {0}", MenorIndeceDoVetor);
        Console.WriteLine("A Menor Indice do Matris {0}", MenorIndeceDaMatris_D1);
        Console.WriteLine("==============================");
        //public long GetLongLenght(dimenção);
        Console.WriteLine("GetLongLenght");
        long TamanhoDoVetor = long1.GetLongLenght(0); // Arry de uma dimenção
        long TamanhoDaMatriz = long2.GetLongLenght(1);
        Console.WriteLine("o tamanho do vetor {}", TamanhoDoVetor);
        Console.WriteLine("o tamanho da matriz {}", TamanhoDaMatriz);
        Console.WriteLine("------------------------------");
        /*
        //public int GetUpperBound(dimenção);
        Console.WriteLine("GetUpperBound");
        int MaiorIndeceDoVetor = vector4.GetUpperBound(0);
        int MaiorIndiceDaMatriz = matriz.GetUpperBound(1);
        Console.WriteLine("O maior indice do vetor4 é {}", MaiorIndeceDoVetor);
        Console.WriteLine("O maior indice da matriz é {}", MaiorIndiceDaMatriz);
        */
    }
}
