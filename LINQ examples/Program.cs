using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ_examples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(otherLINQ.IsDecrementing(5431));
        }
    }


    public static class otherLINQ
    {
        public static bool IsDecrementing(int number) => "09876543210".Contains(number.ToString());
        public static bool IsIncrementing(int number) => "01234567890".Contains(number.ToString());
        public static bool AllEqual(int number) => number.ToString().Distinct().Count() == 1;
        public static bool linqSameDigitsNumber(int number) => number.ToString().Skip(1).All(c => c == number.ToString()[0]);
        public static bool AllFollowingAreZeros(int number) => number.ToString().Skip(1).All(x => x == '0');
        public static bool IsPalindrome(int number) => number.ToString() == string.Concat(number.ToString().Reverse());
        public static bool linqPalindrome(int number) => number.ToString().SequenceEqual(number.ToString().Reverse());
        public static bool IsZero(int number) => number == 0;


       


        



    }


}
