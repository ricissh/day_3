using System;

using System;

namespace day_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int mainigais = Funkcija2();
            Console.WriteLine(mainigais);
            Funkcija();
            Funkcija3(5, 6);
            int mainigais2 = Funkcija4(12, 14);
            Console.WriteLine(mainigais2);
            Console.ReadLine();

        }

        static void Funkcija()
        {
            int a, b, c;

            a = 7;
            b = 9;

            c = a + b;
            Console.WriteLine(c);
        }

        static int Funkcija2()
        {
            int a, b, c;
            a = 7;
            b = 9;

            c = a + b;

            return c;
        }
        static void Funkcija3(int skaitlis1, int skaitlis2)
        {
            int c = skaitlis1 + skaitlis2;

            Console.WriteLine(c);
        }
        static int Funkcija4(int skaitlis2, int skaitlis1)
        {
            int result;
            result = skaitlis2 + skaitlis1;
            return result;
            }
       }        
        
}