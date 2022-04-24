namespace Sort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> myIntegers = new List<int> {5, -10, -252, 105, 8, 5, -102, 55, -202, -32, 102};
            List<int> copyOfList = new List<int>(myIntegers);
            SortStatistic stat = copyOfList.BubbleSort();
            Console.WriteLine($"Bubble Sort returned: {string.Join(", ", myIntegers)}");
            stat.PrintStatistic();

            copyOfList = new List<int>(myIntegers);
            stat = copyOfList.CocktailSort();
            Console.WriteLine($"\nCocktail Sort returned: {string.Join(", ", myIntegers)}");
            stat.PrintStatistic();

            copyOfList = new List<int>(myIntegers);
            stat = copyOfList.QuickSort();
            Console.WriteLine($"\nQuick Sort returned: {string.Join(", ", myIntegers)}");
            stat.PrintStatistic();
        }
    }
}