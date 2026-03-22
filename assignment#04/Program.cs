using System.Security.Cryptography.X509Certificates;

namespace assignment_04;
internal class Program
{
    public static void Main(string[] args)
    {

        #region Question-part#01

        /*
        Console.Write("Please enter a number (0 - 6): ");

        int.TryParse(Console.ReadLine(), out int number);

        DayWeek day = (DayWeek)number;

        switch (day)
        {
            case DayWeek.Saturday:
                Console.WriteLine("The day is Saturday");
                Console.WriteLine("It's the Weekend");
                break;

            case DayWeek.Sunday:
                Console.WriteLine("The day is Sunday");
                break;

            case DayWeek.Monday:
                Console.WriteLine("The day is Monday");
                Console.WriteLine("It's a Workday");
                break;

            case DayWeek.Tuesday:
                Console.WriteLine("The day is Tuesday");
                break;

            case DayWeek.Wednesday:
                Console.WriteLine("The day is Wednesday");
                break;

            case DayWeek.Thursday:
                Console.WriteLine("The day is Thursday");
                break;

            case DayWeek.Friday:
                Console.WriteLine("The day is Friday");
                break;

            default:
                Console.WriteLine("Invalid number. Please enter a number between 0 and 6.");
                break;
        }
        
         */

        #endregion


        #region Question-part#02-1

        /*Console.Write("Please enter a valid integer = ");
        bool techek = int.TryParse(Console.ReadLine(), out int value);

        //Make sure the array number is an int number.
        while (!techek)
        {
            Console.WriteLine("Invalid input. Please enter a valid integer ");
            Console.Write("Please enter a valid integer : ");
            techek = int.TryParse(Console.ReadLine(), out value);
        }

        Console.WriteLine($"The input array size is: {value}");
        //Here we defined array size by user input.
        int[] array = new int[value];

        for (int i = 0; i < array.Length; i++)
        {
            Console.Write($"Enter element {i + 1}: ");
            bool isValid = int.TryParse(Console.ReadLine(), out int number);

            while (!isValid)
            {
                Console.Write("Invalid! Enter a valid integer: ");
                isValid = int.TryParse(Console.ReadLine(), out number);
            }

            array[i] = number;
        }

        Console.Write("Array elements : ");
        Double sum = 0;
        Double average = 0;
        int max = array[0];
        int min = array[0];
        //Print array values
        foreach (int item in array)
        {
            Console.Write(item + " ");
            sum += item;
            average = sum / array.Length;
            max = item > max ? item : max;
            min = item < min ? item : min;
        }
        Console.WriteLine();
        Console.WriteLine("Maximum value = " + max);
        Console.WriteLine("minimum value = " + min);
        Console.WriteLine("Sum = " + sum);
        Console.WriteLine("Average = " + average);*/

        #endregion

        #region Question-part#02-2
        /*
        
        int[,] gradesStd = new int[3, 4];

        Console.WriteLine("=== Student Grades Entry ===\n");

        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine($"Student {i + 1}:");
            for (int j = 0; j < 4; j++)
            {
                while (true)
                {
                    Console.Write($"  Subject {j + 1} grade: ");
                    if (int.TryParse(Console.ReadLine(), out int gradestd))
                    {
                        gradesStd[i, j] = gradestd;
                        break;
                    }
                    Console.WriteLine("  Invalid input. Please enter a whole number.");
                }
            }
            Console.WriteLine();
        }

        Console.WriteLine("=== Results ===\n");

        double totalSumClass = 0;

        for (int i = 0; i < 3; i++)
        {
            double studentSum = 0;
            for (int j = 0; j < 4; j++)
                studentSum += gradesStd[i, j];

            double studentAvg = studentSum / 4;
            totalSumClass += studentSum;
            Console.WriteLine($"Student {i + 1} average: {studentAvg:F3}");
        }

        double overallAvg = totalSumClass / (3 * 4);
        Console.WriteLine($"\nOverall class average: {overallAvg:F3}");

        */
        #endregion

        #region Question-part#03-1

        /*
        
        Console.Write("Enter the operation you want to do ( + , - , * , / ) : ");
        string operation = Console.ReadLine()!;

        while (operation != "+" && operation != "-" && operation != "*" && operation != "/")
        {
            Console.Write("Invalid operation. Please enter one of the following: +, -, *, /  => ");
            operation = Console.ReadLine()!;
        }

        Console.Write("Enter the number one : ");
        bool numbers = double.TryParse(Console.ReadLine(), out double num1);
        Console.Write("Enter the number two : ");
        numbers = double.TryParse(Console.ReadLine(), out double num2);
        
        switch (operation)
        {
            case "+":
                Console.WriteLine($"The result of addition is : {Add(num1, num2):F3}");
                break;
            case "-":
                Console.WriteLine($"The result of Subtract is : {Subtract(num1, num2):F3}");
                break;
            case "*":
                Console.WriteLine($"The result of Multiply is : {Multiply(num1, num2):F3}");
                break;
            case "/":
                Console.WriteLine($"The result of Divide is :{Divide(num1, num2):F3}");
                break;
        }
        
         */

        #endregion
    }

    #region Question-methods

    /*
    
    public static double Add(Double a, Double b)
    {
        return a + b;
    }
    public static double Subtract(Double a, Double b)
    {
        return a - b;
    }
    public static double Multiply(Double a, Double b)
    {
        return a * b;
    }
    public static double Divide(Double a, Double b)
    {
        return a / b;
    }
    
     */

    #endregion
}