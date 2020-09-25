using System.Linq;
using System.Collections.Generic;

namespace Yatzy
{
    public class Category
    {

        // TODO: can we just assign Categories here, and not in the Constructor?
        public List<string> Categories {get; set;} = new List<string> {
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
        
        public void RemoveCategory(string category)
        {
            Categories.Remove(category);
        }

        public bool ValidateCategoryInput(string input)
        {
            if(Categories.Contains(input))
            {
                return true;
            }
            return false;
        }
    }
}