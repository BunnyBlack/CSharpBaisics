using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace WorkingWithFiles
{
    public class Exercises
    {
        public static void Exercise76_1()
        {
            var path = @"..\..\myfile.txt";
            var contents = File.ReadAllText(path);
            var words = contents.Split(' ');
            Console.WriteLine("Total words: {0}", words.Length);
        }

        public static void Exercise76_2()
        {
            var path = @"..\..\myfile.txt";
            var contents = File.ReadAllText(path);
            var words = contents.Split(' ');
            var matches = new List<string>();
            foreach (var word in words)
            {
                var newWord = Regex.Replace(word, "[^a-zA-Z]", "");
                matches.Add(newWord);
            }
            matches.Sort(CompareByLength);
            Console.WriteLine(matches[matches.Count - 1]);
        }

        private static int CompareByLength(string x, string y)
        {
            if (x == null)
            {
                if (y == null)
                {

                    return 0;
                }
                else
                {
                    return -1;
                }
            }
            else
            {
                if (y == null)
                {
                    return 1;
                }
                else
                {
                    int retval = x.Length.CompareTo(y.Length);

                    if (retval != 0)
                    {

                        return retval;
                    }
                    else
                    {
                       
                        return x.CompareTo(y);
                    }
                }
            }
        }
        
    }
}

