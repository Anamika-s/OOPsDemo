using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsDemo
{
    internal class StringFunctions
    {
        static void Main()
        {
            string sen = "This is a new.Book";
            Console.WriteLine(sen.Length);
            Console.WriteLine(sen.StartsWith('T'));
            Console.WriteLine(sen.EndsWith('a'));
            Console.WriteLine(sen.Remove(1));
            Console.WriteLine(sen.PadLeft(20));
            Console.WriteLine(sen.PadRight(50) + 'a');
            Console.WriteLine(sen.ToUpper());
            Console.WriteLine(sen.ToLower());
            Console.WriteLine(sen.IndexOf('a',2));
            //string[] s = sen.Split(' ');
            string[] strings = sen.Split(new char[] { ' ', '.' });
             foreach(string s in strings)
            {
                Console.WriteLine(s);
            }
            string sent = "            Ajay      Sood    ";
            Console.WriteLine(sent);
            Console.WriteLine(sent.Length);
            Console.WriteLine(sent.Trim());
            Console.WriteLine(sent.Trim().Length);
            strings = sent.Trim().Split(' ');
            foreach (string s in strings)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine(strings.Length);
            Console.WriteLine(sen.Substring(0,1));
            Console.WriteLine(sen.Substring(sen.Length, -9));

        }
    }
}
