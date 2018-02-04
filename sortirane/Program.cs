using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sortirane
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> neList1 = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            
            for (int i = 0; i < neList1.Count; i++)
            {
                for (int j = 0; j< neList1.Count-1; j++)
                {
                    if (neList1[j]>neList1[j+1])
                    {
                        int x = neList1[j];
                        neList1[j] = neList1[j + 1];
                        neList1[j + 1] = x;
                    }
                }
            }
            
            Console.WriteLine(string.Join(" ", neList1));
        }
    }
}
