class Mmul{
    static void Main()
    {
        int[,] matrix1= new int[3,3];
        int[,] matrix2= new int[3,3];
        int[,] resmatrix= new int[3,3];

        System.Console.WriteLine("Enter the element of 1st matrix: ");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write($"Enter element [{i},{j}]");
                matrix1[i,j]= int.Parse(Console.ReadLine());
            }
        }

         System.Console.WriteLine("Enter the element of 2nd matrix: ");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write($"Enter element [{i},{j}]");
                matrix2[i,j]= int.Parse(Console.ReadLine());
            }
        }


        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                resmatrix[i,j] = 0;
                for (int k = 0; k < 3; k++)
                {
                    resmatrix[i,j]+=matrix1[i,k]*matrix2[k,j];
                }
            }
        }

         System.Console.WriteLine("Result matrix: ");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write(resmatrix[i,j]+"\t");

            }
            Console.WriteLine();
        }
    }
}





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








class P{
    static void Main()
    {
        System.Console.WriteLine("Enter the number of elements: ");
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];

        System.Console.WriteLine("Enter the element: ");
        for (int i = 0; i < n; i++)
        {
            System.Console.Write($"Element {i+1}: ");
            arr[i]=int.Parse(Console.ReadLine());
        }
        int min=0;
        int max =0;

        for (int i = 1; i < n; i++)
        {
            if (arr[i]<arr[min])
            {
                min = i;
            }
            if (arr[i]>arr[max])
            {
                max=i;
            }
        }
        int temp = arr[min];
        arr[min] = arr[max];
        arr[max] = temp;

        System.Console.WriteLine("Array after swapping largest element and smallest element");
        foreach ( int num in arr)
        {
            System.Console.Write(num+" ");
        }


    }
}







class Election
{
    static void Main()
    {
        Console.Write("Enter the number of votes: ");
        int n = int.Parse(Console.ReadLine());

        int[] votes = new int[5];  // Array for candidates 1 to 5
        int spoiled = 0;  // Counter for spoiled ballots

        Console.WriteLine("Enter votes (1-5 for candidates, any other number for NOTA):");
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Vote {i + 1}: ");
            int vote = int.Parse(Console.ReadLine());

            if (vote >= 1 && vote <= 5)
            {
                votes[vote - 1]++; // Increment candidate's vote count
            }
            else
            {
                spoiled++; // Increment spoiled ballot count
            }
        }

        // Display results
        Console.WriteLine("\nElection Results:");
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"Candidate {i + 1}: {votes[i]} votes");
        }
        Console.WriteLine($"Spoiled Ballots (NOTA): {spoiled}");
    }
}
