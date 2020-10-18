using System.Globalization;
using System.Collections;
using System.Collections.Specialized;

namespace LookupCollection
{
	class Program
	{
		public static void Main(string[] args)
		{
			ListDictionary list = new ListDictionary( new CaseInsensitiveComparer(CultureInfo.InvariantCulture));
			
			list["Estados Unidos"] = "United States of America";
			list["Canada"] = "Canada";
			list["Espana"] = "Spain";
			
			System.Console.WriteLine(list["espana"]);
			System.Console.WriteLine(list["CANADA"]);
			
			
			System.Console.Write("Press any key to continue . . . ");
			System.Console.ReadKey(true);
		}
	}
}