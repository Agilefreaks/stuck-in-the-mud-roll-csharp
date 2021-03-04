using System;
using Xunit;

namespace Core.Tests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(new int[] { 1, 3, 4, 4, 6 }, 5)]
        [InlineData(new int[] { 1, 2, 3, 4, 5 }, 3)]
        [InlineData(new int[] { 2, 2, 5, 5, 5 }, 0)]
        public void DiceAvailableNextRoll_Always_ReturnNumberOfDiceNotStuckInTheMud(int[] input, int expectedResult)
        {
            var result = StuckInTheMudRoll.dice_available_next_roll(input[0], input[1], input[2], input[3], input[4]);

            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [InlineData(new int[] { 1, 1, 1, 1, 1 }, 5)]
        [InlineData(new int[] { 1, 1, 1, 2, 5 }, 3)]
        [InlineData(new int[] { 2, 2, 2, 5, 5 }, 0)]
        public void Score_Always_SumsDiceNotStuckInTheMud(int[] input, int expectedResult)
        {
            var instance = new StuckInTheMudRoll(input[0], input[1], input[2], input[3], input[4]);

            var result = instance.Score();

            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [InlineData(new int[] { 1, 2, 3, 4, 5 }, false)]
        [InlineData(new int[] { 2, 2, 5, 5, 5 }, true)]
        public void EndOfTurn_WhenAllDiceAreStuckInTheMud_ReturnsTrue(int[] input, bool expectedResult)
        {
            var instance = new StuckInTheMudRoll(input[0], input[1], input[2], input[3], input[4]);

            var result = instance.EndOfTurn();

            Assert.Equal(expectedResult, result);
        }
    }
}
