internal class Program
{
    static int width = 20;
    static int height = 10;
    static int score = 0;
    static bool gameOver = false;
    static int snakeHeadX = 0;
    static int snakeHeadY = 0;
    static List<int[]> snakeBody = new List<int[]>();
    static Random random = new Random();
    static int fruitX;
    static int fruitY;

    private static void Main(string[] args)
    {
        snakeHeadX = width / 2;
        snakeHeadY = height / 2;
        snakeBody.Add(new int[] { snakeHeadX, snakeHeadY });
        fruitX = random.Next(width);
        fruitY = random.Next(height);

        while (!gameOver)
        {
            Console.Clear();
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    if (x == snakeHeadX && y == snakeHeadY)
                    {
                        Console.Write("O");
                    }
                    else if (x == fruitX && y == fruitY)
                    {
                        Console.Write("X");
                    }
                    else
                    {
                        bool isSnakeBody = false;

                        foreach (int[] segment in snakeBody)
                        {
                            if (segment[0] == x && segment[1] == y)
                            {
                                isSnakeBody = true;
                                break;
                            }
                        }

                        if (isSnakeBody)
                        {
                            Console.Write("o");
                        }
                        else
                        {
                            Console.Write(".");
                        }
                    }
                }
                Console.WriteLine();
            }
            ConsoleKeyInfo keyInfo = Console.ReadKey();

            switch (keyInfo.Key)
            {
                case ConsoleKey.UpArrow:
                    snakeHeadX += 0;
                    snakeHeadY += -1;
                    snakeBody.Insert(0, new int[] { snakeHeadX, snakeHeadY });
                    if (snakeHeadX != fruitX || snakeHeadY != fruitY)
                    {
                        snakeBody.RemoveAt(snakeBody.Count - 1);
                    }
                    break;
                case ConsoleKey.DownArrow:
                    snakeHeadX += 0;
                    snakeHeadY += 1;
                    snakeBody.Insert(0, new int[] { snakeHeadX, snakeHeadY });
                    if (snakeHeadX != fruitX || snakeHeadY != fruitY)
                    {
                        snakeBody.RemoveAt(snakeBody.Count - 1);
                    }
                    break;
                case ConsoleKey.LeftArrow:
                    snakeHeadX += -1;
                    snakeHeadY += 0;
                    snakeBody.Insert(0, new int[] { snakeHeadX, snakeHeadY });
                    if (snakeHeadX != fruitX || snakeHeadY != fruitY)
                    {
                        snakeBody.RemoveAt(snakeBody.Count - 1);
                    }
                    break;
                case ConsoleKey.RightArrow:
                    snakeHeadX += 1;
                    snakeHeadY += 0;
                    snakeBody.Insert(0, new int[] { snakeHeadX, snakeHeadY });
                    if (snakeHeadX != fruitX || snakeHeadY != fruitY)
                    {
                        snakeBody.RemoveAt(snakeBody.Count - 1);
                    }
                    break;
            }

            if (snakeHeadX == fruitX && snakeHeadY == fruitY)
            {
                score++;
                fruitX = random.Next(width);
                fruitY = random.Next(height);
            }

            if (snakeHeadX < 0 || snakeHeadY < 0 || snakeHeadX >= width || snakeHeadY >= height)
            {
                gameOver = true;
            }

            foreach (int[] segment in snakeBody.Skip(1))
            {
                if (segment[0] == snakeHeadX && segment[1] == snakeHeadY)
                {
                    gameOver = true;
                }
            }

            Thread.Sleep(100);
        }

        Console.WriteLine("Game Over! Score: " + score);
    }
}