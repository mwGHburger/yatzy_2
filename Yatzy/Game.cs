using System.Collections.Generic;

namespace Yatzy
{
    public class Game
    {
        public Game(Category category)
        {
            Categories = category.Categories;
        }

        public List<string> Categories {get; set;}
        public void Run()
        {
            
        }
    }
}