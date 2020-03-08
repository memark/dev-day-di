using System;

namespace ConsoleApp
{
	public class DependencyB : IDependencyB
    {
		void IDependencyB.DoStuff()
		{
			Console.WriteLine("Dependency B");
		}
	}
}
