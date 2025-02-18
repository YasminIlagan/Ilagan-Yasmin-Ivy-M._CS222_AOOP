using System;

class FinalTotal
{
    static void Main()
    {
        int total = 10;
        Console.Write("Enter an integer: ");
        int number = Convert.ToInt32(Console.ReadLine());

        if (number > 0)
        {
            if (number % 2 == 0)
            {
                Console.WriteLine("The number is even.");
                total += number * number;
            }
            else
            {
                Console.WriteLine("The number is odd.");
                total += number * number * number; 
            }
            Console.WriteLine(total);
        }
        else if (number < 0)
        {
            Console.Write("Enter another integer: ");
            int exponent = Convert.ToInt32(Console.ReadLine());
            double result = Math.Pow(number, exponent); 
            Console.WriteLine(result);
        }
        else
        {
            Console.WriteLine("Nothing happened.");
        }
    }
}
