using System;

namespace ConsoleAppMSDI
{
	public class DependencyB : IDependencyB
    {
		void IDependencyB.DoStuff()
		{
			Console.WriteLine("Dependency B");
		}
	}
}
