using System;

class InterestCalculator
{
    static void Main ()
    {
        Console.Write ("Enter principal amount: ");
        double principal = double.Parse (Console.ReadLine());
        Console.Write ("Enter rate of interest: ");
        double rate = double.Parse (Console.ReadLine());
        Console.Write ("Enter time in yers: ");
        double time = double.Parse (Console.ReadLine());
        
        double simpleInterest = (principal*rate*time)/100;
         Console.Write ("Simple Interest: {0:F2}" ,simpleInterest);
    }
}
