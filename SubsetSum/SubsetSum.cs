namespace SubsetSum
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SubsetSum
    {
        private static int totalSum;

        private static int[] numbers;

        private static bool solution;

        private static void Main()
        {            
            totalSum = int.Parse(Console.ReadLine());

            var readLine = Console.ReadLine();
            if (readLine != null)
            {
                numbers = readLine.Split(' ').Select(int.Parse).Distinct().ToArray();
            }

            Console.WriteLine("\nOutput:");
            var subset = new List<int>();
            MakeSubset(0, subset);
            if (!solution)
            {               
                Console.WriteLine("No matching subsets.");
            }
        }

        private static void MakeSubset(int index, List<int> subset)
        {
            if (subset.Sum() == totalSum && subset.Count > 0)
            {
                Console.WriteLine(" {0} = {1}", string.Join(" + ", subset), totalSum);
                solution = true; 
            }

            for (var i = index; i < numbers.Length; i++)
            {
                subset.Add(numbers[i]);
                MakeSubset(i + 1, subset);
  
                subset.RemoveAt(subset.Count - 1); 
            }
        }
    }
}