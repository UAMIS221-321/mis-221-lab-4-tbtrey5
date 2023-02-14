Console.Clear();
int userChoice = GetUserChoice();

//double curency = GetCurrency();


//pre-test loop
while(userChoice != 3)
{
    Route(userChoice);
    userChoice = GetUserChoice();
}


//post-test loop
//do
//{
  //  Route(userChoice);
    //userChoice = GetUserChoice();
//} while(userChoice != 3);




static int GetUserChoice()
{
    DisplayMenu();
    string choice = Console.ReadLine();
    if(IsValidChoice(choice))
    {
        return int.Parse(choice);
    }
    return 0;
}

static void DisplayMenu()
{
    Console.Clear();
    System.Console.WriteLine("Enter 1: To Display Full Triangle\nEnter 2: Display Partial Triangle\nEnter 3: To Exit");
}

static bool IsValidChoice(string userChoice)
{
    if(userChoice == "1" || userChoice == "2" || userChoice == "3")
    {
        return true;
    }
    return false;
}

static int GetFull()
{
    for (int i = 0; i == 4; i++)
    {
        System.Console.WriteLine("o");
    }
    return 0;
}



static void DisplayTriangle()
{
    for (int i = 1; i <= 9; i++)
    {
        for (int j = 0; j < i; j++)
        {
            System.Console.Write(".");
        }
        System.Console.WriteLine();
    }
}




static void DisplayPartialTriangle()
{
    Random rand = new Random();
    int num = rand.Next(1, 9);
    for (int i = 1; i <= num; i++)
    {
        for (int j = 0; j < i; j++)
        {
            System.Console.Write(".");
        }
        System.Console.WriteLine();
    }
}

static void Exit()
{
    System.Console.WriteLine("Goodbye!");
}

static void Route(int menuChoice)
{
    if(menuChoice == 1) 
    {
        DisplayTriangle();
        Pause();
    }
    else if(menuChoice == 2)
    {
        DisplayPartialTriangle();
        Pause();
    }
    else if (menuChoice == 3)
    {
        Exit();
        Pause();
    }
    else 
    {
        System.Console.WriteLine("Invalid choice");
        Pause();
    }
}

static void Pause()
{
    System.Console.WriteLine("Press any key to continue...");
    Console.ReadKey();
}

