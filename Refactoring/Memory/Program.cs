internal class Program
{
    static char[,] board = new char[4, 4];
    static char[,] hiddenBoard = new char[4, 4];
    static Random random = new Random();

    private static void Main(string[] args)
    {
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                board[i, j] = '-';
            }
        }
        char[] symbols = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H' };
        int index = 0;

        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                hiddenBoard[i, j] = symbols[index++];
            }
        }
        int n = 16;
        while (n > 1)
        {
            n--;
            int k = random.Next(n + 1);
            int i = n / 4;
            int j = n % 4;
            int ii = k / 4;
            int jj = k % 4;
            char temp = hiddenBoard[i, j];
            hiddenBoard[i, j] = hiddenBoard[ii, jj];
            hiddenBoard[ii, jj] = temp;
        }

        bool win = false;
        while (GameWon())
        {
            Console.Clear();
            Console.WriteLine("  0 1 2 3");
            for (int i = 0; i < 4; i++)
            {
                Console.Write(i);
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(" " + board[i, j]);
                }
                Console.WriteLine();
            }
            Console.Write("Enter row (0-3): ");
            int row1 = int.Parse(Console.ReadLine());
            Console.Write("Enter column (0-3): ");
            int col1 = int.Parse(Console.ReadLine());

            Console.Clear();
            Console.WriteLine("  0 1 2 3");
            for (int i = 0; i < 4; i++)
            {
                Console.Write(i);
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(" " + hiddenBoard[i, j]);
                }
                Console.WriteLine();
            }
            Console.Write("Enter row (0-3): ");
            int row2 = int.Parse(Console.ReadLine());
            Console.Write("Enter column (0-3): ");
            int col2 = int.Parse(Console.ReadLine());

            if (hiddenBoard[row1, col1] != hiddenBoard[row2, col2])
            {
                Console.WriteLine("No match! Try again.");
                Console.ReadLine();
            }
            else
            {
                board[row1, col1] = hiddenBoard[row1, col1];
                board[row2, col2] = hiddenBoard[row2, col2];
            }
        }

        Console.WriteLine("Congratulations! You won the game!");
    }

    static bool GameWon()
    {
        foreach (char symbol in board)
        {
            if (symbol == '-')
                return false;
        }
        return true;
    }
}