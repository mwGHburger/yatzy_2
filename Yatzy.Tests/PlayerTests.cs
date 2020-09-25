using System.Collections.Generic;
using Xunit;

namespace Yatzy.Tests
{
    public class PlayerTests
    {
        List<Dice> diceHand = new List<Dice>()
            {
                new Dice(),
                new Dice(),
                new Dice(),
                new Dice(),
                new Dice()
            };
        [Fact]
        public void ShouldRollDice()
        {
            var player = new Player(diceHand);

            player.RollDiceHand();

            var diceValueTotal = 0;
            foreach(Dice die in player.DiceHand)
            {
                diceValueTotal += die.Value;
            }

            Assert.InRange(diceValueTotal, 6, 30);
        }

        [Fact]
        public void ShouldSelectCategory()
        {
            var player = new Player(diceHand);
            player.SelectCategory("yatzy");
            Assert.Equal("yatzy", player.SelectedCategory);
        }

        [Fact]
        public void ShouldBeAbleToDecideWhetherToHoldDice()
        {
            var player = new Player(diceHand);
            player.RollDiceHand();
            player.ChooseDiceToHold();
            Assert.Equal(true, diceHand[0].IsHeld);
        }
        
    }
}