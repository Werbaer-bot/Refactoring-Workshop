namespace Refactoring_01_FirstExample_Console
{
    public class Invoices
    {
        public Invoice[]? invoices { get; set; }
    }

    public class Invoice
    {
        public string customer { get; set; }
        public Performance[] performances { get; set; }
    }

    public class Performance
    {
        public string playID { get; set; }
        public int audience { get; set; }
    }

    public class Plays
    {
        public Play[] plays; 
    }

    public class Play
    {
        public string name { get; set; }
        public string type { get; set; }
    }
}
