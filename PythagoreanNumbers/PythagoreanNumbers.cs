namespace PythagoreanNumbers
{
    using System;

    public class PythagoreanNumbers
    {
        public static void Main(string[] args)
        {
            var countNumbers = int.Parse(Console.ReadLine());

            int[] numbers = new int[countNumbers];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            bool isPrint = false;

            for (int a = 0; a < countNumbers; a++)
            {
                for (int b = 0; b < countNumbers; b++)
                {
                    for (int c = 0; c < countNumbers; c++)
                    {
                        if (numbers[a] <= numbers[b])
                        {
                            if (Math.Pow(numbers[a], 2) + Math.Pow(numbers[b], 2) == Math.Pow(numbers[c], 2))
                            {
                                Console.WriteLine("{0}*{0} + {1}*{1} = {2}*{2}", numbers[a], numbers[b], numbers[c]);
                                isPrint = true;
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
