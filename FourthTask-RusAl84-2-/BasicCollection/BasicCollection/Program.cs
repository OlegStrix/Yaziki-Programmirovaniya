using System.Collections;
	class Program{
		static void Main(string[] args) {
			ArrayList myList = new ArrayList(); 
			myList.Add("Second");
			myList.Add("Fourth");
			myList.Add("First");
			myList.Add("Third");
			
			foreach (string item in myList) {
				System.Console.WriteLine("Unsorted: {0}", item);
			}

				myList.Sort();
			
				foreach (string item in myList) {
					System.Console.WriteLine("Sorted: {0}", item);
				}
				System.Console.ReadKey();
}
}