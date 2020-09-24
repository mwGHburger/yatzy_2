using System.Collections.Generic;

namespace Yatzy
{
    public class Category
    {
        private List<string> CategoryList = new List<string> {
            "yatzy",
            "full house",
            "large straight",
            "small straight",
            "four of a kind",
            "three of a kind",
            "two pairs",
            "pair",
            "sixes",
            "fives",
            "fours",
            "threes",
            "twos",
            "ones",
            "chance"
        };

        // TODO: can we just assign Categories here, and not in the Constructor?
        public Dictionary<string,bool> Categories {get; set;}
        
        public Category()
        {
            Categories = new Dictionary<string,bool>();
        }
        public void RemoveCategory(string category)
        {
            Categories.Remove(category);
        }
        
        public void CreateCategories()
        {
            foreach(string category in CategoryList)
            {
                Categories.Add(category, true);
            }
        }
    }
}