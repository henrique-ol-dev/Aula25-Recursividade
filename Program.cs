using System;

namespace ex24
{
    class Program
    {
        static void Main(string[] args)
        {
            Tribonnaci conta = new Tribonnaci(10);
            Fatorial fat = new Fatorial();
            Console.WriteLine("------------");
            Console.WriteLine(fat.fat(25));
            
        }
    }
}
