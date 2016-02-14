namespace SortArraysOfNumbers
{
    using System;
    using System.Linq;

    public class SortArraysOfNumbers
    {
        public static void Main()
        {
            var readLine = Console.ReadLine();
            if (readLine != null)
            {
                var numberToSort = readLine.Split().Select(int.Parse).ToArray();

                for (int i = 0; i < numberToSort.Length - 1; i++)
                {
                    int min = i;
                    for (int j = i + 1; j < numberToSort.Length; j++)
                    {
                        if (numberToSort[j] < numberToSort[min])
                        {
                            min = j;
                        }
                    }

                    if (min != i)
                    {
                        var temp = numberToSort[i];
                        numberToSort[i] = numberToSort[min];
                        numberToSort[min] = temp;
                    }
                }

                Console.Write(string.Join(" ", numberToSort));
            }
        }
    }
}
