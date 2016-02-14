namespace CategorizeNumbersAndFindMAxMinAvarage
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class CategorizeNumbersAndFindMAxMinAvarage
    {
        public static void Main()
        {
            var readLine = Console.ReadLine();
            if (readLine != null)
            {
                var numbersRead = readLine.Split().Select(double.Parse).ToArray();
                Array.Sort(numbersRead);

                var flotingPointNumber = new List<double>();
                var normalNumbers = new List<double>();

                for (int i = 0; i < numbersRead.Length; i++)
                {
                    if (numbersRead[i] % 1 == 0)
                    {
                        normalNumbers.Add(numbersRead[i]);
                    }
                    else
                    {
                        flotingPointNumber.Add(numbersRead[i]);
                    }
                }
                var minNormalNumber = normalNumbers.Min();
                var maxNormalNumber = normalNumbers.Max();
                var averageNormalNumbers = normalNumbers.Average();
                var sumNormalNumburs = normalNumbers.Sum();

                var minFloatNumber = flotingPointNumber.Min();
                var maxFloatNumber = flotingPointNumber.Max();
                var averagefloatNumber = flotingPointNumber.Average();
                var sumFlotingPointNumbers = flotingPointNumber.Sum();

                var result1 = string.Join(",", normalNumbers);
                var result2 = string.Join(",", flotingPointNumber);
                Console.WriteLine(
                    "[{0}] -> min: {1} max: {2} average:{3:##,##} sum:{4}",
                    result1,
                    minNormalNumber,
                    maxNormalNumber,
                    averageNormalNumbers,
                    sumNormalNumburs);
                Console.WriteLine(
                    "[{0}] -> min: {1} max: {2} average:{3:##,##} sum:{4}",
                    result2,
                    minFloatNumber,
                    maxFloatNumber,
                    averagefloatNumber,
                    sumFlotingPointNumbers);
            }
        }
    }
}

