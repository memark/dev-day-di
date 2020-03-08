using System;

namespace ConsoleApp
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
			return new ConsoleApp();
		}
    }
}
