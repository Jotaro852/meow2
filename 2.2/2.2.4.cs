using System;

class Counter
{
    private int value;

    // Конструктор счетчика со значением по умолчанию = 0
    public Counter() : this(0)
    {
    }

    // Конструктор счетчика с заданным начальным значением
    public Counter(int startValue)
    {
        value = startValue;
    }

    // Метод увеличения значения счетчика на 1
    public void Increase()
    {
        value++;
    }

    // Метод уменьшения значения счетчика на 1
    public void Decrease()
    {
        value--;
    }

    // Свойство для получения текущего значения счетчика
    public int Value
    {
        get { return value; }
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Выберите тип инициализации счетчика: \n1. Значение по умолчанию \n2. Произвольное значение \nВведите число (1 или 2):");
        int initChoice = int.Parse(Console.ReadLine());

        Counter myCounter;

        if (initChoice == 2)
        {
            Console.WriteLine("Введите начальное значение счетчика: ");
            int startValue = int.Parse(Console.ReadLine());
            myCounter = new Counter(startValue);
        }
        else
        {
            myCounter = new Counter();
        }

        Console.WriteLine("Выберите действие: \nУвеличить счетчик: + \nУменьшить счетчик: - \nЗавершить программу: 0");

        bool isRunning = true;
        while (isRunning)
        {
            Console.WriteLine($"Текущее значение счетчика: {myCounter.Value}");
            string action = Console.ReadLine();

            switch (action)
            {
                case "+":
                    myCounter.Increase();
                    break;
                case "-":
                    myCounter.Decrease();
                    break;
                case "0":
                    isRunning = false;
                    break;
                default:
                    Console.WriteLine("Неверный выбор. Попробуйте еще раз.");
                    break;
            }
        }

        Console.WriteLine($"Конечное значение счетчика: {myCounter.Value}");
    }
}
