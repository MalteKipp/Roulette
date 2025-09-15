//fråga ochg spara svaren
Console.WriteLine("Enter a number between 0-36 or guess red/green");
Console.ReadLine();
string colourguess;



//slut på frågandet


//funktionen


while(true)
    {
    Random rand = new Random();
    int roulette = rand.Next(0, 36);
    int guess = Convert.ToInt32(Console.ReadLine());

int colour = rand.Next(1, 2);

        if(guess < 0)
    {
      Console.WriteLine("That number is not on the spectrum guess again");
    }
        else if (guess > 36)
        {
            Console.WriteLine("That number is not on the spectrum guess again");
        }


        else if (guess == roulette)
    {
        Console.WriteLine("You won Congratulations");
    }
    else
    {
        Console.WriteLine("You lost the number was " + roulette);
    }
    if (colour == colourguess)
{
    Console.WriteLine("Thats the right colour");
}
else
{
    Console.WriteLine("Thats the wrong colour");
}
}
    