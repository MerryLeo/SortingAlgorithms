using System.Diagnostics;

namespace Sort
{
    public static class MySortClass
    {
        public static SortStatistic BubbleSort<T>(this IList<T> list) where T : IComparable
        {
            SortStatistic stat = new SortStatistic();
            stat.stopWatch.Start();
            bool isSorted = false;
            while (!isSorted)
            {
                isSorted = true;
                for (int i = 0; i < list.Count - 1; i++)
                {
                    stat.compareCount++;
                    T element = list.ElementAt(i), nextElement = list.ElementAt(i + 1);
                    if (element.CompareTo(nextElement) > 0)
                    {
                        stat.swapCount++;
                        list.Swap(i, i + 1);
                        isSorted = false;
                    }
                }
            }
            stat.stopWatch.Stop();
            return stat;
        }

        public static SortStatistic QuickSort<T>(this IList<T> list) where T : IComparable
        {
            SortStatistic statistic = new SortStatistic();
            statistic.stopWatch.Start();
            int firstIndex = 0, lastIndex = list.Count - 1;
            if (firstIndex < lastIndex)
            {
                int partitionIndex = list.Partition(firstIndex, lastIndex, ref statistic);
                list.QuickSort(firstIndex, partitionIndex - 1, ref statistic);
                list.QuickSort(partitionIndex + 1, lastIndex, ref statistic);
            }
            statistic.stopWatch.Stop();
            return statistic;
        }

        private static void QuickSort<T>(this IList<T> list, int firstIndex, int lastIndex, ref SortStatistic statistic) where T : IComparable
        {
            if (firstIndex < lastIndex)
            {
                int partitionIndex = list.Partition(firstIndex, lastIndex, ref statistic);
                list.QuickSort(firstIndex, partitionIndex - 1, ref statistic);
                list.QuickSort(partitionIndex + 1, lastIndex, ref statistic);
            }
        }

        public static SortStatistic CocktailSort<T>(this IList<T> list) where T : IComparable
        {
            SortStatistic statistic = new SortStatistic();
            statistic.stopWatch.Start();
            bool isSorted = false;
            while (!isSorted)
            {
                isSorted = true;
                int i;
                for (i = 0; i < list.Count - 1; i++)
                {
                    T element = list.ElementAt(i), nextElement = list.ElementAt(i + 1);
                    statistic.compareCount++;
                    if (element.CompareTo(nextElement) > 0)
                    {
                        statistic.swapCount++;
                        list.Swap(i, i + 1);
                        isSorted = false;
                    }
                }
                for (i = list.Count - 1; i > 0; i--)
                {
                    T element = list.ElementAt(i), nextElement = list.ElementAt(i - 1);
                    statistic.compareCount++;
                    if (element.CompareTo(nextElement) < 0)
                    {
                        statistic.swapCount++;
                        list.Swap(i, i - 1);
                        isSorted = false;
                    }
                }
            }
            statistic.stopWatch.Stop();
            return statistic;
        }

        public static int Partition<T>(this IList<T> collection, int minIndex, int maxIndex, ref SortStatistic statistic) where T : IComparable
        {
            int pivot = maxIndex;
            int i = -1, j = 0;
            T elementJ;
            T pivotElement = collection.ElementAt(pivot);
            for (j = 0; j < maxIndex; j++)
            {
                elementJ = collection.ElementAt(j);
                statistic.compareCount++;
                if (elementJ.CompareTo(pivotElement) <= 0)
                {
                    i++;
                    statistic.swapCount++;
                    collection.Swap(i, j);
                }
            }
            statistic.swapCount++;
            collection.Swap(maxIndex, i + 1);
            return i + 1;
        }

        public static void Swap<T>(this IList<T> collection, int firstIndex, int nextIndex)
        {
            T firstElement = collection.ElementAt(firstIndex), nextElement = collection.ElementAt(nextIndex);
            collection.RemoveAt(firstIndex);
            collection.Insert(firstIndex, nextElement);
            collection.RemoveAt(nextIndex);
            collection.Insert(nextIndex, firstElement);
        }
    }
    public class SortStatistic
    {
        public Stopwatch stopWatch;
        public int swapCount, compareCount;
        public SortStatistic()
        {
            this.stopWatch = new Stopwatch();
            this.swapCount = this.compareCount = 0;
        }
        public void PrintStatistic() => Console.WriteLine($"It took {stopWatch.Elapsed.TotalMilliseconds}ms to sort the list, swapped {swapCount} values, and compared {compareCount} values.");
    }
}