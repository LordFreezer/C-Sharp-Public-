using System;
using System.IO;
public class DirectoryInformation
{
    public static void Main()
    {
        string directoryName;
        string[] listOfFiles;
        Console.WriteLine("Make sure you include full address");
        Console.WriteLine("example: D:/Documents/Caesar");
        Console.WriteLine();
        Console.Write("Enter a folder >> ");
        directoryName = Console.ReadLine();

        
                if (Directory.Exists(directoryName))
                {
                    Console.WriteLine("Directory exists, " +
                       "and it contains the following:");
                    listOfFiles = Directory.GetFiles(directoryName);
                    for (int x = 0; x < listOfFiles.Length; ++x)
                    {
                        Console.WriteLine("   {0}", listOfFiles[x]);
                        DateTime creation = File.GetCreationTime(@directoryName);
                        DateTime modification = File.GetLastWriteTime(@directoryName);
                        Console.WriteLine("Creation time and date: {0}", File.GetCreationTime(@directoryName));
                        Console.WriteLine("Date and time modified: {0}", File.GetLastWriteTime(@directoryName));           
                    }
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Directory does not exist");
                }
                Console.ReadLine();
    }
}
