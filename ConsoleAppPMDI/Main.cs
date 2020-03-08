using System;

namespace ConsoleAppPMDI
{
	class Program
	{
		static void Main(string[] args)
		{
			var app = CreateApp();
			app.Run();
		}

		static ConsoleApp CreateApp()
		{
			return new ConsoleApp(
				new DependencyA(
					new DependencyB()
				)
			);
		}
	}
}
