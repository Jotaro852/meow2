using System; 
using System.Collections.Generic; 
using System.Linq; 
 
class MainClass 
{ 
    public static void Main (string[] args) 
    { 
        int[] candidates = {2, 5, 2, 1, 2}; 
        int target = 5; 
         
        List<List<int>> result = new List<List<int>>(); 
         
        Array.Sort(candidates); // Сортируем исходный массив 
         
        FindCombination(candidates, target, 0, new List<int>(), result); 
         
        // Выводим полученные комбинации на экран с помощью LINQ 
        result.ForEach(combination => Console.WriteLine("[" + string.Join(",", combination) + "]")); 
    } 
     
    // Рекурсивная функция для поиска комбинаций 
    private static void FindCombination(int[] candidates, int target, int start, List<int> current, List<List<int>> result) 
    { 
        if (target == 0) 
        { 
            result.Add(new List<int>(current)); // Добавляем комбинацию в результат 
            return; 
        } 
         
        // Проходимся по массиву candidates и ищем комбинации 
        for (int i = start; i < candidates.Length && target - candidates[i] >= 0; i++) 
        { 
            if (i > start && candidates[i] == candidates[i-1]) 
            { 
                continue; // Пропускаем повторяющиеся числа 
            } 
             
            current.Add(candidates[i]); // Добавляем число в текущую комбинацию 
            FindCombination(candidates, target - candidates[i], i + 1, current, result); // Рекурсивный вызов для поиска комбинаций 
            current.RemoveAt(current.Count - 1); // Удаляем число из текущей комбинации 
        } 
    } 
}