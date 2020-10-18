using System;

namespace SortString
{
	class Program
	{
		public static void Main(string[] args)
		{
			string s = "Microsoft .NET Framework 2 Application Development Foundation";
			string[] sa = new string[]{
				"gn","vg","bb","11","00a","aa"
			};
			
			
			
			Array.Sort(sa);	
			s = string.Join(" ", sa); Console.WriteLine(s);
				
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}