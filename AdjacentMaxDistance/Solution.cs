using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace AdjacentMaxDistance
{
    public class Solution
    {
        static void Main(string[] args)
        {
            int[] arr = { 0, 3, 3, 12, 5, 3, 7, 1, -12 , -9, -8, 0, -19};
            //int[] arr = { 1, 2, 3, 4, 7 };

            Console.WriteLine("Max adjacent distance: {0}", solution(arr));
            Console.ReadLine();
        }

        static int solution(int[] arr)
        {
            int maxDistance = -2;
            int newMaxDistance = 0;
            int result = 0;

            int[] sortedCopy = arr.Select(i => Math.Abs(i)).OrderBy(i => i).ToArray();

            for (int i = 0; i < sortedCopy.Length - 1; i++)
            {
                result = Math.Abs(sortedCopy[i] - sortedCopy[i + 1]);
                if (result > newMaxDistance)
                {
                    newMaxDistance = result;
                    maxDistance = newMaxDistance;
                }
            }

            return maxDistance;
        }
    }
}
