
//jag letade efter vissa koder vi inte har lärt oss än på internet och anände chatgbt för väldigt små errors
//jag inte fattade när jag jobbade hemma eftersom jag inte kunda hitta så bra lössningar på internet men jag lyckades lössa dom flesta utan hjälp

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

int Balance = 200;
 bool shop = false;


int vip = 150;
bool finish = false;





while (isPlaying)
{
    Random rand = new Random();
    Console.WriteLine("Welcome to the roulette table!");
    Console.WriteLine("Press 1 to bet on colours");
    Console.WriteLine("Press 2 to bet between 1-36");
    Console.WriteLine("Press 3 to open the shop");
    Console.WriteLine("Press 4 to complete the game(requires 10K$)");
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
    else if (input == '4')
    {
        if(Balance >= 10000)
        {
            finish= true;
            isPlaying = false;
            Console.Clear();
        }
        else if (Balance <= 10000)
        {
            Console.WriteLine("You arent worthy yet");
            Thread.Sleep(500);
            Console.Clear();
        }
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
        Console.WriteLine("Type Menu after your bet is done = Return to menu");

     
        int BetAmount;
        while (true)
        {
            Console.WriteLine("Enter bet amount and press enter:");
            string betInput = Console.ReadLine();

            try
            {
                BetAmount = Convert.ToInt32(betInput);

                if (BetAmount > Balance)
                {
                    Console.WriteLine("Cheater! You can't bet more than your balance.");
                   
                    continue; 
                }

                break; 
            }
            catch
            {
                Console.WriteLine("Invalid input! Please enter a number.");
            }
        }

        
        string guess;
        while (true)
        {
            Console.WriteLine("Type Red, Black or Green and press enter:");
            guess = Console.ReadLine();

            if (guess == "Red" || guess == "Black" || guess == "Green")
            {
                break; 
            }
            else
            {
                Console.WriteLine("Invalid colour! Try again.");
            }
        }

        int roulette = rand.Next(1, 3);
        int green = rand.Next(0, 37);

       
        if (guess == "Red")
        {
            if (roulette == 1)
            {
                Console.WriteLine("You won!");
                Balance += BetAmount;
                if (vip == 1) Balance += BetAmount;
                Console.WriteLine(Balance + "$");
            }
            else
            {
                Console.WriteLine("You lost");
                Balance -= BetAmount;
                Console.WriteLine(Balance + "$");
            }
        }
        else if (guess == "Black")
        {
            if (roulette == 2)
            {
                Console.WriteLine("You won!");
                Balance += BetAmount;
                if (vip == 1) Balance += BetAmount;
                Console.WriteLine(Balance + "$");
            }
            else
            {
                Console.WriteLine("You lost");
                Balance -= BetAmount;
                Console.WriteLine(Balance + "$");
            }
        }
        else if (guess == "Green")
        {
            if (green == 4)
            {
                Console.WriteLine("You won!");
                Balance += BetAmount * 35;
                Console.WriteLine(Balance + "$");
            }
            else
            {
                Console.WriteLine("You lost");
                Balance -= BetAmount;
                Console.WriteLine(Balance + "$");
            }
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
        Console.WriteLine("after bet type Menu = Return to menu");
        Console.WriteLine("Enter bet amount and press enter:");
        int BetAmount;
        
        try
        {
            BetAmount = Convert.ToInt32(Console.ReadLine());
        }
        catch
        {
            Console.WriteLine("use a number, press enter try again");
            Console.ReadLine();
            Console.Clear();
            continue;
        }
       


        if (BetAmount > Balance)
        {
            
            Console.WriteLine("Cheater lets try again (you bet more then on your balance)");
            Thread.Sleep(1000);
            Console.Clear();
            break;
        }

        int roulette = rand.Next(0, 37);
        Console.WriteLine("Guess between 1-36 and press enter:");
        int guessNumb;

        try
        {
            guessNumb = Convert.ToInt32(Console.ReadLine());
        }
        catch
        {
            Console.WriteLine("use a number, press enter try again");
            Console.ReadLine();
            Console.Clear();
            continue;
        }


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
                Console.WriteLine("Your balance was set to 0");
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
while (finish)
{
    Console.Clear ();
    Console.BackgroundColor = ConsoleColor.Black;
    Console.ForegroundColor = ConsoleColor.White;
    Console.Clear();


    string text = "Congrats!";
    foreach (char c in text)
    {
        Console.Write(c);           
        Thread.Sleep(100);          
    }
    Console.WriteLine();
    Thread.Sleep(1000);

    string text2 = "You actually managed to gather 10k$, that takes some detication i respect that!";
    foreach (char c in text2)
    {
        Console.Write(c);
        Thread.Sleep(50);
    }
    Console.WriteLine();
    Thread.Sleep(1000);
    string text3 = "...The end...";
    foreach (char c in text3)
    {
        Console.Write(c);
        Thread.Sleep(300);
    }
    Console.WriteLine();
    Thread.Sleep(2000);
    break;
}



