using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace GenericCollections
{
	class Program
	{
		public static void Main(string[] args)
		{
			Dictionary<int, string> countryLookup = new Dictionary<int, string>();
			 
			
			countryLookup[72] = "Germany";
			countryLookup[1] = "Russia";
			countryLookup[23] = "Spain"; 
			//countryLookup[30] = China;
   			countryLookup[42] = "Italy";
   			
   			System.Console.WriteLine("The 1 Code is for: {0}",countryLookup[1]);
   			
   			foreach(KeyValuePair<int,String> item in countryLookup){
   				
   				int code = item.Key;
   				string country = item.Value;
   				Console.WriteLine("Code {0} = {1}", code, country);
   			}
			
			
			
			
			
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}