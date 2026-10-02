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
        System.Console.WriteLine("");
        System.Console.WriteLine("\t\t\tGeneral Information:");
        System.Console.WriteLine("");
        System.Console.WriteLine("===========================================");
int storageAmount = 0;
int memoryAmount = 0;
for (var i = 0; i < 3; i++)
{
    switch(portID[i])    // Assigns RAM and Storage to each port
    {
        case 8800:
            storageAmount = 128;
            memoryAmount = 64;
            break;

        case 5000:
            storageAmount = 32;
            memoryAmount = 16;
            break;

        case 6500:
            storageAmount = 96;
            memoryAmount = 32;
            break;
    }
    System.Console.WriteLine($"\t{databaseName[i]} is running on {portID[i]}");  // Prints all of the info to the Console
    System.Console.WriteLine($"\t\tSTORAGE : {storageAmount}GB");
    System.Console.WriteLine($"\t\tRAM : {memoryAmount}GB");
    System.Console.WriteLine("");
    System.Console.WriteLine("===========================================");
    System.Console.WriteLine("");
}