using System;

class Program
{
    static void Main()
    {
        dataBases.portList();
        programInstructions.consoleLogs();
        programInstructions.loopProgram();
    }
}

public class dataBases // Public Class for Databases
{
    public static int[] databaseID = new int[4]; // Declaring Database ID's
    public static string[] databaseName = new string[4]; // Declaring Database Names
    public static string[] databaseType = new string[4]; // Declaring Database Types
    public static int[] portID = new int[4]; // Declaring Port ID's

    // Static constructor to initialize data
    static dataBases()
    {
        databaseID[0] = 5456747;
        databaseID[1] = 4829933;
        databaseID[2] = 4721010;
        databaseID[3] = 4843758;

        databaseName[0] = "DATABASE 1";
        databaseName[1] = "DATABASE 2";
        databaseName[2] = "DATABASE 3";
        databaseName[3] = "DATABASE 4";

        databaseType[0] = "Oracle";
        databaseType[1] = "MySQL";
        databaseType[2] = "Microsoft SQL";
        databaseType[3] = "Postgre SQL";
    }

    public static void portList()
    {
        portID[0] = 8800;
        portID[1] = 5000;
        portID[2] = 6500;
        portID[3] = 9100;
    }
}

public class programInstructions
{
    public static int storageAmount = 0;
    public static int memoryAmount = 0;

    public static void consoleLogs()
    {
        System.Console.WriteLine("===========================================");
        System.Console.WriteLine("");
        System.Console.WriteLine("\t\t\tGeneral Information:");
        System.Console.WriteLine("");
        System.Console.WriteLine("===========================================");
    }

    public static void loopProgram()
    {
        for (var redo = 0; redo < 4; redo++)
        {
            switch (dataBases.portID[redo])
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
                case 9100:
                    storageAmount = 64;
                    memoryAmount = 24;
                    break;
            }

            switch (dataBases.databaseType[redo])
            {
                case "Oracle":
                    dataBases.databaseID[redo] = 5844;
                    break;
                case "MySQL":
                    dataBases.databaseID[redo] = 4822;
                    break;
                case "Microsoft SQL":
                    dataBases.databaseID[redo] = 9382;
                    break;
                case "Postgre SQL":
                    dataBases.databaseID[redo] = 1363;
                    break;
            }

            finalLogs(redo);
        }
    }

    public static void finalLogs(int redo)
    {
        System.Console.WriteLine("");
        System.Console.WriteLine($"\t{dataBases.databaseName[redo]} is running on {dataBases.portID[redo]}");
        System.Console.WriteLine($"\t\tSTORAGE : {storageAmount}GB");
        System.Console.WriteLine($"\t\tRAM : {memoryAmount}GB");
        System.Console.WriteLine($"\t\tDATABASE TYPE : {dataBases.databaseType[redo]}");
        System.Console.WriteLine($"\t\tDATABASE ID : {dataBases.databaseID[redo]}");
        System.Console.WriteLine("");
        System.Console.WriteLine("===========================================");
        System.Console.WriteLine("");
    }
}
