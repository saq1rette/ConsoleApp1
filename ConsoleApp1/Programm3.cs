using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    static class Programm3
    {
        public static void main()
        {
            int[] arr = new int[10]
            .Select(x=> new Random().Next(100))
            .ToArray().Print();


            //arr.Concat(new int[] { 0, 0, 0 }).ToArray().Print();


            //arr[0..3].Concat(new int[] { 0 })
            //.ToArray().Concat(arr[3..^0])
            //.ToArray().Print();

            arr[0..5].Concat(new int[] {1,2,3}).ToArray().Concat(arr[5..^0]).ToArray().Print();
        }
    }
}
