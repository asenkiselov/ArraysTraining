namespace SequencesOfEqualStrings
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main(string[] args)
        {
            var input = Console.ReadLine().Split();

            for (int i = 0; i < input.Length; i++)
            {
                Console.Write(input[i] + " ");
               
                if (input[i] != input[(i + 1) % input.Length])
                {
                    Console.WriteLine();
                }     
            }
        }
    }
}