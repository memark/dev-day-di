using System;

namespace ConsoleAppPMDI
{
    public class ConsoleApp
    {
		private readonly DependencyA dependencyA;

		public ConsoleApp(DependencyA dependencyA)
		{
			this.dependencyA = dependencyA;
		}

		public void Run()
		{
			Console.WriteLine("Running Console App using Poor Man's DI");

			dependencyA.DoStuff();
		}
    }
}
