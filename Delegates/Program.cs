using System;
using System.Collections.Generic;

namespace Delegates
{
    class Program
    {
        delegate int Transformer(int x);
        static void Main(string[] args)
        {
            var t = new Transformer(Square);

            Console.WriteLine(t(3));

            Print(t, 4);

            t = new Transformer(Cube);


            Print(t, 4);



            Func<int, int> foo = x => x + 100;




            Print(t, 5);

            List<Func<int, int>> l = new List<Func<int, int>>();

            l.Add(foo);

            var x = Func(4);

            x(6);

        }


        static void Print(Transformer t, int value)
        {
            Console.WriteLine(t(value));
        }

        static int Square(int num)
        {

            return num * num;
        }

        static int Cube(int num)
        {
            return num * num * num;
        }

        static Func<int,int> Func(int num)
        {
            int value = 5;
            return x => num * value;
        }
    }
}
