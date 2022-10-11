/*
If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.
Finish the solution so that it returns the sum of all the multiples of 3 or 5 below the number passed in. Additionally, if the number is negative, return 0 (for languages that do have them).
Note: If the number is a multiple of both 3 and 5, only count it once.
https://www.codewars.com/kata/514b92a657cdc65150000006/train/csharp
*/

namespace CodeWars._6kyu
{
    internal class Multiples
    {
        /*
         return Enumerable.Range(0, n).Where(e => e % 3 == 0 || e % 5 == 0).Sum();
         */
        
        internal static int Solution(int value)
        {
            if(value <= 0) return 0;
            int result = 0,
                num = 3,
                i = 3;

            while (i < value)
            {
                if (num % 3 == 0 | num % 5 == 0)
                {
                    result += num;
                    System.Console.WriteLine(result);
                }
                num++;
                i++;
            }
            return result;
        }
    }
}