using LiamMoat.DotNet.GitIgnore.Commands;
using McMaster.Extensions.CommandLineUtils;

namespace LiamMoat.DotNet.GitIgnore
{
	[HelpOption]
	[Subcommand(typeof(ListCommand))]
	[Subcommand(typeof(GenerateCommand))]
	public class App
	{

	}
}
