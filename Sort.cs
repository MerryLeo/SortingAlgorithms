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
                    T element = list.ElementAt(i);
                    T nextElement = list.ElementAt(i + 1);
                    
                    // Swap Elements
                    if (element.CompareTo(nextElement) > 0)
                    {
                        isSorted = false;
                        list.Swap(element, nextElement, i, i + 1);
                    }
                }
            }
        }

        public static void Swap<T>(this IList<T> collection, T firstValue, T nextValue, int firstIndex, int nextIndex)
        {
            IList<T> colAsList = collection;
            if (colAsList != null)
            {
                colAsList.RemoveAt(firstIndex);
                colAsList.Insert(firstIndex, nextValue);
                colAsList.RemoveAt(nextIndex);
                colAsList.Insert(nextIndex, firstValue);
            }
            else
            {
                throw new ArgumentNullException("List could not be converted to IList<T>");
            }
        }
    }
}