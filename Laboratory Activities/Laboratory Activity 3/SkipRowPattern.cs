using System;

class SkipRowPattern
{
    static void Main()
    {
        Console.Write("Enter n: ");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter y: ");
        int y = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            if (i == y)
            {
                continue; 
            }
            for (int j = 1; j <= n; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();

            if (i == y - 1 || (i == n && y != n)) 
            {
                Console.WriteLine();
            }
        }
    }
}
