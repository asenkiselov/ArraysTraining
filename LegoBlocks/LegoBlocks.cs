namespace LegoBlocks
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class LegoBlocks
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            // Create the matrix.
            var matrix = new List<List<int>>();
            var row = new List<int>();

            for (var j = 1; j <= 2 * n; j++)
            {
                row = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToList(); // Each row is a list.
                matrix.Add(row); // Add each row to a nested list named matrix.
            }

            // Check if two blocks fit together.
            var fit = true;

            for (var i = 1; i < n; i++)
            {
                if (matrix[i].Count + matrix[i + n].Count != matrix[i - 1].Count + matrix[i - 1 + n].Count)
                {
                    fit = false;
                    break;
                }
            }

            // Print results.
            if (fit)
            {
                for (var i = 0; i < n; i++)
                {
                    matrix[i + n].Reverse();
                    Console.WriteLine(
                        "[" + string.Join(", ", matrix[i]) + ", " + string.Join(", ", matrix[i + n].ToList()) + "]");
                }
            }
            else
            {
                var sum = 0;

                // Sum of cells calculation.
                for (var i = 0; i < 2 * n; i++)
                {
                    sum += matrix[i].Count;
                }

                Console.WriteLine("The total number of cells is: {0}", sum);
            }
        }
    }
}