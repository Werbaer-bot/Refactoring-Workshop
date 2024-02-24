internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Willkommen beim Zahlenratespiel!");
        Console.WriteLine("Versuche, die Zahl in weniger als 15 Versuchen zu erraten!");
        Console.WriteLine("Die Zahl liegt irgendwo zwischen 1 und 200.");

        var rnd = new Random();
        int lowerBound = 1;
        int upperBound = 200;
        int numberToGuess = rnd.Next(lowerBound, upperBound + 1);
        int attempts = 0;

        while (attempts < 15)
        {
            Console.Write("Rate eine Zahl: ");
            var input = Console.ReadLine();
            int guess;

            if (!int.TryParse(input, out guess))
            {
                Console.WriteLine("Ungültige Eingabe. Bitte geben Sie eine Zahl ein.");
                continue;
            }

            attempts++;

            if (guess < numberToGuess)
            {
                Console.WriteLine("Zu niedrig! Versuchen Sie es mit einer größeren Zahl.");
            }
            else if (guess > numberToGuess)
            {
                Console.WriteLine("Zu hoch! Versuchen Sie es mit einer kleineren Zahl.");
            }
            else
            {
                Console.WriteLine($"Glückwunsch! Sie haben die Zahl {numberToGuess} erraten!");
                Console.WriteLine($"Sie haben {attempts} Versuche gebraucht. Nicht schlecht!");
                return;
            }
        }

        Console.WriteLine("Du hast alle Versuche aufgebraucht. Die gesuchte Zahl war {0}.", numberToGuess);

    }
}