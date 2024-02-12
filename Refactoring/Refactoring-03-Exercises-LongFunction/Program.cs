Console.WriteLine("Enter a number:");
string? input = Console.ReadLine();
int userInput;
if (!int.TryParse(input, out userInput))
{
    Console.WriteLine("Invalid input. Defaulting to 0.");
    userInput = 0;
}

int result = userInput * 2 + 10;

Console.WriteLine("Result: " + result);
