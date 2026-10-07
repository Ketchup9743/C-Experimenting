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
    	Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");
	}
}
public class logicStatements

{
    public static void greetingLogic()
    {
    Console.WriteLine("Welcome to the Console Chat App!");
    Console.WriteLine("What is your name?");
    string userName = Console.ReadLine();
    Console.WriteLine($"Hello, {userName}!");
    System.Console.WriteLine($"How is your day?");
    System.Console.WriteLine("Answer with - Good   Bad   Mid");
    string userDay = Console.ReadLine();
    if (userDay == "Good")
    {
        System.Console.WriteLine("Thats good!");
    } 
    else if (userDay == "Bad")
    {
        System.Console.WriteLine("Thats not good :()");
    }
    else if (userDay == "Mid")
    {
        System.Console.WriteLine("Aw :(");
    }
    else
    {
        System.Console.WriteLine("Please Re-Run the Application and provide a valid response!");
    }
    }
}