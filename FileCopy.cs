using System;
using System.IO;

namespace FileCopy
{
    class Program
    {
        static void Main(string[] args)
        {
            FileCheck();
        }

        static void FileCheck()
        {
            var source = new DirectoryInfo(@"C:\Users\Student\Desktop\Source");
            var destination = @"C:\Users\Student\Desktop\Destination";

            Directory.CreateDirectory(destination);

            try
            {
                foreach (var file in source.GetFiles())
                {
                    if (DateTime.Now <= file.LastWriteTime.AddHours(24))
                    {
                        file.CopyTo(Path.Combine(destination, file.Name));
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}

