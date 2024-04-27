using System;

public class Worker
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public double Rate { get; set; }
    public int Days { get; set; }

    public Worker(string name, string surname, double rate, int days)
    {
        Name = name;
        Surname = surname;
        Rate = rate;
        Days = days;
    }

    public double GetSalary()
    {
        return Rate * Days;
    }
}

class Program
{
    static void Main()
    {
        // Создаем объект Worker
        Worker worker1 = new Worker("Иван", "Иванов", 100, 20);

        // Выводим информацию о работнике и его зарплате
        Console.WriteLine($"Работник: {worker1.Name} {worker1.Surname}");
        Console.WriteLine($"Зарплата: {worker1.GetSalary()}");

        // Продолжаем выполнение программы или добавляем другие работников
    }
}