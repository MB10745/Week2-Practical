//Warm-Up Method
/*double area = CalculateArea(5, 4);
Console.WriteLine(area);

static double CalculateArea(double length, double width)
{
    double area = length * width;
    return area;
}*/

/*
 * Practical 2
 * Info: Methods Demo
 * Version 1
 * Author: Mahnoor Baig
 * Date: 30th September 2025
 */
//Task 1 - PrintMenu Method
/*Main();
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
}*/

//Task 5 - Count Words
/*Main();

static void Main()
{
    Console.WriteLine("Enter a string:");
    string str = Console.ReadLine();

    Console.WriteLine($"The sentence you inputted is: {str}");

    int CountWords = (str.Split(" ")).Length;
    Console.WriteLine($"Number of Words = {CountWords}");
}*/

//Task 6 - Cipher
static string Encrypt()
{
    Console.WriteLine("Enter a string you wish to encrypt:");
    string input = Console.ReadLine();

    Console.WriteLine("Enter number of rotations");
    int UserRotations = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine($"The sentence you inputted is: {input}");

    string EncryptText = "";
    for (int i = 0; i < input.Length; i++)
    {
        char EncryptChar = (char)((int)input[i] + UserRotations);
        EncryptText += EncryptChar;
    }
    return EncryptText;
}

//Task 7 - Decipher
static string Decrypt()
{
    Console.WriteLine("Enter a string you wish to decrypt:");
    string input = Console.ReadLine();

    Console.WriteLine("Enter number of rotations");
    int UserRotations = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine($"The sentence you inputted is: {input}");

    string DecryptText = "";
    for (int i = 0; i < input.Length; i++)
    {
        char DecryptChar = (char)((int)input[i] - UserRotations);
        DecryptText += DecryptChar;
    }
    return DecryptText;
}

//Task 8 & 9
Main();

static void Main()
{
    Console.WriteLine("Main Menu");
    Console.WriteLine("Select an option:");
    Console.WriteLine("1 - encrypt text");
    Console.WriteLine("2 - decrypt text");
    Console.WriteLine("0 - End");

    string UserChoice = Console.ReadLine();

    if (UserChoice == "1")
    {
        string CipherText = Encrypt();
        Console.WriteLine($"The encrypted sentence is now : {CipherText}");
    }
    else if (UserChoice == "2")
    {
        string DecipherText = Decrypt();
        Console.WriteLine($"The decrypted sentence is now : {DecipherText}");
    }
    else
    {
        Environment.Exit(0);
    }
}