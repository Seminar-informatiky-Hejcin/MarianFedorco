using System.Diagnostics;

namespace Factorial;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            int num;
            Console.Write("Enter the number to compute a factorial from: ");
            try
            {
                String numStr = Console.ReadLine();
                num = int.Parse(numStr);
                if (num < 0)
                {
                    Console.WriteLine("Cannot compute a factorial out of a negative number!!!");
                    continue;
                }
            }
            catch
            {
                Console.WriteLine("Invalid input!!!");
                continue;
            }
            Console.Write("Computed value: ");
            Console.WriteLine(factorial(num));
        }
    }

    static int factorial(int n)
    {
        if (n > 0)
        {
            return n * factorial(n-1);
        }
        else
        {
            return 1;
        }
    }
}
