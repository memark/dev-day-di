using System;

namespace ConsoleApp
{
    public class DependencyA
    {
        public void DoStuff()
        {
			Console.WriteLine("Dependency A");

			var depB = new DependencyB() as IDependencyB;
			depB.DoStuff();
        }
    }
}
