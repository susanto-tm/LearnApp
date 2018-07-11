using NUnit.Framework;
using System;
using System.Collections.Generic;


namespace LearnApp.UnitTests
{
    [TestFixture]
    public class GamesTests
    {
        [Test]
        public void GameTests_TestForCorrectInitialization_ShouldBeOk()
        {
            //Arrange
            var question = new QuizQuestion()
            {
                Question = "Xamarin.Forms is awesome",
                Answer = true,
                Explanation = "See for yourself"
            };

            //Act
            var game = new Game(new List<QuizQuestion>(new[] { question }));

            //Assert
            Assert.AreEqual(1, game.Questions.Count);
        }
    }
}
