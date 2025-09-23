Console.BackgroundColor = ConsoleColor.Green;
Console.ForegroundColor = ConsoleColor.Black;
Console.Clear();
Console.WriteLine("Welcome to roulette RNG");
Thread.Sleep(2000);
Console.Clear();
Console.WriteLine("Your goal is to reach 10k and finish the game!");
Thread.Sleep(3000);
Console.Clear(); 
Console.BackgroundColor = ConsoleColor.DarkRed;
Console.ForegroundColor = ConsoleColor.White;
Console.Clear();


bool isPlaying = true;
bool Colour = false;

bool Number = false;

int Balance = 1000;
 bool shop = false;


int vip = 150;



while (isPlaying)
{
    Random rand = new Random();
    Console.WriteLine("Welcome to the roulette table!");
    Console.WriteLine("Press 1 to bet on colours");
    Console.WriteLine("Press 2 to bet between 1-36");
    Console.WriteLine("Press 3 to open the shop");
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
    else if (input == '3')
    {
        shop = true;
        Console.Clear();
    }
    else
    {
        Console.Clear();
        Console.WriteLine("Not an option");
    }


    while (Colour)
    {
      
        Console.WriteLine("Balance:" + Balance + "$");
        Console.WriteLine("Enter = Bet again");
        Console.WriteLine("Type Menu = Return to menu");
        Console.WriteLine("Enter bet amount and press enter");

        Console.WriteLine("Type Red, Black or Green and press enter");

       

        int BetAmount = Convert.ToInt32(Console.ReadLine());
        int roulette = rand.Next(1, 3);
        int green = rand.Next(0, 37);

        string guess = Console.ReadLine();

        if (BetAmount > Balance)
        {
            Console.Clear();
            Console.WriteLine("Cheater lets try again (you bet more then on your balance)");
            break;
        }
        if (guess == "Red")
        {

            if (roulette == 1)
            {
                Console.WriteLine(" you won!");
                
                Balance = Balance + BetAmount;
                
                if(vip == 1)
                {
                    Balance = Balance + BetAmount;
                }
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
                Balance = Balance + BetAmount;
                
                if (vip == 1)
                {
                    Balance = Balance + BetAmount;
                }
                Console.WriteLine(Balance + "$");
            }
            else
            {
                Console.WriteLine("you lost");
                Balance = Balance - BetAmount;
                Console.WriteLine(Balance + "$");
            }


        }
        else if (guess == "Green")
        {

            if (green == 4)
            {
                Console.WriteLine("you won!");
                Balance = Balance + BetAmount*35;
                Console.WriteLine(Balance + "$");
            }
            else
            {
                Console.WriteLine("you lost");
                Balance = Balance - BetAmount;
                Console.WriteLine(Balance + "$");
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
       


        if (BetAmount > Balance)
        {
            Console.Clear();
            Console.WriteLine("Cheater lets try again (you bet more then on your balance)");
            break;
        }

        int roulette = rand.Next(0, 37);
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
            if (vip == 1)
            {
                Balance = Balance + BetAmount * 35;
            }
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
    while (shop)
    {

        
        Console.WriteLine("Welcome to the shop here you can buy upgrades");
        Console.WriteLine("Type out what you want to buy and hit enter!");
        Console.WriteLine("(1) VIP (2x money): 150$");
        Console.WriteLine("(2) Ultra gamble (50% to x2 balance 50% to set balance to 0): free");
        Console.WriteLine("balance:" + Balance + "$");
        string ShopInput = Console.ReadLine();
        


        if (ShopInput == "Menu")
        {
            Number = false;
            Colour = false;
            shop = false;
            Console.Clear();

        }

        

        else if (ShopInput == "1") 
        {

            if (Balance > vip)
            {
                
                Console.WriteLine("You purchased VIP!");
                Thread.Sleep(1000);
                Console.Clear();
                Balance = Balance - vip;
                vip = 1;

            }
            else if (Balance < vip) 
            {   Console.WriteLine("You cant afford that");
                Thread.Sleep(1000);
                Console.Clear();
                
            }
            
            


        }
        else if (ShopInput == "2")
        {
            
           
            int gambler = rand.Next(1, 3);
            if (gambler == 1)
            {
                Console.WriteLine("Lucky there");
                Balance = Balance * 2;
                Thread.Sleep(1000);
                Console.Clear();

            }
            else if (gambler == 2)
            {
                Console.WriteLine("Game over goodluck next time!");
                Balance = 0;
                Thread.Sleep (1000);
                Console.Clear();
               
                
            }
        }
        else if (ShopInput != "1" && ShopInput != "Menu" && ShopInput != "2")
        {
            Console.WriteLine("Try a correct input this time");
            Thread.Sleep(1000);
            Console.Clear();
        }

    }


}



