using Refactoring_01_FirstExample_Console;

namespace Refactoring_01_FirstExample_Test
{
    public class UnitTests
    {
        private const string _statementTestValue = "Statement for TestCustomer\nTestPlay: $303.00 ($1 seat)\nAmount owed is $303.00\nYou earned 0 credits\n";


        [Fact]
        public void StatementTest()
        {
            var invoice = new Invoice()
            {
                customer = "TestCustomer",
                performances =
                [
                    new Performance()
                    {
                        audience = 1,
                        playID = "TestPlay"
                    }
                ]
            };

            var plays = new Play[]
            {
                  new()
                    {
                        name = "TestPlay",
                        type = "comedy"
                    }
            };

            var testStatement = Example.Statement(invoice, plays);

            Assert.Equal(_statementTestValue, testStatement);
        }
    }
}