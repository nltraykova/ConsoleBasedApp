using SummatorOfIntegers;
using Microsoft.VisualStudio.TestPlatform.TestHost;


namespace SampleTests_SummatorOfIntegers
{
    public class SampleTests_SummatorOfIntegers
    {
        [Test]
        public void Test_SumOfTwoPositiveNumbers()
        {
            //arrange
            string input = "5 20";

            StringWriter writer = new StringWriter();
            Console.SetOut(writer); //Redirect Comsole.Out

            StringReader reader = new StringReader(input);
            Console.SetIn(reader); //Redirect Comsole.In

            //act
            SummatorOfIntegers.Program.Main();

            //assert

            string actual = writer.ToString();
            string expected = $"The sum is: {Environment.NewLine}25{Environment.NewLine}";
            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}