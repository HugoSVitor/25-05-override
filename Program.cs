using System;
using POOAula2505.Classes;

namespace POOAula2505
{
    class Program
    {
        static void Main(string[] args)
        {
            bool sairWhile = false;
            MegaMan m = new MegaMan();
            Zero z = new Zero();
            do
            {
                Console.WriteLine(@"
                |-------------------------------|
                |     O que você deseja que o   |
                |        Mega-Man execute:     |
                |-------------------------------|
                |                               |
                |                               |
                |                               |
                |-------------------------------|
                ");
                Console.WriteLine("Mega-Man:");
                Console.WriteLine(m.Pular());
                Console.WriteLine(m.Correr());


                Console.WriteLine("Zero:");
                Console.WriteLine(z.Pular());
                Console.WriteLine(z.Correr());
            } while (!sairWhile);


        }
    }
}
