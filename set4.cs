//1
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
            for (int j = 0; j < n - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }



        foreach (int num in arr)
        {
            System.Console.Write(num + " ");
        }
    }

}





