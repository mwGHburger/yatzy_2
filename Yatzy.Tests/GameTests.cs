using System.Collections.Generic;
using Xunit;

namespace Yatzy.Tests
{
    public class GameTests
    {
        // TODO: Automate inputs
        // [Fact]
        public void ShouldRunGame()
        {
            var diceHand = new List<Dice> {
                new Dice(),
                new Dice(),
                new Dice(),
                new Dice(),
                new Dice()
            };
            var player = new Player(diceHand);
            var game = new Game(new Category(), player, new Score(), new UI());
            game.Run();

            // TODO: Need to test for state change
            Assert.True(game.Category.Categories.Count == 0); 
        }
    }
}