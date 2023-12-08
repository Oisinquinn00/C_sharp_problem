using Microsoft.VisualStudio.TestPlatform.TestHost;
using validSentenceProgram;
namespace TestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestValidSentence()
        {
            // Arrange
            string input = "The quick brown fox said hello Mr lazy dog.";

            // Act
            bool result = validSentence.is_sentence_valid(input);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestEmptySentence()
        {
            // Arrange
            string input = "";

            // Act
            bool result = validSentence.is_sentence_valid(input);

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void TestSentenceStartsWithLowercase()
        {
            // Arrange
            string input = "the quick brown fox said \"hello Mr lazy dog.";

            // Act
            bool result = validSentence.is_sentence_valid(input);

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void TestSentenceEndsWithPeriod()
        {
            // Arrange
            string input = "One lazy dog is too few, thirteen is too many.";

            // Act
            bool result = validSentence.is_sentence_valid(input);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestSentenceWithOddQuotationCount()
        {
            // Arrange
            string input = "The quick brown fox said \"hello Mr lazy dog"; 

            // Act
            bool result = validSentence.is_sentence_valid(input);

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void TestSentenceWithNumber()
        {
            // Arrange
            string input = "Are there 11, 12 , or 13 lazy dogs?";

            // Act
            bool result = validSentence.is_sentence_valid(input);

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void TestSentenceWithNoPeriods()
        {
            // Arrange
            string input = "There is no punctation in this sentence";

            // Act
            bool result = validSentence.is_sentence_valid(input);

            // Assert
            Assert.IsFalse(result);
        }
    }
}