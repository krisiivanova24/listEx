using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace preobrazuvane
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            List<int> newNum = new List<int>(arr.Length);
            List<int> newNum2 = new List<int>();
            int num = 0;
            int num2 = 0;
            for (int i = 0; i < arr.Length - 1; i++)
            {


                num = arr[i] + arr[i + 1];
                newNum.Add(num);
            }
            for (int k = 0; k < newNum.Count-1; k++)
            {

                num2 = newNum[k] + newNum[k + 1];
                

            }
            Console.WriteLine(num2);
        }
    }
}
