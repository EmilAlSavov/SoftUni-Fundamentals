using System;

namespace Extract_File
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = Console.ReadLine();

            string file = filePath.Substring(filePath.LastIndexOf('\\') + 1);

            string fileName = file.Substring(0, file.LastIndexOf('.'));
            string  fileExtension = file.Substring(file.LastIndexOf('.') + 1);

            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {fileExtension}");
        }
    }
}
