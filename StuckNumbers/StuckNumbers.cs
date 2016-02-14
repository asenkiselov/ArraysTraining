namespace StuckNumbers
{
    using System;
    using System.Linq;

    public class StuckNumbers
    {
        public static void Main()
        {
            var countNumber = int.Parse(Console.ReadLine());
            var numbers = Console.ReadLine().Split().Distinct().ToArray();
            bool isPrint = false;

            for (int a = 0; a < countNumber; a++)
            {
                for (int b = 0; b < countNumber; b++)
                {
                    for (int c = 0; c < countNumber; c++)
                    {
                        for (int d = 0; d < countNumber; d++)
                        {
                            if (a != b && a != c && a != d && b != c && b != d && c != b)
                            {
                                string first = numbers[a] + numbers[b];
                                string second = numbers[c] + numbers[d];
                                if (first == second)
                                {
                                    Console.WriteLine(
                                        "{0}|{1}=={2}|{3}", 
                                        numbers[a], 
                                        numbers[b], 
                                        numbers[c], 
                                        numbers[d]);
                                    isPrint = true;
                                }
                             }
                        }
                    }
                }
            }

            if (isPrint == false)
            {
                Console.WriteLine("No");
            }
        }
    }
}