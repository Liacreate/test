using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003
{
    class Program
    {
        static void Main(string[] args)
        {
             string[] input = (Console.ReadLine().Split(','));
            var a =  string.Join(",",input.Where(o=>int.Parse(o)%2==0).OrderBy(o=>o));
            var b =  string.Join(",",input.Where(o=>int.Parse(o)%2!=0).OrderBy(o=>o));

            Console.WriteLine($"even:{a} \nodd:{b}");

            


            //Console.WriteLine(string.Join(Environment.NewLine, Console.ReadLine().Split(',')
            //    .Select(o => int.Parse(o)).OrderBy(o => o).GroupBy(o => o % 2)
            //    .Select(o => $"{(o.Key == 0 ? "even" : "odd")}:{string.Join(",", o)}")));

            Console.ReadLine();
        }
    }
}
