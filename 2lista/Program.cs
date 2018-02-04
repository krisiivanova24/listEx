using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2lista
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> neList1 = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> neList2 = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> neList3 = new List<int>(neList1.Count+neList2.Count);
            neList3.AddRange(neList1);
            neList3.AddRange(neList2);
            neList3.Sort();
            Console.WriteLine(string.Join(" ",neList3));
        }
    }
}
