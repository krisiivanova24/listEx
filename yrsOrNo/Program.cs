using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yrsOrNo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> neList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            byte num = byte.Parse(Console.ReadLine());
            if (neList.Contains(num))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
            //Console.WriteLine(neList.Contains(num));
        }
    }
}
