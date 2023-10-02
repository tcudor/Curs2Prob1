using System.IO;

namespace Curs2Prob1
{
    internal class Program
    {
        static int Main(string[] args)
        {
            
            Console.Write("Introduceti numele persoanei: ");
            string? nume = Console.ReadLine();

            
            Console.Write("Introduceti varsta persoanei: ");
            bool canConvert = false;
            while (!canConvert)
            {
                canConvert = Int32.TryParse(Console.ReadLine(), out int varsta);
                if (!canConvert)
                {
                    Console.WriteLine("Varsta nu este un numar valid. Incercati din nou");
                }
                else
                {
                    if (varsta >= 18)
                    {
                        Console.WriteLine($"{nume} are drept de vot.");
                    }
                    else
                    {
                        Console.WriteLine($"{nume} nu are drept de vot.");
                    }
                }
            }
            return 0;
        }
    }
}