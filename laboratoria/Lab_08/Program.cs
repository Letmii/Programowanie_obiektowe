using System;
using System.Threading;


public class ThreadE
{
	
	public static void ThreadProc()
	{
		for (int i = 0; i <= 10; i++)
		{
			Console.WriteLine("ThreadProc: {0}", i);
			
			Thread.Sleep(1000);
		}
	}



	public class Program
	{
		public static void Main(string[] args)
		{

			Console.WriteLine("Main thread: Start a second thread.");

			Thread thread = new Thread(new ThreadStart(ThreadProc));
			thread.Start();


			{
				for (int i = 1; i <= 10; ++i)
				{
					Console.WriteLine("Iteration: " + i);
					Thread.Sleep(1000); 
				}

				thread.Join();


			}
		}
	}
}