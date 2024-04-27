using System;

class Student
{
    public string LastName { get; set; }
    public DateTime DateOfBirth { get; set; }
    public int GroupNumber { get; set; }
    public int[] Grades { get; set; } = new int[4];

    public void PrintInfo()
    {
        Console.WriteLine($"Фамилия: {LastName}");
        Console.WriteLine($"Дата рождения: {DateOfBirth}");
        Console.WriteLine($"Номер группы: {GroupNumber}");
        Console.Write("Оценки: ");
        foreach (int grade in Grades)
        {
            Console.Write(grade + " ");
        }
        Console.WriteLine();
    }
}

class Program
{
    static void Main()
    {
        Student student = new Student();

        Console.Write("Введите фамилию студента: ");
        student.LastName = Console.ReadLine();
        
        Console.Write("Введите дату рождения учащегося (гггг-мм-дд): ");
        student.DateOfBirth = DateTime.Parse(Console.ReadLine());
        
        Console.Write("Введите номер группы студента: ");
        student.GroupNumber = int.Parse(Console.ReadLine());

        Console.WriteLine("Введите оценки учащегося (4 цифры, разделенные пробелом): ");
        string[] gradeInputs = Console.ReadLine().Split(' ');
        for (int i = 0; i < 4; i++)
        {
            student.Grades[i] = int.Parse(gradeInputs[i]);
        }

        student.PrintInfo();
        
        while (true)
        {
            Console.WriteLine("Хотите изменить данные? (yes, no)");
            string answer = Console.ReadLine();

            if (answer == "yes")
            {
                Console.Write("Введите новую фамилию для студента: ");
                student.LastName = Console.ReadLine();
                
                Console.Write("Введите новую дату рождения учащегося (гггг-мм-дд): ");
                student.DateOfBirth = DateTime.Parse(Console.ReadLine());
                
                Console.Write("Введите новый номер группы для учащегося: ");
                student.GroupNumber = int.Parse(Console.ReadLine());

                student.PrintInfo();
            }
            else
            {
                return;
            }
        }
    }
}
