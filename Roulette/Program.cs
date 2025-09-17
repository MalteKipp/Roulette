








bool Colour = false;

bool Number = false;
bool isPlaying = true;
int Balance = 100;
while (isPlaying)
{ 
    Console.WriteLine("Welcome to the roulette table!");
    Console.WriteLine("Press 1 to bet on colours");
    Console.WriteLine("Press 2 to bet between 1-36");
    Console.WriteLine("Balance:" + Balance + "$");
    
    char input = Console.ReadKey().KeyChar;
    

    if (input == '1')
    {
        Colour = true;
        Console.Clear();
    }
    else if (input == '2')
    {
        Number = true;
        Console.Clear();
    }
    else
    {
        Console.WriteLine("Not an option");
    }


    while (Colour)
    {
      
        Console.WriteLine("Balance:" + Balance + "$");
        Console.WriteLine("Enter = Bet again");
        Console.WriteLine("Type Menu = Return to menu");
        Console.WriteLine("Enter bet amount and press enter");

        Console.WriteLine("Type Red or Black and press enter");

        Random rand = new Random();

        int BetAmount = Convert.ToInt32(Console.ReadLine());
        int roulette = rand.Next(1, 3);

        string guess = Console.ReadLine();


        if (guess == "Red")
        {

            if (roulette == 1)
            {
                Console.WriteLine(" you won!");
                
                Balance = Balance + BetAmount;
                Console.WriteLine(Balance+"$");
            }
            else
            {
                Console.WriteLine("you lost");
                Balance = Balance - BetAmount;
                Console.WriteLine(Balance +"$");
            }

        }

        else if (guess == "Black")
        {

            if (roulette == 2)
            {
                Console.WriteLine("you won!");
            }
            else
            {
                Console.WriteLine("you lost");
            }
        }
        else if (guess != "Red" || guess != "Green")
        {
            Console.WriteLine("Not a colour");

    
        }

        if (Console.ReadLine() == "Menu")
        {
            Number = false;
            Colour = false;

        }
       Console.Clear();
    }





    while (Number)
    {
        Console.WriteLine("Balance:" + Balance + "$");
        Console.WriteLine("Enter = Bet again");
        Console.WriteLine("Type Menu = Return to menu");
        Console.WriteLine("Enter bet amount and press enter");
        Console.WriteLine("Guess between 1-36 and press enter:");
        int BetAmount = Convert.ToInt32(Console.ReadLine());
        string guess = Console.ReadLine();
        Random rand = new Random();


        
        int roulette = rand.Next(0, 36);
        int guessNumb = Convert.ToInt32(guess);

        if (guessNumb < 0)
        {
            Console.WriteLine("Invalid number");
        }
        else if (guessNumb > 36)
        {
            Console.WriteLine("Invalid number");
        }


        else if (guessNumb == roulette)
        {
            Console.WriteLine("You won");
            Console.WriteLine(roulette);

           
            Balance = Balance + BetAmount * 35;
            Console.WriteLine(Balance + "$");
        }

        else if (guessNumb != roulette)
        {
            Console.WriteLine(roulette);
            Console.WriteLine("you lost");
            Balance = Balance - BetAmount;
            Console.WriteLine(Balance + "$");

        }
      
       

            if (Console.ReadLine() == "Menu")
            {
                Number = false;
                Colour = false;

            }
        
        Console.Clear();
    }
    
}