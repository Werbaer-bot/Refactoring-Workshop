internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Willkommen zu Schere, Stein, Papier!");
        Console.WriteLine("Wähle: 1 für Schere, 2 für Stein, 3 für Papier");

        string[] options = { "Schere", "Stein", "Papier" };

        while (true)
        {
            Console.Write("Deine Wahl: ");
            int userChoice = int.Parse(Console.ReadLine());
            int computerChoice = new Random().Next(1, 4);

            if (userChoice < 1 || userChoice > 3)
            {
                Console.WriteLine("Ungültige Eingabe. Bitte wähle eine Zahl zwischen 1 und 3.");
                continue;
            }

            Console.WriteLine("Du wählst: " + options[userChoice - 1]);
            Console.WriteLine("Der Computer wählt: " + options[computerChoice - 1]);

            if (userChoice == computerChoice)
            {
                Console.WriteLine("Unentschieden!");
            }
            else if ((userChoice == 1 && computerChoice == 2) ||
                     (userChoice == 2 && computerChoice == 3) ||
                     (userChoice == 3 && computerChoice == 1))
            {
                Console.WriteLine("Der Computer gewinnt!");
            }
            else
            {
                Console.WriteLine("Du gewinnst!");
            }

            Console.Write("Möchtest du noch einmal spielen? (ja/nein): ");
            string playAgain = Console.ReadLine();

            if (playAgain.ToLower() != "ja")
            {
                break;
            }
        }

        Console.WriteLine("Auf Wiedersehen!");
    }
}