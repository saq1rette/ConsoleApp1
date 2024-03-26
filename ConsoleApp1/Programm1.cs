using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    static class Programm1
    {
        public static void main()
        {
            //string w = ("Hello world".Print() + "!!!".Print()).Print();
            int[] arr = new int[3].Select(x=>new Random().Next(100)).ToArray().Print();
            //int[] arr1 = new int[15];
            int[] arr1 = arr.OrderBy(x=>x).ToArray();
            int[] arr2 = arr.OrderByDescending(x=>x).ToArray();
            if (arr.SequenceEqual(arr1))
            {
                "OrderBy".Print();
            }
            else if (arr.SequenceEqual(arr2))
            {
                "OrderByDescending".Print();
            }
            else
            {
                "Random".Print();
            }
        }
    }
}
