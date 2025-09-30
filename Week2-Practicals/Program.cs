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

static void Main()
{
    PrintMenu();
    string choice = Console.ReadLine();
    switch(choice)
    {
        case "1":
            Console.WriteLine("Bonjour");
            break;
        case "2":
            Console.WriteLine("Hola");
            break;
        case "3":
            Console.WriteLine("Hallo");
            break;
        case "4":
            Console.WriteLine("Salve");
            break;
        case "0":
            break;
        default:
            Console.WriteLine("Invalid choice");
            break;
    }
}