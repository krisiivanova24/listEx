using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace list
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> neList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            byte num = byte.Parse(Console.ReadLine());
            neList.Add(num);
            neList.Sort();
            Console.WriteLine(string.Join(" ",neList));
        }
    }
}
