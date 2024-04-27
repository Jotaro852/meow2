using System;

class MyClass
{
    public float Number { get; set; } // число
    public string Text { get; set; } // текст

    // Конструктор с входными параметрами
    public MyClass(float number, string text)
    {
        Number = number; // присвоить Number
        Text = text; // присвоить Text
    }

    // Конструктор свойств по умолчанию
    public MyClass()
    {
        Number = 0; // присвоить Number = 0
        Text = "Null"; // присвоить Text = Null
    }

    // вывод информации
    public void PrintInfo()
    {
        Console.WriteLine($"Число: {Number}, Текст: {Text}"); // вывод
    }  
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите число:"); // вывод
        float num = float.Parse(Console.ReadLine()); // получение данных от пользователя
        Console.WriteLine("Введите текст: "); // вывод
        string tex = Console.ReadLine(); // получение данных от пользователя

        Console.WriteLine("\nСоздание объекта с параметрами:"); // вывод
        MyClass obj1 = new MyClass(num, tex); // создание объекта с параметрами
        obj1.PrintInfo(); // вывод информации о объекте

        Console.WriteLine("\nСоздание объекта с использованием конструктора по умолчанию:"); // вывод
        MyClass obj2 = new MyClass(); // создание объекта с использованием конструктора по умолчанию
        obj2.PrintInfo(); // вывод информации о объекте

        GC.Collect(); // очистка памяти под объект
        Console.Read(); // задержка для просмотра результатов
        Console.WriteLine("Объект удален"); // вывод
    }
}
}