using System;

class MainClass
{
    public static void Main(string[] args)
    {
        // Ввод строк jewels и stones
        Console.WriteLine("введите значения");
        string jewels = Console.ReadLine();
        string stones = Console.ReadLine();
        int count = 0;
        foreach (char stone in stones) // Перебираем каждый символ из строки stones
        {
            if (jewels.Contains(stone)) // Проверяем, содержится ли символ из stones в строке jewels
            {
                count++; // Увеличиваем счетчик, если символ является "драгоценностью"
            }
        }

        Console.WriteLine(count); // Выводим количество совпадающих символов
    }
}  