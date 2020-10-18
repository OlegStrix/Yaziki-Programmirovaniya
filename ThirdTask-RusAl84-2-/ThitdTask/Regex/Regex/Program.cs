using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Regex2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = { "(555)555-1212", "(555) 555-1212", "555-555-1212", "5555551212", "01111", "01111-1111", "47", "111-11-1111" };
            foreach (string s in input)
            {
                if (IsPhone(s)) Console.WriteLine(s + " is a phone number");
                else if (IsZip(s)) Console.WriteLine(s + " is a zip code");
                else Console.WriteLine(s + " is unknown");
                
            }
            while(Console.ReadKey().Key != ConsoleKey.Escape);

        }

        static bool IsPhone(string s)
        {
            return Regex.IsMatch(s,@"((\+38|8|\+3|\+ )[ ]?)?([(]?\d{3}[)]?[\- ]?)?(\d[ -]?){6,14}");
            return false;
        }

        static bool IsZip(string s)
        {
        	return Regex.IsMatch(s, @"^\d{5}(?:[-\s]\d{4})?$");
            return false;
        }
    }
    

}
