using System;

class Numbers
{
    public int Number1 { get; set; }
    public int Number2 { get; set; }

    public Numbers()
    {
        Number1 = 10; // значение по умолчанию для Number1
        Number2 = 20; // значение по умолчанию для Number2
    }

    public void PrintNumbers()
    {
        Console.WriteLine($"Number 1: {Number1}");
        Console.WriteLine($"Number 2: {Number2}");
    }

    public void ChangeNumbers(int num1, int num2)
    {
        Number1 = num1;
        Number2 = num2;
    }

    public int GetSum()
    {
        return Number1 + Number2;
    }

    public int GetMax()
    {
        return Math.Max(Number1, Number2);
    }
}

class Program
{
    static void Main()
    {
        Numbers numbers = new Numbers();

        while (true)
        {
            Console.WriteLine("\nEnter a command:");
            Console.WriteLine("1 - Change numbers");
            Console.WriteLine("2 - Print numbers");
            Console.WriteLine("3 - Get sum of numbers");
            Console.WriteLine("4 - Get max number");
            Console.WriteLine("5 - Exit");

            Console.WriteLine("Default numbers are: ");
            numbers.PrintNumbers();

            int command = Convert.ToInt32(Console.ReadLine());

            switch (command)
            {
                case 1:
                    Console.Write("Enter number 1: ");
                    int num1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter number 2: ");
                    int num2 = Convert.ToInt32(Console.ReadLine());
                    numbers.ChangeNumbers(num1, num2);
                    break;

                case 2:
                    numbers.PrintNumbers();
                    break;

                case 3:
                    Console.WriteLine($"Sum of numbers: {numbers.GetSum()}");
                    break;

                case 4:
                    Console.WriteLine($"Max number: {numbers.GetMax()}");
                    break;

                case 5:
                    Console.WriteLine("Exiting program...");
                    return;

                default:
                    Console.WriteLine("Invalid command. Please try again.");
                    break;
            }
        }
    }
}