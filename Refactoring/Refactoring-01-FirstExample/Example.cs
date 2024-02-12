using System.Globalization;

namespace Refactoring_01_FirstExample_Console
{
    public class Example
    {
        public static string Statement(Invoice invoice, Play[] plays)
        {
            var totalAmount = 0;
            var volumeCredits = 0;

            var result = $"Statement for {invoice.customer}\n";
            NumberFormatInfo? format = new()
            {
                CurrencySymbol = "$",
                CurrencyDecimalDigits = 2
            };

            foreach (var perf in invoice.performances)
            {
                var play = plays.First(p => p.name == perf.playID);
                var thisAmount = 0;

                switch (play.type)
                {
                    case "tragedy":
                        thisAmount = 40000;
                        if (perf.audience > 30)
                        {
                            thisAmount += 1000 * (perf.audience - 30);
                        }
                        break;
                    case "comedy":
                        thisAmount = 30000;
                        if (perf.audience > 20)
                        {
                            thisAmount += 10000 + 500 * (perf.audience - 20);
                        }
                        thisAmount += 300 * perf.audience;
                        break;
                    default:
                        throw new Exception($"unknown type: {play.type}");
                }

                // add volume credits
                volumeCredits += Math.Max(perf.audience - 30, 0);
                // add extra credit for every ten comedy attendees
                if ("comedy" == play.type) volumeCredits += perf.audience / 5;
                // print line for this order
                result += $"{play.name}: {(thisAmount / 100).ToString("C", format)} (${perf.audience} seat)\n";
                totalAmount += thisAmount;
            }

            result += $"Amount owed is {(totalAmount / 100).ToString("C", format)}\n";
            result += $"You earned {volumeCredits} credits\n";
            return result;
        }
    }
}
