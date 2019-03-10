using System;
using System.Net.Http;
using LiamMoat.DotNet.GitIgnore.Services;
using McMaster.Extensions.CommandLineUtils;
using Microsoft.Extensions.DependencyInjection;

namespace LiamMoat.DotNet.GitIgnore
{
	class Program
	{
		public static int Main(string[] args)
		{
			var services = new ServiceCollection()
                .AddSingleton(new HttpClient()
                {
                    BaseAddress = new Uri("https://www.gitignore.io/api/")
                })
                .AddSingleton<IGitIgnoreService, GitIgnoreService>()
                .AddSingleton<IIgnoreWriter, IgnoreWriter>()
                .BuildServiceProvider();

			var app = new CommandLineApplication<App>();
			app.Conventions
				.UseDefaultConventions()
				.UseConstructorInjection(services);

			return app.Execute(args);
		}
	}
}
