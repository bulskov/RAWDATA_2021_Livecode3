using System;
using System.Collections.Generic;

namespace Iterators
{
    class Program
    {
        static void Main(string[] args)
        {
            var l = new int[] { 1, 2, 3, 4, 5 };

            //var iter = l.GetEnumerator();

            //while(iter.MoveNext())
            //{
            //    Console.WriteLine(iter.Current);
            //}
            //foreach(var i in l)
            //    Console.WriteLine(i);

            foreach(var x in GetOddNumbers(5000))
                Console.WriteLine(x);

        }


        static IEnumerable<int> GetOddNumbers(int amount)
        {
            var num = 0;

            while(true)
            {
                if (amount <= 0)
                    yield break;

                if (num % 2 != 0)
                {
                    yield return num;
                    amount--;
                }
                num++;
            }
        }

        static IEnumerable<int> GetNumbers() {
            yield return 1;
            yield return 2;
            yield return 3;
        }
    }
}
