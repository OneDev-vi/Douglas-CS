using System;

class Principal
{
    //enum caramba {manga, sal, manga2, cachasa_kkkkkk};
    static void Main(string[] args)
    {
        inicio:
        int[] e = new int[50];
        int i = 0;
        int s = 100;
        for (e[i] = 0; e[i] < 50; e[i]++)
        {
            Console.WriteLine("o valor a variavel i ou e vale basicamente! {0}", e[i]);
            Console.WriteLine("a varavel s valia 100 agora vale isso> {0}", s);
            s--;
        }
        int calc = s * 100 + (5 + 6) / 100 - 10;
        Console.WriteLine(s);
        
        if (s == 50)
        {
            Console.WriteLine("Olha so deu 50 aaaaeeeee que legal kkkk {0}", s);
        }
        Console.WriteLine("Voçes querem executar novamente o codigo sim ou não");
        string sim_nao = Console.ReadLine();

        if(sim_nao == "s" || sim_nao == "S" || sim_nao == "Sim" || sim_nao == "sim")
        {
            Console.Clear();
            Console.WriteLine("Executando novamente");
            goto inicio;
        
        }
        else
        {
            Console.WriteLine("dinada kkkkkk");
            Console.Clear();
        }
        
    }
}
