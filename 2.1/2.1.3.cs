using System; 
using System.Collections.Generic; 
 
class Program 
{ 
    static bool ContainsDuplicate(int[] nums) 
    { 
        HashSet<int> seen = new HashSet<int>(); 
        foreach (int num in nums) 
        { 
            if (seen.Contains(num)) 
            { 
                return true; 
            } 
            seen.Add(num); 
        } 
        return false; 
    } 
 
    static void Main() 
    { 
        int[] nums1 = {1, 1, 3, 4}; 
        Console.WriteLine(ContainsDuplicate(nums1));  
    } 
}