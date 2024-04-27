using System;

class Worker
{
    public string Name { get; set; } // свойство для имени работника
    public string Surname { get; set; } // свойство для фамилии работника
    public double Rate { get; set; } // свойство для ставки работника
    public int Days { get; set; } // свойство для количества отработанных дней

    // метод для расчета зарплаты работника
    public double GetSalary()
    {
        return Rate * Days;
    }
}

class Program
{
    static void Main()
    {
        // создание списка работников
        var workers = new Worker[]
        {
            new Worker { Name = "Семён", Surname = "Александорович", Rate = 100, Days = 20 },
            new Worker { Name = "Сларк", Surname = "Петров", Rate = 12.0, Days = 18 },
            new Worker { Name = "Мария", Surname = "Нтшка", Rate = 11.8, Days = 22 }
        };

        // вывод списка работников
        Console.WriteLine("Список работников:");
        for (int i = 0; i < workers.Length; i++)
        {
            Console.WriteLine($"{i + 1}. {workers[i].Name} {workers[i].Surname}");
        }

        // запрос пользователя на выбор работника
        Console.Write("Выберите номер работника для просмотра зарплаты: ");
        int selectedWorkerIndex = int.Parse(Console.ReadLine()) - 1;

        if (selectedWorkerIndex >= 0 && selectedWorkerIndex < workers.Length)
        {
            Worker selectedWorker = workers[selectedWorkerIndex]; // выбор работника из списка по индексу

            // вывод информации о зарплате выбранного работника
            Console.WriteLine($"Зарплата работника {selectedWorker.Name} {selectedWorker.Surname}: {selectedWorker.GetSalary()}");
        }
        else
        {
            Console.WriteLine("Некорректный номер работника");
        }
    }
}
}