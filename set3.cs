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








//3

class Calculator
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        double num1 = Convert.ToDouble(Console.ReadLine());
        
        Console.Write("Enter second number: ");
        double num2 = Convert.ToDouble(Console.ReadLine());
        
        Console.Write("Select operation (+, -, *, /): ");
        char operation = Convert.ToChar(Console.ReadLine());

        double result;
        
        switch (operation)
        {
            case '+':
                result = num1 + num2;
                Console.WriteLine($"Result: {result}");
                break;
            case '-':
                result = num1 - num2;
                Console.WriteLine($"Result: {result}");
                break;
            case '*':
                result = num1 * num2;
                Console.WriteLine($"Result: {result}");
                break;
            case '/':
                if (num2 != 0)
                {
                    result = num1 / num2;
                    Console.WriteLine($"Result: {result}");
                }
                else
                {
                    Console.WriteLine("Error: Division by zero is not allowed.");
                }
                break;
            default:
                Console.WriteLine("Invalid operation selected.");
                break;
        }
    }
}





          
