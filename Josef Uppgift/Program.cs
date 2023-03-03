using System;


namespace inlämning
{
    class program
    {
        static void Main(string[] args)
        {
            Addera(9, 13, 50);
            Console.WriteLine(Addera(9,13,50));
        }
        static int Addera(int tal1, int tal2, int tal3)
        {
            return tal1 + tal2 + tal3;
        }
        
        

    }
}