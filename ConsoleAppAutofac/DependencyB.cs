using System;

namespace ConsoleAppAutofac
{
	public class DependencyB : IDependencyB
    {
		void IDependencyB.DoStuff()
		{
			Console.WriteLine("Dependency B");
		}
	}
}
