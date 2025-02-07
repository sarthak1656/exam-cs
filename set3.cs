// class Binary
// {
//     static int BinarySearch(int[] array, int target)
//     {
//         int left = 0, right = array.Length - 1;
//         while (left <= right)
//         {
//             int mid = (left + right) / 2;
//             if (array[mid] == target)
//             {
//                 return mid;
//             }
//             if (array[mid] > target)
//             {
//                 left = mid + 1;
//             }
//             else
//             {
//                 right = mid - 1;
//             }
//         }
//         return -1;
//     }

//     static void Main()
//     {
//         int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8 };
//         int target = 4;
//         int result = BinarySearch(arr, target);
//         if (result != -1)
//         {
//             System.Console.WriteLine($"Result found at index: {result}");
//         }
//         else
//         {
//             System.Console.WriteLine("Result not found.");
//         }
//     }
// }






// class Selection
// {
//     static void selection(int[] arr)
//     {
//         int n = arr.Length;
//         for (int i = 0; i < n - 1; i++)
//         {
//             int min = i;
//             for (int j = i + 1; j < n; j++)
//             {
//                 if (arr[j] < arr[min])
//                 {
//                     min = j;
//                 }
//             }
//             (arr[i], arr[min]) = (arr[min], arr[i]);
//         }
//     }
//     static void print(int[]arr)
//     {
//         foreach (int item in arr)
//         {
//             System.Console.Write(item+" ");
//         }
//         System.Console.WriteLine();
//     }
//     static void Main()
//     {
//         int[]arr={4,3,5,7,8,1};
//         System.Console.WriteLine("Original array: ");
//         print(arr);
//         selection(arr);
//         System.Console.WriteLine("After array: ");
//         print(arr);
//     } 
// }



// using System;

// class GasCylinder
// {
//     static void Main()
//     {
//         Console.Write("Enter the first letter of the cylinder's color: ");
//         string userinput = Console.ReadLine();
//         char input = Convert.ToChar(userinput);


//         string gasContent;

//         switch (input)
//         {
//             case 'o':
//                 gasContent = "Ammonia";
//                 break;
//             case 'b':
//                 gasContent = "Carbon Monoxide";
//                 break;
//             case 'y':
//                 gasContent = "Hydrogen";
//                 break;
//             case 'g':
//                 gasContent = "Oxygen";
//                 break;
//             default:
//                 gasContent = "Contents Unknown";
//                 break;
//         }

//         Console.WriteLine($"Gas Content: {gasContent}");
//     }
// }


int n=5;
for (int i = 1; i <= n; i++)
{
    for (int j = 0; j < i; j++)
    {
        System.Console.Write(j);
    }
    System.Console.WriteLine();
}
for (int i = n; i >= 0; i--)
{
    for (int k = 0; k <= i; k++)
    {
        System.Console.Write(k);
    }
    System.Console.WriteLine();
}