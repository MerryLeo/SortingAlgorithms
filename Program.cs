namespace Sort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Get type of data to sort from user
            string? input;
            Console.Write("What kind of data do you want to sort? (T)ext or (N)umbers: ");
            input = Console.ReadLine();
            if (input != "T" && input != "N")
            {
                bool validInput = false;
                while (!validInput)
                {
                    Console.WriteLine("Your input was invalid. Try again (T)ext or (N)umbers: ");
                    input = Console.ReadLine();
                    validInput = input == "T" || input == "N";
                }
            }
            
            if (input == "T")
            {
                Console.Write("\nEnter a list of words seperated by a comma and a space (ex: Apple, Orange, Green): ");
                input = Console.ReadLine() ?? throw new ArgumentNullException();
                List<string> list = input.Split(", ").ToList();
                
                // Print Results
                Console.WriteLine("\nResults: ");

                // Sort with Bubble Sort
                List<string> copyList = new List<string>(list);
                SortStatistic statistic = copyList.BubbleSort();
                Console.WriteLine($"Bubble Sort returned: {string.Join(", ", copyList)}");
                statistic.PrintStatistic();

                // Reset List and Sort with Quick Sort
                copyList = new List<string>(list);
                statistic = copyList.QuickSort();
                Console.WriteLine($"\nQuick Sort returned: {string.Join(", ", copyList)}");
                statistic = copyList.QuickSort();
                statistic.PrintStatistic();

                // Reset List and Sort with Cocktail Sort
                copyList = new List<string>(list);
                statistic = copyList.CocktailSort();
                Console.WriteLine($"\nCocktail Sort returned: {string.Join(", ", copyList)}");
                statistic.PrintStatistic();
            }
            else
            {
                Console.Write("\nEnter a list of numbers seperated by a comma and a space (ex: 1, -23, 5, 102): ");
                input = Console.ReadLine() ?? throw new ArgumentNullException();
                List<float> list = input.Split(", ").Select(x => float.Parse(x)).ToList();

                // Print Results
                Console.WriteLine("\nResults: ");

                // Sort with Bubble Sort
                List<float> copyList = new List<float>(list);
                SortStatistic statistic = copyList.BubbleSort();
                Console.WriteLine($"Bubble Sort returned: {string.Join(", ", copyList)}");
                statistic.PrintStatistic();

                // Reset List and Sort with Quick Sort
                copyList = new List<float>(list);
                statistic = copyList.QuickSort();
                Console.WriteLine($"\nQuick Sort returned: {string.Join(", ", copyList)}");
                statistic = copyList.QuickSort();
                statistic.PrintStatistic();

                // Reset List and Sort with Cocktail Sort
                copyList = new List<float>(list);
                statistic = copyList.CocktailSort();
                Console.WriteLine($"\nCocktail Sort returned: {string.Join(", ", copyList)}");
                statistic.PrintStatistic();
            }
        }
    }
}