//1
class Binary
{
    static int BinarySearch(int[] array, int target)
    {
        int left = 0, right = array.Length - 1;
        while (left <= right)
        {
            int mid = (left + right) / 2;
            if (array[mid] == target)
            {
                return mid;
            }
            if (array[mid] > target)
            {
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }
        return -1;
    }

    static void Main()
    {
        int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8 };
        int target = 4;
        int result = BinarySearch(arr, target);
        if (result != -1)
        {
            System.Console.WriteLine($"Result found at index: {result}");
        }
        else
        {
            System.Console.WriteLine("Result not found.");
        }
    }
}








//2

class Selection
{
    static void selection(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
        {
            int min = i;
            for (int j = i + 1; j < n; j++)
            {
                if (arr[j] < arr[min])
                {
                    min = j;
                }
            }
            (arr[i], arr[min]) = (arr[min], arr[i]);
        }
    }
    static void print(int[]arr)
    {
        foreach (int item in arr)
        {
            System.Console.Write(item+" ");
        }
        System.Console.WriteLine();
    }
    static void Main()
    {
        int[]arr={4,3,5,7,8,1};
        System.Console.WriteLine("Original array: ");
        print(arr);
        selection(arr);
        System.Console.WriteLine("After array: ");
        print(arr);
    } 
}







//3
class StudentGradeCalculator
{
    static void Main()
    {
        Console.WriteLine("Enter marks for the following subjects (out of 100):");
        Console.Write("Physics: ");
        int physics = int.Parse(Console.ReadLine());
        
        Console.Write("Chemistry: ");
        int chemistry = int.Parse(Console.ReadLine());
        
        Console.Write("Biology: ");
        int biology = int.Parse(Console.ReadLine());
        
        Console.Write("Mathematics: ");
        int mathematics = int.Parse(Console.ReadLine());
        
        Console.Write("Computer: ");
        int computer = int.Parse(Console.ReadLine());

        
        int totalMarks = physics + chemistry + biology + mathematics + computer;
        double percentage = (totalMarks / 500.0) * 100;

        // Determine grade
        string grade;
        if (percentage >= 90)
            grade = "A";
        else if (percentage >= 80)
            grade = "B";
        else if (percentage >= 70)
            grade = "C";
        else if (percentage >= 60)
            grade = "D";
        else if (percentage >= 40)
            grade = "E";
        else
            grade = "F";

        
        Console.WriteLine("\nTotal Marks: " + totalMarks + "/500");
        Console.WriteLine("Percentage: " + percentage.ToString("0.00") + "%");
        Console.WriteLine("Grade: " + grade);
    }
}














