using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuetions
{
    public class DuplicateString
    {
        private const string teststring = "this is my string that has values 1234554321";
        private const int startcount = 1;

        public static void duplicatestringtest()
        {
            string stringtotest = teststring;

            char[] chararray = stringtotest.ToCharArray();
            int counter = startcount;
            Dictionary<char, int> characterstorage = new Dictionary<char, int>();

            foreach (var c in chararray)
            {
                if (!characterstorage.ContainsKey(c))
                {
                    characterstorage.Add(c, counter);
                }
                else
                {
                    characterstorage[c] += 1;
                }
            }

            Console.WriteLine("Duplicate chars in string....");
            foreach (var c in characterstorage.Keys)
            {
                if (characterstorage[c] > 1)
                {
                    Console.WriteLine($"char:{c} - count:{characterstorage[c]}");
                }
            }
        }
    }
}
