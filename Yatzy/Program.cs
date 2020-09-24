using System;

namespace Yatzy
{
    class Program
    {
        static void Main(string[] args)
        {
            var score = new Score();
            var arr = new int[5] {1,1,2,2,2};
            System.Console.WriteLine(Array.FindAll(arr, x => x == arr[3]).Length);

        }
    }
}
