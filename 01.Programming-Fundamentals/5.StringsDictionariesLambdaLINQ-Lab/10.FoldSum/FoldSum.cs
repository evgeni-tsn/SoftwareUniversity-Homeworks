﻿using System;
using System.Linq;

namespace _10.FoldSum
{
    /* 
     * Read an array of 4*k integers, fold it like shown below, 
     * and print the sum of the upper and lower rows (2 * k integers)
     * You can check your solutions here: 
     * https://judge.softuni.bg/Contests/174/Strings-Dictionaries-Lambda-and-LINQ-Lab
     */
    class FoldSum
    {
        static void Main()
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int k = input.Length / 4;
            var rowLeft = input.Take(k).Reverse();
            var rowRight = input.Reverse().Take(k);

            var row1 = rowLeft.Concat(rowRight).ToArray();
            var row2 = input.Skip(k).Take(2 * k).ToArray();
            var sumArr = row1.Select((x, index) => x + row2[index]);
            Console.WriteLine(string.Join(" ", sumArr));
        }
    }
}
