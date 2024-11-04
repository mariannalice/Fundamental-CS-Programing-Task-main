namespace CS_Tests;

class Program
{
    static void Main(string[] args)
    {
        // Create a new instance of the Greeting class
        Greetings greetings = new Greetings();
        // English greeting
        greetings.SayHello();
        // Japanese greeting
        greetings.YoiTsuitachi();

        Fundament fun = new Fundament();
        Console.WriteLine(fun.SumTwoNumbersOfGivenType(3, 5.21));

        fun.SumTwoNumbers();

        fun.CheckOddOrEven(4);

        Console.WriteLine("Write an interesting fact!");
        string? fact = Console.ReadLine();
        fun.GetAInterestingFact(fact);



    }
}
