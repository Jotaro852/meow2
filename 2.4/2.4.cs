// Импортируем пространство имён System для работы с консолью и коллекциями
using System;
using System.Collections.Generic;

class Program
{
    // Создаём метод RomanToInt для преобразования римского числа в целое число
    public static int RomanToInt(string s)
    {
        // Создаём словарь, где ключ - это римский символ, а значение - его цифровое значение
        Dictionary<char, int> romanValues = new Dictionary<char, int> {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000}
        };

        // Инициализируем переменную для хранения результата
        int result = 0;
        // Переменная для хранения предыдущего значения (используется для проверки случаев вычитания)
        int prevValue = 0;

        // Проходим по римскому числу в обратном порядке
        for (int i = s.Length - 1; i >= 0; i--)
        {
            int value = romanValues[s[i]]; // Получаем числовое значение символа

            // Проверяем случаи вычитания
            if (value < prevValue) // Если текущее значение меньше предыдущего
            {
                result -= value; // Вычитаем текущее значение
            }
            else
            {
                result += value; // Иначе прибавляем текущее значение
            }
                
            prevValue = value; // Обновляем предыдущее значение
        }

        return result; // Возвращаем итоговый результат
    }

    // Основной метод Main
    static void Main()
    {
        Console.WriteLine("Введите римское число: ");
        string input = Console.ReadLine().ToUpper(); // Читаем ввод и переводим в верхний регистр

        if (string.IsNullOrEmpty(input)) // Проверяем на пустую строку
        {
            Console.WriteLine("Введена пустая строка.");
            return;
        }

        int result = RomanToInt(input); // Вызываем метод для преобразования
        Console.WriteLine($"Результат: {result}"); // Выводим итоговый результат
    }
}