public class Fundament : IFundament
{
    public void CheckOddOrEven(int a)
    {
        if (a % 2 == 0)
        {
            Console.WriteLine("This number is even");
        } 
        else
        {
            Console.WriteLine("This number is odd");
        }

        
    }

    public string GetAInterestingFact(string fact)
    {
        Console.WriteLine("Here is your fact: " + fact);
        return fact;
    }

    public void SumTwoNumbers()
    {
        int x = 5;
        int y = 3;
        int sum = x + y;
        Console.WriteLine(sum);
    }

    public double SumTwoNumbersOfGivenType(double a, double b)
    {
        return a + b;
    }


    // Extra challenges

    public void PrintFibonnaciSeries()
    {
        // TODO: Implement the Fibonacci sequence
        int a = 0;
        int b = 1;
        int c;

        /* 
        c = a + b
        a = b
        b = c
        */
    }

    public string ReverseString(string str)
    {
        // TODO: reverse the given string
        return "";
    }

    public int RecursiveFactorial(int n)
    {
        // Todo: Implement a recursive method(a method that calls itself within its own function scope)
        // To Check the factorial of a number(norsk: Fakultet) we look at n!, where n = n * 1 * 2 * 3...
        if (n == 0)
        {
            return 1;
        }
        return n;
    }


}
