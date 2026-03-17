namespace assignment_04;
internal class Program
{
    static void Main(string[] args)
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
            
        #endregion
    }
}