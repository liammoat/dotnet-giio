using LiamMoat.DotNet.GitIgnore.Services;
using McMaster.Extensions.CommandLineUtils;
using System.Threading.Tasks;

namespace LiamMoat.DotNet.GitIgnore.Commands
{
	[HelpOption]
	[Command(Description = "List available types")]
	public class ListCommand
	{
		private readonly IGitIgnoreService _gitIgnoreService;

		public ListCommand(IGitIgnoreService gitIgnoreService)
		{
			_gitIgnoreService = gitIgnoreService;
		}

		[Option("--query", CommandOptionType.SingleValue)]
		public string Query { get; set; }

		private async Task<int> OnExecuteAsync(CommandLineApplication app, IConsole console)
		{
			console.WriteLine($"Listing available types for gitignore.io");

			var types = await _gitIgnoreService.GetTypesAsync(Query);

			foreach (var type in types)
			{
				console.WriteLine(type);
			}

			return 0;
		}
	}
}
