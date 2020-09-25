using System;
using System.Collections.Generic;

namespace Yatzy
{
    public class Player
    {
        public Player(List<Dice> diceHand)
        {
            DiceHand = diceHand;
        }

        public List<Dice> DiceHand { get; set; }
        public string SelectedCategory { get; set;}
        public string rollCount { get; set;}

        public void RollDiceHand()
        {
            foreach(Dice dice in DiceHand)
            {
                dice.Roll();
            }
        }

        public void SelectCategory(string category)
        {
            SelectedCategory = category;
        }

        public void ChooseDiceToHold()
        {
            foreach(Dice dice in DiceHand)
            {
                if(dice.IsHeld) break;
                System.Console.WriteLine($"Want to hold {dice.Value}?");
                var input = Console.ReadLine();
                if(input == "yes")
                {
                    dice.IsHeld = true;
                }
            }
        }
    }
}