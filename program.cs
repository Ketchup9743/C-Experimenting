int[] databaseID = new int[5];  // Declaring Database ID's 
    databaseID[0] = 5456747;
    databaseID[1] = 4829933;
    databaseID[2] = 4721010;
    databaseID[3] = 4849393;
    databaseID[4] = 3848212;
int[] portID = new int[3];   // Declaring Port Values
    portID[0] = 8800;
    portID[1] = 5000;
    portID[2] = 6500;
string[] databaseName = new string[5];   // Declaring Database Names
    databaseName[0] = "DATABASE 1";
    databaseName[1] = "DATABASE 2";
    databaseName[2] = "DATABASE 3";
    databaseName[3] = "DATABASE 4";
    databaseName[4] = "DATABASE 5";
string[] databaseType = new string[3];
    databaseType[0] = "SQLite";
    databaseType[1] = "MySQL";
    databaseType[2] = "PostgreSQL";
        System.Console.WriteLine("===========================================");
        System.Console.WriteLine("General Information:");
int storageAmount = 0;
int memoryAmount = 0;

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
