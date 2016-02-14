namespace LongestIncreasingSequence
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class LongestIncreasingSequence
    {
        public static void Main()
        {
            var readLine = Console.ReadLine();
            if (readLine != null)
            {
                List<int> nums = readLine.Split(' ').Select(int.Parse).ToList();

                List<int> output = new List<int>();
                List<int> longestS = new List<int>();

                while (nums.Count > 0)
                {
                    output.Add(nums[0]);
                    nums.Remove(nums[0]);

                    for (int i = 0; i < nums.Count; i++)
                    {
                        if (nums[i] > output[output.Count - 1])
                        {
                            output.Add(nums[i]);
                            nums.Remove(nums[i]);
                            i--;
                        }
                        else
                        {
                            break;
                        }
                    }

                    if (longestS.Count < output.Count)
                    {
                        longestS.Clear();
                        longestS.InsertRange(0, output);
                    }

                    Console.WriteLine(string.Join(" ", output));
                    output.Clear();
                }

                Console.WriteLine("Longest: " + string.Join(" ", longestS));
            }
        }
    }
}
