using System;
using static System.Console;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CpnsoleApplication1
{
    class TestFile
    {
        static void Main(string[] args)
        {
            string END = "end";
            string directoryName;
            string[] listOfFiles;
            WriteLine("enter a folder name   ");
            directoryName = ReadLine();
            while (directoryName != END)
            {
                if (Directory.Exists(directoryName))
                {

                    WriteLine("the directory exisits, " + "and it contains: ");
                    listOfFiles = Directory.GetFiles(directoryName);
                    for (int x = 0; x < listOfFiles.Length; ++x)
                        WriteLine("    {0}", listOfFiles[x]);
                    WriteLine("copy which file name you would like to see information about  ");
                    string fileName = ReadLine();
                    WriteLine("File exisits");
                    WriteLine("File was created on " + File.GetCreationTime(fileName));
                    WriteLine("File was last accessed " + File.GetLastAccessTime(fileName));
                }
                else
                {
                    WriteLine("Directory does not exist");
                }
                WriteLine("enter another directory or type " + END);
                directoryName = ReadLine();
            }

        }
    }
}
