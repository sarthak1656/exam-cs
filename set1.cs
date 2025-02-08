//1
using System;

class LinearSearch
{
    static int Search(int[] arr, int target)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == target)
            {
                return i; // Return index if found
            }
        }
        return -1; // Return -1 if not found
    }

    static void Main()
    {
        int[] numbers = { 10, 20, 30, 40, 50 };
        Console.Write("Enter the number to search: ");
        int target = Convert.ToInt32(Console.ReadLine());

        int result = Search(numbers, target);
        
        if (result != -1)
        {
            Console.WriteLine($"Element found at index {result}");
        }
        else
        {
            Console.WriteLine("Element not found");
        }
    }
}









//2

class BB
{
    static void Main()
    {
        System.Console.WriteLine("Enter the number of elements: ");
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];

        System.Console.WriteLine("Enter the elements: ");
        for (int i = 0; i < n; i++)
        {
            System.Console.Write($"Enter element{i + 1}: ");
            arr[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < n - 1; i++)
        {
            Console.WriteLine("The temperature is classified as: Hot");
        }
        else
        {
            Console.WriteLine("The temperature is classified as: Scorching");
        }
    }
}


class P
{
    static void Main()
    {
        System.Console.WriteLine("Enter the number of rows: ");
        int n = int.Parse(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            for (int j = i; j <=n; j++)
            {
                System.Console.Write(" ");
            }
            for (int k = 1; k <= (2*i-1); k++)
            {
                System.Console.Write(k);
            }
            System.Console.WriteLine();
        }
    }

}





//3
class GasCylinder
{
    static void Main()
    {
        Console.Write("Enter the first letter of the cylinder's color: ");
        string userinput = Console.ReadLine();
        char input = Convert.ToChar(userinput);


        string gasContent;

        switch (input)
        {
            case 'o':
                gasContent = "Ammonia";
                break;
            case 'b':
                gasContent = "Carbon Monoxide";
                break;
            case 'y':
                gasContent = "Hydrogen";
                break;
            case 'g':
                gasContent = "Oxygen";
                break;
            default:
                gasContent = "Contents Unknown";
                break;
        }

        Console.WriteLine($"Gas Content: {gasContent}");
    }
}