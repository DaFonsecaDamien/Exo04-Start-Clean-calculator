using NumberOperations;
using NUnit.Framework;

namespace Test
{
    public class NumberProcessorTests
    {
        [Test]
        public void ProcessFile_Addition_ReturnsExpectedResult()
        {
            // Arrange
            var filename = "testFile.txt";
            var operation = "+";
            var enableLogging = false;
            File.WriteAllText(filename, "1\n2\n3\n");

            var numberProcessor = new NumberProcessor();

            // Act
            var result = numberProcessor.ProcessFile(filename, operation, enableLogging);

            // Assert
            Assert.That(result, Is.EqualTo(6));
        }
        
        [Test]
        public void ProcessFile_Subtraction_ReturnsExpectedResult()
        {
            // Arrange
            var filename = "testFile.txt";
            var operation = "-";
            var enableLogging = false;
            File.WriteAllText(filename, "1\n2\n3\n");

            var numberProcessor = new NumberProcessor();

            // Act
            var result = numberProcessor.ProcessFile(filename, operation, enableLogging);

            // Assert
            Assert.That(result, Is.EqualTo(-4));
        }
        
        [Test]
        public void ProcessFile_Multiplication_ReturnsExpectedResult()
        {
            // Arrange
            var filename = "testFile.txt";
            var operation = "*";
            var enableLogging = false;
            File.WriteAllText(filename, "1\n2\n3\n");

            var numberProcessor = new NumberProcessor();

            // Act
            var result = numberProcessor.ProcessFile(filename, operation, enableLogging);

            // Assert
            Assert.That(result, Is.EqualTo(6));
        }

        [Test]
        public void ProcessFile_AdditionWithLogging_ReturnsExpectedResult()
        {
            // Arrange
            var filename = "testFile.txt";
            var operation = "+";
            var enableLogging = true;
            File.WriteAllText(filename, "1\n2\n3\n");

            var numberProcessor = new NumberProcessor();

            // Act
            var result = numberProcessor.ProcessFile(filename, operation, enableLogging);

            // Assert
            Assert.That(result, Is.EqualTo(6));
        }
        
        [Test]
        public void ProcessFile_SubtractionWithLogging_ReturnsExpectedResult()
        {
            // Arrange
            var filename = "testFile.txt";
            var operation = "-";
            var enableLogging = true;
            File.WriteAllText(filename, "1\n2\n3\n");

            var numberProcessor = new NumberProcessor();

            // Act
            var result = numberProcessor.ProcessFile(filename, operation, enableLogging);

            // Assert
            Assert.That(result, Is.EqualTo(-4));
        }
        
        [Test]
        public void ProcessFile_MultiplicationWithLogging_ReturnsExpectedResult()
        {
            // Arrange
            var filename = "testFile.txt";
            var operation = "*";
            var enableLogging = true;
            File.WriteAllText(filename, "1\n2\n3\n");

            var numberProcessor = new NumberProcessor();

            // Act
            var result = numberProcessor.ProcessFile(filename, operation, enableLogging);

            // Assert
            Assert.That(result, Is.EqualTo(6));
        }
    }
}