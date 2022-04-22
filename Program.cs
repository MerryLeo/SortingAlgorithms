namespace Sort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> myIntegers = new List<int> {5, -10, -252, 105, 8, 5, 102};
            myIntegers.QuickSort(0, myIntegers.Count - 1);
            Console.WriteLine(string.Join(", ", myIntegers));

            // ShowMenu();
        }

        public static void ShowMenu()
        {
            string? input;
            Console.Write("What kind of data do you want to sort? (T)ext or (N)umbers: ");
            input = Console.ReadLine();


        }
    }
}