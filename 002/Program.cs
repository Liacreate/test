using System;
using System.Linq;

namespace _002
{
    class Program
    {
        static void Main(string[] args)
        {

            var x = int.Parse(Console.ReadLine());

            var a = Enumerable.Range(1, x).Reverse();

            int i = 0;

            foreach (var item in a)
            {
                i++;
                var b = Enumerable.Repeat(item, i);
                foreach (var c in b)
                {
                    Console.Write(c);
                }
                Console.WriteLine();
            }

          



            //Console.WriteLine(
            //string.Join(
            //    "\n",
            //    Enumerable.Range(1, int.Parse(Console.ReadLine()))
            //    .Reverse()
            //    .Select((x, index) => string.Concat(Enumerable.Repeat(x, index + 1)))

            //    ));








            //Console.WriteLine(Plus.Pattern(x));


            Console.ReadLine();

        }

        //public static class Plus
        //{
        //    public static string Pattern(int n)
        //    {
        //        return n < 1 ? "" : string.Join("\n",
        //            Enumerable
        //            .Range(1, n)
        //            .Select(i => string.Join("", Enumerable.Repeat(i, i))));
        //    }
        //}
    }
}
