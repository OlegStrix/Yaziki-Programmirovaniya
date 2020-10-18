using System.Collections;
namespace DictionaryCollection
{
	class Program
	{
		public static void Main(string[] args)
		{
			Hashtable lookup = new Hashtable();
			
			lookup["0"] ="Zero";
			lookup["1"] ="One";
			lookup["2"] ="Two";
			lookup["3"] ="Three";
			lookup["4"] ="Four";
			lookup["5"] ="Five";
			lookup["6"] ="Six";
			lookup["7"] ="Seven";
			lookup["8"] ="Eight";
			lookup["9"] ="Nine";
			
			string Number = "8-800-555-35-35";
			foreach (char c in Number){
				string digit = c.ToString();
				if (lookup.ContainsKey(digit)){
				    	System.Console.WriteLine(lookup[digit]);
				    }
			}
			
			System.Console.Write("Press any key to continue . . . ");
			System.Console.ReadKey(true);
		}
	}
}