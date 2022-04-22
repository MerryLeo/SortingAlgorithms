namespace Sort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> intArr = new List<int> { 1, -8, 3, 5, 129, -39, 42, -5, 2, -10 };
            intArr.BubbleSort();
            Console.WriteLine(string.Join(", ", intArr));
            
            List<string> stringArr = new List<string> {"Leo", "Benjamin", "Julie", "Patrick"};
            stringArr.BubbleSort();
            Console.WriteLine(string.Join(", ", stringArr));
        }
    }
}