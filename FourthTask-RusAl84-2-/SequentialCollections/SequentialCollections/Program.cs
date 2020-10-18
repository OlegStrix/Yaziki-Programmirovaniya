using System.Collections;

namespace SequentialCollections
{
	class Program
	{
		public static void Main(string[] args)
		{
			Queue queue = new Queue();
			
			queue.Enqueue("First");
			queue.Enqueue("Second");
			queue.Enqueue("Third");
			queue.Enqueue("Fourth");
			
			while (queue.Count>0){
				object obj = queue.Dequeue();
				System.Console.WriteLine("From Queue: {0}",obj);
			}
			
			
			
			System.Console.Write("Press any key to continue . . . ");
			System.Console.ReadKey(true);
		}
	}
}