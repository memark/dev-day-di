using System;

namespace ConsoleAppPMDI
{
	public class DependencyB : IDependencyB
    {
		void IDependencyB.DoStuff()
		{
			Console.WriteLine("Dependency B");
		}
	}
}
