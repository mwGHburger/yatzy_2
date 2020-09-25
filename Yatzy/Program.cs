using System.Collections.Generic;
using System;

namespace Yatzy
{
    class Program
    {
        static void Main(string[] args)
        {
            var category = new Category();
            // category.CreateCategories();
            System.Console.WriteLine(category.Categories.Contains("yatzy"));
        }
    }
}
