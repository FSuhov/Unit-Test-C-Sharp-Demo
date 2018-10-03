using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProductionCode;

namespace UnitTestTutorial.UnitTests
{
    [TestClass]
    public class GirlDriverTests
    {
        [TestMethod]
        public void CanBeDominated_DominatrixIsQueen_ReturnsTrue()
        {
            // Arrange - nothing to arrange, the method is static

            // Act
            var result = GirlDriver.CanBeDominated(new Gladiatrix { Name = "Tanya Danielle", IsQueen = true, CurrentRating = 9.88F }, new Gladiatrix { Name = "Amber Michaelle", IsQueen = false, CurrentRating = 5.55F });

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CanBeDominated_DominatrixRatingIsBigger_ReturnsTrue()
        {
            // Arrange - nothing to arrange, the method is static

            // Act
            var result = GirlDriver.CanBeDominated(new Gladiatrix { Name = "Goldie Blair", IsQueen = false, CurrentRating = 8.01F }, new Gladiatrix { Name = "Amber Michaelle", IsQueen = false, CurrentRating = 5.55F });

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CanBeDominated_DominatrixRatingIsLower_ReturnsFalse()
        {
            // Arrange - nothing to arrange, the method is static

            // Act
            var result = GirlDriver.CanBeDominated(new Gladiatrix { Name = "Amber Michaelle", IsQueen = false, CurrentRating = 5.55F }, new Gladiatrix { Name = "Goldie Blair", IsQueen = false, CurrentRating = 8.01F });

            // Assert
            Assert.IsFalse(result);
        }
    }
}
