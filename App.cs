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
        Console.ForegroundColor == ConsoleColor.Cyan;
    	Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");
        Console.ResetColor();
	}
}
public class logicStatements

{
    public static void greetingLogic()
    {
    Console.WriteLine("Welcome to the Console Chat App!");
    Console.WriteLine("");
        Console.ForegroundColor == ConsoleColor.Cyan;
    	Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");
        Console.ResetColor();
    Console.WriteLine("What is your name?");
    string userName = Console.ReadLine();
    Console.WriteLine("");
    Console.WriteLine($"Hello, {userName}!");
    Console.WriteLine("");
    Console.WriteLine($"How is your day?");
    Console.WriteLine("Answer with");
    Console.ForegroundColor == ConsoleColor.Green;
    Console.Write("Good");
    Console.ResetColor();
    Console.Write("  -  ");
    Console.ForegroundColor == ConsoleColor.Yellow;
    Console.Write("Mid");
    Console.ResetColor();
    Console.Write("  -  ");
    Console.ForegroundColor == ConsoleColor.Red;
    Console.Write("Bad");
    Console.ResetColor();
    string userDay = Console.ReadLine();
    if (userDay == "Good")
    {
        Console.WriteLine("Thats good!");
    } 
    else if (userDay == "good")
    {
        Console.WriteLine("Thats good!");
    }
    else if (userDay == "Bad")
    {
        Console.WriteLine("Thats not good :(");
    }
    else if (userDay == "bad")
    {
        System.Console.WriteLine("Thats not good :(");
    }
    else if (userDay == "Mid")
    {
        Console.WriteLine("Aw :(");
    }
    else if (userDay == "mid")
    {
        Console.WriteLine("Aw :(");
    }
    else
    {
        Console.WriteLine("Please Re-Run the Application and provide a valid response!");
    }
    Console.WriteLine("");
    Console.ForegroundColor == ConsoleColor.Cyan
    Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");
    Console.ResetColor();
    }
}