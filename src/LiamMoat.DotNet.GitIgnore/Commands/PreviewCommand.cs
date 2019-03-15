using LiamMoat.DotNet.GitIgnore.Services;
using McMaster.Extensions.CommandLineUtils;
using System.Threading.Tasks;

namespace LiamMoat.DotNet.GitIgnore.Commands
{
    [HelpOption]
	[Command(Description = "Preview a generated a .gitignore file")]
	public class PreviewCommand
	{
		private readonly IGitIgnoreService _gitIgnoreService;

        public PreviewCommand(IGitIgnoreService gitIgnoreService)
		{
			_gitIgnoreService = gitIgnoreService;
        }

        [Argument(0, "Types", "List of operating systems, programming languages and IDEs")]
        public string[] Types { get; set; }

		private async Task<int> OnExecuteAsync(CommandLineApplication app, IConsole console)
		{
			console.WriteLine($"Previewing a .gitignore file for {string.Join(',', Types)}");

			var contents = await _gitIgnoreService.GetTemplateAsync(Types);

            console.WriteLine(contents);

			return 0;
		}
	}
}
