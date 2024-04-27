using System;

// Создаем класс Train
class Train
{
    // Свойства класса Train: название пункта назначения, номер поезда, время отправления
    public string Destination { get; set; }
    public int TrainNumber { get; set; }
    public DateTime DepartureTime { get; set; }

    // Конструктор класса Train для инициализации свойств поезда
    public Train(string destination, int trainNumber, DateTime departureTime)
    {
        Destination = destination;
        TrainNumber = trainNumber;
        DepartureTime = departureTime;
    }

    // Метод DisplayTrainInfo для вывода информации о поезде
    public void DisplayTrainInfo()
    {
        Console.WriteLine("Train information:");
        Console.WriteLine("Destination: " + Destination);
        Console.WriteLine("Train number: " + TrainNumber);
        Console.WriteLine("Departure time: " + DepartureTime);
    }
}

class Program
{
    static void Main()
    {
        // Создаем объекты поездов с заданными параметрами
        Train train1 = new Train("Moscow", 123, new DateTime(2022, 3, 15, 10, 30, 0));
        Train train2 = new Train("St. Petersburg", 456, new DateTime(2022, 3, 15, 11, 45, 0));

        // Предлагаем пользователю ввести номер поезда для вывода информации
        Console.WriteLine("Enter the train number to display information:");
        int userInput = Convert.ToInt32(Console.ReadLine());

        // Проверяем введенный номер поезда и выводим информацию о нем
        if (userInput == train1.TrainNumber)
        {
            train1.DisplayTrainInfo();
        }
        else if (userInput == train2.TrainNumber)
        {
            train2.DisplayTrainInfo();
        }
        else
        {
            Console.WriteLine("Train not found.");
        }
    }
}