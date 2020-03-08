using System;

namespace ConsoleAppPMDI
{
    public class DependencyA
    {
		private readonly IDependencyB dependencyB;

		public DependencyA(IDependencyB dependencyB)
		{
			this.dependencyB = dependencyB;
		}

		public void DoStuff()
        {
			Console.WriteLine("Dependency A");

			dependencyB.DoStuff();
        }
    }
}
