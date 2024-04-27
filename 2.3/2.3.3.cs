using System;

class Calculation
{
    // Свойство для хранения строки вычисления
    public string CalculationLine { get; private set; }

    // Метод для установки строки вычисления
    public void SetCalculationLine(string line)
    {
        CalculationLine = line;
    }

    // Метод для добавления символа в конец строки вычисления
    public void SetLastSymbolCalculationLine(char symbol)
    {
        CalculationLine += symbol;
    }

    // Метод для получения значения строки вычисления
    public string GetCalculationLine()
    {
        return CalculationLine;
    }

    // Метод для получения последнего символа строки вычисления
    public char GetLastSymbol()
    {
        if (string.IsNullOrEmpty(CalculationLine))
        {
            return '\0'; // вернуть нулевой символ, если строка пуста
        }
        return CalculationLine[CalculationLine.Length - 1];
    }

    // Метод для удаления последнего символа из строки вычисления
    public void DeleteLastSymbol()
    {
        if (!string.IsNullOrEmpty(CalculationLine))
        {
            CalculationLine = CalculationLine.Substring(0, CalculationLine.Length - 1);
        }
    }
}

class Program
{
    static void Main()
    {
        Calculation calc = new Calculation();

        // Установка строки вычисления
        calc.SetCalculationLine("яненавижуни");

        // Добавление символа в конец строки вычисления
        calc.SetLastSymbolCalculationLine('+');

        // Вывод строки вычисления
        Console.WriteLine("Строка вычисления: " + calc.GetCalculationLine());

        // Вывод последнего символа
        Console.WriteLine("Последний символ: " + calc.GetLastSymbol());

        // Удаление последнего символа из строки вычисления
        calc.DeleteLastSymbol();

        // Вывод измененной строки вычисления
        Console.WriteLine("Строка вычисления после удаления последнего символа: " + calc.GetCalculationLine());
    }
}