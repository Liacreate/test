using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001
{
    class Program
    {
        static void Main(string[] args)
        {
            //string number = Console.ReadLine();
            //string[] x = number.Split(',');

            string[] x = Console.ReadLine().Split(',');

           var a = x.Reverse();
  
            Console.WriteLine($"{string.Join((","), a)}");


            //List<int> _list = new List<int>();

            //foreach (var y in x)
            //{
            //    int z = int.Parse(y);
            //    _list.Add(z);
            //}

            //Console.WriteLine($"{string.Join((","), _list)}");



            Console.ReadLine();
        }
        
    }
}
