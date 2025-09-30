//Warm-Up Method
/*double area = CalculateArea(5, 4);
Console.WriteLine(area);

static double CalculateArea(double length, double width)
{
    double area = length * width;
    return area;
}*/

//Task 1 - PrintMenu Method
Main();
static void PrintMenu()
{
    Console.WriteLine("Please enter a valid option from below:");
    Console.WriteLine("1. Hello in French?");
    Console.WriteLine("2. Hello in Spanish?");
    Console.WriteLine("3. Hello in German?");
    Console.WriteLine("4. Hello in Italian?");
    Console.WriteLine("0. Exit Application");
}

//Task 4 - Put All Methods Together
static void Main()
{
    string UserOption;
    do
    {
        PrintMenu();
        UserOption = InputOption();
        Console.WriteLine(GetMessage(UserOption));

    } while (UserOption != "0");
}

//Task 2 - GetOption() Method
static string InputOption()
{
    while (true)
    {
        try
        {
            string choice = Console.ReadLine();
            return choice;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error:{ex.Message}. Please enter a valid operation.");
        }
    }
}

//Task 3 - GetMessage() Method
static string GetMessage(string UserChoice)
{
    switch (UserChoice)
    {
        case "1":
            return "Bonjour";
        case "2":
            return "Ola";
        case "3":
            return "Hallo";
        case "4":
            return "Ciao";
        case "0":
            return "Goodbye";
        default:
            return "Please enter a valid option";
    }
}