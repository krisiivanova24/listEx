using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace imena
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> neList1 = Console.ReadLine().Split(',').ToList();
            for (int i = 0; i < neList1.Count; i++)
            {
                List<string> names = new List<string>();
                names = neList1[i].Split(' ').ToList();
                names.Reverse();
                
                
                Console.WriteLine(string.Join(" ", names));
            }
        }
    }
}
