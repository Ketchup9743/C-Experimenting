int[] databaseID = new int[3];  // Declaring Database ID's 
    databaseID[0] = 5456747;
    databaseID[1] = 4829933;
    databaseID[2] = 4721010;
int[] portID = new int[3];   // Declaring Port Values
    portID[0] = 8800;
    portID[1] = 5000;
    portID[2] = 6500;
string[] databaseName = new string[3];   // Declaring Database Names
    databaseName[0] = "DATABASE 1";
    databaseName[1] = "DATABASE 2";
    databaseName[2] = "DATABASE 3";
string[] databaseType = new string[3];  // Declaring Database Types
    databaseType[0] = "Oracle";
    databaseType[1] = "MySQL";
    databaseType[2] = "Microsoft SQL";
        System.Console.WriteLine("===========================================");
        System.Console.WriteLine("");
        System.Console.WriteLine("\t\t\tGeneral Information:");
        System.Console.WriteLine("");
        System.Console.WriteLine("===========================================");
int storageAmount = 0;
int memoryAmount = 0;
for (var redo = 0; redo < 3; redo++)
    {
       switch(portID[redo])    // Assigns RAM and Storage to each port
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
        switch(databaseType[redo])
            {
                case "Oracle":
                    databaseID[0] = 5844;
                break;

                case "MySQL":
                    databaseID[1] = 4822;
                break;

                case "Microsoft SQL":
                    databaseID[2] = 9382;
                break;
            }
    System.Console.WriteLine("");
    System.Console.WriteLine($"\t{databaseName[redo]} is running on {portID[redo]}");  // Prints all of the info to the Console
    System.Console.WriteLine($"\t\tSTORAGE : {storageAmount}GB");
    System.Console.WriteLine($"\t\tRAM : {memoryAmount}GB");
    System.Console.WriteLine($"\t\tDATABASE TYPE : {databaseType[redo]}");
    System.Console.WriteLine($"\t\tDATABASE ID : {databaseID[redo]}");
    System.Console.WriteLine("");
    System.Console.WriteLine("===========================================");
    System.Console.WriteLine("");
    }