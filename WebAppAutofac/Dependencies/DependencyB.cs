using System;

namespace WebAppAutofac
{
	public class DependencyB : IDependencyB
    {
		void IDependencyB.DoStuff()
		{
			Console.WriteLine("Dependency B");
		}
	}
}
