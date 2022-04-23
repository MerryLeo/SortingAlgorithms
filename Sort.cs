namespace Sort
{
    public static class MySortClass
    {
        
        public static void BubbleSort<T>(this IList<T> list) where T : IComparable
        {
            bool isSorted = false;
            while (!isSorted)
            {
                isSorted = true;
                for (int i = 0; i < list.Count - 1; i++)
                {
                    T element = list.ElementAt(i), nextElement = list.ElementAt(i + 1);
                    if (element.CompareTo(nextElement) > 0)
                    {
                        list.Swap(i, i + 1);
                        isSorted = false;
                    }
                }
            }
        }

        public static void QuickSort<T>(this IList<T> list, int firstIndex, int lastIndex) where T : IComparable
        {
            if (firstIndex < lastIndex)
            {
                int partitionIndex = list.Partition(firstIndex, lastIndex);
                list.QuickSort(firstIndex, partitionIndex - 1);
                list.QuickSort(partitionIndex + 1, lastIndex);
            }
        }

        public static void CocktailSort<T>(this IList<T> list) where T : IComparable
        {
            bool isSorted = false;
            while (!isSorted)
            {
                isSorted = true;
                int i;
                for (i = 0; i < list.Count - 1; i++)
                {
                    T element = list.ElementAt(i), nextElement = list.ElementAt(i + 1);
                    if (element.CompareTo(nextElement) > 0)
                    {
                        list.Swap(i, i + 1);
                        isSorted = false;
                    }
                }
                for (i = list.Count - 1; i > 0; i--)
                {
                    T element = list.ElementAt(i), nextElement = list.ElementAt(i - 1);
                    if (element.CompareTo(nextElement) < 0)
                    {
                        list.Swap(i, i - 1);
                        isSorted = false;
                    }
                }
            }
        }

        /// <summary>
        /// Move all elements smaller than element at maxIndex before it and all elements greater than element at maxIndex after it
        /// </summary>
        /// <param name="collection"></param>
        /// <param name="minIndex">First index of the collection</param>
        /// <param name="maxIndex">Last index of the collection</param>
        /// <typeparam name="T"></typeparam>
        /// <returns>New index of element at maxIndex</returns>
        public static int Partition<T>(this IList<T> collection, int minIndex, int maxIndex) where T : IComparable
        {
            int pivot = maxIndex;
            int i = -1, j = 0;
            T elementJ;
            T pivotElement = collection.ElementAt(pivot);
            for (j = 0; j < maxIndex; j++)
            {
                elementJ = collection.ElementAt(j);
                if (elementJ.CompareTo(pivotElement) <= 0)
                {
                    i++;
                    collection.Swap(i, j);
                }
            }
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
}