using System;
using System.IO;

namespace WorkingWithFiles
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // FileMethods();

            // DirectoryMethod();

            // PathMethod();
            
            
            
        }

        public static void PathMethod()
        {
            var path = @"..\..\myfile.txt";
            Console.WriteLine("Extension of myfile.txt: {0}", Path.GetExtension(path));
            Console.WriteLine("FileName of myfile.txt: {0}", Path.GetFileName(path));
            Console.WriteLine("FileName of myfile.txt: {0}", Path.GetFileNameWithoutExtension(path));
            Console.WriteLine("Directory of myfile.txt: {0}", Path.GetDirectoryName(path));
        }

        public static void DirectoryMethod()
        {
            var path = @"..\..\myfolder";
            Directory.CreateDirectory(path);
            var files = Directory.GetFiles(@"..\..\", "*.*", SearchOption.AllDirectories);
            foreach (var file in files)
            {
                Console.WriteLine(file);
            }

            Console.WriteLine();

            var directories = Directory.GetDirectories(@"..\..\", "*.*", SearchOption.AllDirectories);
            foreach (var directory in directories)
            {
                Console.WriteLine(directory);
            }

            Directory.Delete(path);
            Console.WriteLine();

            var directoryInfo = new DirectoryInfo(path);
            directoryInfo.Create();
            if (directoryInfo.Exists)
            {
                Console.WriteLine(directoryInfo.Name);
            }

            directoryInfo.Delete();
        }

        public static void FileMethods()
        {
            var myfile = @"..\..\myfile.txt";
            var tempfile = @"..\..\tempfile.txt";
            File.Copy(myfile, tempfile, true);
            if (File.Exists(tempfile))
            {
                Console.WriteLine(File.ReadAllText(tempfile));
                File.Delete(@"..\..\tempfile");
            }

            var fileInfo = new FileInfo(myfile);
            var tempfileInfo = fileInfo.CopyTo(tempfile, true);
            if (tempfileInfo.Exists)
            {
                Console.WriteLine(tempfileInfo);
            }
        }
    }
}