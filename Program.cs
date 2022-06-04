using System.Text;
using static System.Console;

namespace Sort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string? input;
            ConsoleKey keyEntered;
            SortStatistic sortingStats;
            List<IComparable> originalList = new List<IComparable>(), sortedList = new List<IComparable>();
            StringBuilder results = new StringBuilder();
            bool validInput;

            // Get type of data to sort from user
            WriteLine("What kind of data do you want to sort? Press T for text or N for numbers: ");
            keyEntered = ReadKey().Key;
            while (keyEntered != ConsoleKey.T && keyEntered != ConsoleKey.N)
            {
                WriteLine("\nYour input was invalid. Try again: Press T for text or N for numbers: ");
                keyEntered = ReadKey().Key;
            }

            // Get strings from user
            if (keyEntered == ConsoleKey.T)
            {
                WriteLine("\nEnter a list of words seperated by a comma and a space (ex: Apple, Orange, Green): ");
                validInput = false;
                while (!validInput)
                {
                    try
                    {
                        input = ReadLine() ?? throw new ArgumentNullException();
                        originalList = input.Split(", ").Cast<IComparable>().ToList();
                        if (originalList.Count > 1)
                            validInput = true;
                    }
                    catch (System.Exception) { }
                    if (!validInput) 
                        WriteLine("Your words were an invalid input. Try again: ");
                }
            }

            // Get numbers from user
            else
            {
                WriteLine("\nEnter a list of numbers seperated by a comma and a space (ex: 1, -23, 5, 102): ");
                validInput = false;
                while (!validInput)
                {
                    try
                    {
                        input = ReadLine() ?? throw new ArgumentNullException();
                        originalList = input.Split(", ").Select(x => float.Parse(x)).Cast<IComparable>().ToList();
                        if (originalList.Count > 1)
                            validInput = true;
                    }
                    catch (System.Exception) { }
                    if (!validInput) 
                        WriteLine("Your numbers were an invalid input. Try again: ");
                }
            }

            results.AppendLine("\nResults:");

            // Bubble Sort
            sortedList = new List<IComparable>(originalList);
            sortingStats = sortedList.BubbleSort();
            results.AppendLine($"\nBubble Sort returned: {string.Join(", ", sortedList)}");
            results.AppendLine(sortingStats.Results);

            // Quick Sort
            sortedList = new List<IComparable>(originalList);
            sortingStats = sortedList.QuickSort();
            results.AppendLine($"\nQuick Sort returned: {string.Join(", ", sortedList)}");
            results.AppendLine(sortingStats.Results);

            // Cocktail Sort
            sortedList = new List<IComparable>(originalList);
            sortingStats = sortedList.CocktailSort();
            results.AppendLine($"\nCocktail Sort returned: {string.Join(", ", sortedList)}");
            results.AppendLine(sortingStats.Results);

            WriteLine(results.ToString());
        }
    }
}