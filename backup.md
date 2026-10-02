if (portID[0] == 8800)
{
    System.Random classID = new System.Random();   // Random Port ID Generator
    int numID = classID.Next(1, 5000);
    storageAmount += 64; // Storage now is equal to 64
    memoryAmount += 16; // Memory now is equal to 16
        System.Console.WriteLine($"\t[{databaseName[0]} is running on PORT: {portID[0]}]");
        System.Console.WriteLine($"\t\t\t[STORAGE : {storageAmount}GB]");
        System.Console.WriteLine($"\t\t\t[RAM : {memoryAmount}GB]");
        System.Console.WriteLine($"\t\t\t[PORT ID : {numID}]");
        System.Console.WriteLine($"\t\t\t[DATABASE TYPE : {databaseType[0]}]");
}
    System.Console.WriteLine("");
    System.Console.WriteLine("===========================================");
if (portID[1] == 5000)
{
    System.Random classID = new System.Random();   // Random Port ID Generator
    int numID = classID.Next(1, 5000);
    storageAmount -= 48; // Storage now is equal to 16
    memoryAmount += 8;  // Memory now is equal to 24
        System.Console.WriteLine($"\t[{databaseName[1]} is running on PORT: {portID[1]}]");
        System.Console.WriteLine($"\t\t\t[STORAGE : {storageAmount}GB]");
        System.Console.WriteLine($"\t\t\t[RAM : {memoryAmount}GB]");
        System.Console.WriteLine($"\t\t\t[PORT ID : {numID}]");
        System.Console.WriteLine($"\t\t\t[DATABASE TYPE : {databaseType[1]}]");
}
    System.Console.WriteLine("");
    System.Console.WriteLine("===========================================");
if (portID[2] == 6500)
{
    System.Random classID = new System.Random();   // Random Port ID Generator
    int numID = classID.Next(1, 5000);
    storageAmount += 112; // Storage now is equal to 128
    memoryAmount += 40;  // Memory now is equal to 64
        System.Console.WriteLine($"\t[{databaseName[2]} is running on PORT: {portID[2]}]");
        System.Console.WriteLine($"\t\t\t[STORAGE : {storageAmount}GB]");
        System.Console.WriteLine($"\t\t\t[RAM : {memoryAmount}GB]");
        System.Console.WriteLine($"\t\t\t[PORT ID : {numID}]");
        System.Console.WriteLine($"\t\t\t[DATABASE TYPE : {databaseType[2]}]");
}
    System.Console.WriteLine("");
    System.Console.WriteLine("===========================================");
