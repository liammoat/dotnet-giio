using LiamMoat.DotNet.GitIgnore.Commands;
using McMaster.Extensions.CommandLineUtils;

namespace LiamMoat.DotNet.GitIgnore
{
    [HelpOption]
    [Subcommand(typeof(ListCommand))]
    [Subcommand(typeof(GenerateCommand))]
    [Subcommand(typeof(PreviewCommand))]
    public class App
    {
        private int OnExecute(CommandLineApplication app, IConsole console)
        {
            app.ShowHelp();
            return 0;
        }
    }
}
