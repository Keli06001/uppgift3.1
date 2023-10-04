using System;

namespace Uppgift3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur gammal är du?");
            int gammal=int.Parse(Console.ReadLine());

            if (gammal<16)
            {
                Console.WriteLine("Du får inte vara med eftersom du är för ung");
            }
            else if (gammal > 19)
            {
                Console.WriteLine("Du får inte vara med eftersom du är för gammal");
            }
            else if (gammal>=16 &&  gammal <= 19)
            {
                Console.WriteLine("Du får vara med på tävlingen");
            }
            Console.ReadKey();
        }
    }
}