using System;

namespace ConsoleApp
{
    public class ConsoleApp
    {      
		public void Run()
		{
			Console.WriteLine("Running Console App with no DI");

			var depA = new DependencyA();
			depA.DoStuff();
		}
    }
}
