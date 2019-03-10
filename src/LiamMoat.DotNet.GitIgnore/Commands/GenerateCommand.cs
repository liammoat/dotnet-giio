using LiamMoat.DotNet.GitIgnore.Services;
using McMaster.Extensions.CommandLineUtils;
using System.Threading.Tasks;

namespace LiamMoat.DotNet.GitIgnore.Commands
{
    [HelpOption]
	[Command(Description = "Generate a .gitignore file")]
	public class GenerateCommand
	{
		private readonly IGitIgnoreService _gitIgnoreService;
        private readonly IIgnoreWriter _ignoreWriter;

        public GenerateCommand(IGitIgnoreService gitIgnoreService, IIgnoreWriter ignoreWriter)
		{
			_gitIgnoreService = gitIgnoreService;
            _ignoreWriter = ignoreWriter;
        }

		[Argument(0, "Types", "")]
		public string[] Types { get; set; }

		private async Task<int> OnExecuteAsync(CommandLineApplication app, IConsole console)
		{
			console.WriteLine($"Generating a .gitignore file for {string.Join(',', Types)}");

			var contents = await _gitIgnoreService.GetTemplateAsync(Types);
            await _ignoreWriter.WriteIgnoreFileAsync(contents);

			return 0;
		}
	}
}
