using System;
using System.IO;

namespace TextViewer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Text Viewer");
            Console.WriteLine("------------------");
            
            Console.WriteLine("Enter 'open' to open a file or 'exit' to quit:");
            string command = Console.ReadLine();

            while (command.ToLower() != "exit")
            {
                if (command.ToLower() == "open")
                {
                    Console.WriteLine("Enter the file path:");
                    string filePath = Console.ReadLine();

                    try
                    {
                        string[] lines = File.ReadAllLines(filePath);
                        Console.WriteLine("File Contents:");
                        foreach (string line in lines)
                        {
                            Console.WriteLine(line);
                        }
                    }
                    catch (FileNotFoundException)
                    {
                        Console.WriteLine("File not found.");
                    }
                }

                Console.WriteLine("------------------");
                Console.WriteLine("Enter 'open' to open a file or 'exit' to quit:");
                command = Console.ReadLine();
            }
        }
    }
}
