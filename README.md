# SortingAlgorithms
This is my attempt at remaking three of the most popular sorting algorithms: Bubble Sort, Quick Sort, and Cocktail Sort. </br>
This project was built in Dotnet 6.0. To run it, simply clone this repos, and enter the command `dotnet run` inside the project folder.

Once the project is running, two types of data can be sorted: Text (strings) or Numbers (floats). </br>
Note that the different functions can be called on any object that implements the `IList<IComparable>` interfaces. </br>

## Bubble Sort
This algorithm sorts a collection by comparing each value individually to the next in the collection. If the next value is inferior to the previous one, then both of these values are swapped in the collection. Once a full iteration over the collection has been completed without any swap, the sorted collection is returned. 

## Cocktail Sort
Similarly to the bubblesort algorithm, it sorts a collection by comparing each value individually and by swapping them if needed. The only key difference is the direction in which in sorts the data: the algorithm sorts from left to right, then from right to left and repeats. Again, like the bubblesort, once a full iteration over the collection has been completed without any swap, the sorted collection is returned. 

## Quick Sort
This algorithm picks a value (called the pivot) in the collection and seperates the collection into two: values that are inferior to the pivot go before it, and values that are greater than the pivot go after it. This yields two different collections, which Quick Sort calls himself on both. Quick Sort returns the sorted collection once the collection is too small to be sorted (has only one value or less).

## Credits
1. [Bubble Sort](https://www.geeksforgeeks.org/bubble-sort/) from GeeksforGeeks.
2. [Cocktail Sort](https://www.geeksforgeeks.org/cocktail-sort/) from GeeksforGeeks.
3. [Quick Sort](https://www.geeksforgeeks.org/quick-sort/) from GeeksforGeeks.
