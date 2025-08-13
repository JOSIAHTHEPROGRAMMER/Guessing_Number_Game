Console.WriteLine("Hello, let's play a number guessing game!\n");
Console.WriteLine("I am going to pick a random number from 0–100.\n");

Random rand = new Random();
int r = rand.Next(0, 101);
Thread.Sleep(1000);

Console.WriteLine("\nOk, you can start guessing!\n");

bool guessed = false;
int guesses = 10;

for (int i = 0; i < guesses; i++)
{
    Console.Write("Your guess: ");
    string? inputStr = Console.ReadLine();
    int input;

    if (!int.TryParse(inputStr, out input))
    {
        Console.WriteLine("\nPlease enter a valid number!\n");
        i--; 
        continue;
    }

    if (input == r)
    {
        guessed = true;
        break;
    }
    else if (input > r)
    {
        Console.WriteLine($"\n{input} is higher than my number\n");
    }
    else
    {
        Console.WriteLine($"\n{input} is lower than my number\n");
    }

   
    Console.WriteLine($"\n{guesses-i-1} guess{(guesses-i-1 == 1 ? "" : "es")} left.\nGuess again!\n");
}

if (!guessed)
{
    Console.WriteLine($"\nYou didn't guess the number: {r}\nMaybe next time! :(\n");
}
else
{
    Console.WriteLine($"\nYou guessed the number: {r}\nGood job! :)\n");
}

Console.ReadKey();
