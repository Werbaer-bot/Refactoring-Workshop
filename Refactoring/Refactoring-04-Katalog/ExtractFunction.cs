namespace Refactoring_04_Katalog
{
    public class ExtractFunction
    {
        void PrintOwing(Invoice data)
        {
            PrintBanner();
            var outstanding = CalculateOutstanding();

            //print details
            Console.WriteLine("Name: " + data.customer);
            Console.WriteLine("Amount: " + outstanding);
        }

        void PrintOwing(Invoice data)
        {
            PrintBanner();
            var outstanding = CalculateOutstanding();
            PrintDetails(outstanding);
        }

        void PrintDetails(int outstanding)
        {
            //print details
            Console.WriteLine("Name: " + data.customer);
            Console.WriteLine("Amount: " + outstanding);
        }
    }
}
