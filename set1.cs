class matrixAdd{
    static void input(int[,]matrix,int m,int n)
    {
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                System.Console.Write($"Enter the element of [{i},{j}]: ");
                matrix[i,j]=int.Parse(Console.ReadLine());
            }
        }
    }
    static void print(int[,]matrix, int m, int n)
    {
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                System.Console.Write(matrix[i,j]+"\t");
            }
            System.Console.WriteLine();
        }
    }

    static void Main()
    {
        System.Console.WriteLine("Enter the row of the matrix: ");
        int m = int.Parse(Console.ReadLine());

        System.Console.WriteLine("Enter the coloumn of the matrix: ");
        int n = int.Parse(Console.ReadLine());

        int[,] matrix1 = new int[m,n];
        int[,] matrix2 = new int[m,n];
        int[,] sumMatrix = new int[m,n];

        System.Console.WriteLine("enter the element of 1st matrix: ");
        input(matrix1 ,m ,n);
        System.Console.WriteLine("enter the element of 2st matrix: ");
        input(matrix2 ,m ,n);

        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                sumMatrix[i,j]=matrix1[i,j]+matrix2[i,j];
            }
        }
        System.Console.WriteLine("Sum of two matrices is: ");
        print(sumMatrix,m,n);
    }

}







class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the number of elements: ");
        int n = int.Parse(Console.ReadLine());

        int[] arr = new int[n];

        System.Console.WriteLine("Enter the elements: ");
        for (int i = 0; i < n; i++)
        {
            System.Console.Write($"Enter element {i+1}: ");
            arr[i] = int.Parse(Console.ReadLine());
        }
        InsertionSort(arr);

        Console.WriteLine("\nSorted array:");
        foreach (int num in arr)
        {
            Console.Write(num + " ");
        }
    }
    static void InsertionSort(int[]arr)
    {
        for (int i = 1; i < arr.Length; i++)
        {
            int temp = arr[i];
            int j = i - 1;
            while (j >= 0 && arr[j]>temp)
            {
                arr[j+1] = arr[j];
                j--;
            }
            arr[j+1]=temp;
        }
    }
}











class TemperatureClassifier
{
    static void Main()
    {
        Console.Write("Enter the temperature: ");
        int temperature = int.Parse(Console.ReadLine());

        if (temperature < 0)
        {
            Console.WriteLine("The temperature is classified as: Freezing");
        }
        else if (temperature >= 0 && temperature < 15)
        {
            Console.WriteLine("The temperature is classified as: Cold");
        }
        else if (temperature >= 15 && temperature < 25)
        {
            Console.WriteLine("The temperature is classified as: Warm");
        }
        else if (temperature >= 25 && temperature < 35)
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




class StringComparisonProgram
{
    static void Main()
    {
        Console.Write("Enter first string: ");
        string str1 = Console.ReadLine();

        Console.Write("Enter second string: ");
        string str2 = Console.ReadLine();

        if (str1 == str2)
        {
            Console.WriteLine("Equal");
        }
        else
        {
            Console.WriteLine("Not Equal");
        }
    }
}

