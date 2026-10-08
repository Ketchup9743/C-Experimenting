using System;

public class App
{
    static void Main()
    {
		startStatements.Print();
        logicStatements.greetingLogic();
    }
}
public class startStatements
{
    public string startList = "startList";
	
	public static void Print()
	{
    	Console.WriteLine("");
        Console.ForegroundColor = ConsoleColor.Cyan;
    	Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");
        Console.ResetColor();
	}
}
public class logicStatements

{
    public static void greetingLogic()
    {
    Console.ForegroundColor = ConsoleColor.Gray;
    Console.WriteLine("Welcome to the Console Chat App!");
    Console.WriteLine("");
        Console.ForegroundColor = ConsoleColor.Cyan;
    	Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");
        Console.ResetColor();
    Console.WriteLine("What is your name?");
    string userName = Console.ReadLine();
    Console.WriteLine("");
    Console.WriteLine($"Hello, {userName}!");
    Console.WriteLine("");
    Console.WriteLine($"How is your day?");
    Console.WriteLine("Answer with");
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write("Good");
    Console.ResetColor();
    Console.Write("  -  ");
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.Write("Mid");
    Console.ResetColor();
    Console.Write("  -  ");
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Bad");
    Console.ResetColor();
    string userDay = Console.ReadLine();
    if (userDay == "Good")
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Thats good!");
        Console.ResetColor();
    } 
    else if (userDay == "good")
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Thats good!");
        Console.ResetColor();
    }
    else if (userDay == "Bad")
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Thats not good :(");
        Console.ResetColor();
    }
    else if (userDay == "bad")
    {
        Console.ForegroundColor = ConsoleColor.Red;
        System.Console.WriteLine("Thats not good :(");
        Console.ResetColor();
    }
    else if (userDay == "Mid")
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Aw :(");
        Console.ResetColor();
    }
    else if (userDay == "mid")
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Aw :(");
        Console.ResetColor();
    }
    else
    {
        Console.WriteLine("Please Re-Run the Application and provide a valid response!");
    }
    Console.WriteLine("");
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");
    Console.ResetColor();
    }
}