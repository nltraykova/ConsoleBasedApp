using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace Tests_SummatorOfIntegers
{
    public class Tests_SummatorOfIntegers
    {
        [Test]
        public void Test_Sum()
        {
            //Arrange
            string input = "5 8 20";

            StringWriter writer = new StringWriter();
            Console.SetOut(writer); //Redirect Console.Out

            StringReader reader = new StringReader(input);
            Console.SetIn(reader); //Redirect Console.In

            //Act
            Program.Main();

            // Assert

            string actual = writer.ToString();
            string expected = $"The sum is: {Environment.NewLine}33{Environment.NewLine}";  

            Assert.That(actual, Is.EqualTo(expected));

        }
    }
}