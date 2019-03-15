using LiamMoat.DotNet.GitIgnore.Commands;
using McMaster.Extensions.CommandLineUtils;

namespace LiamMoat.DotNet.GitIgnore
{
    [HelpOption]
    [Subcommand(typeof(ListCommand))]
    [Subcommand(typeof(GenerateCommand))]
    [Subcommand(typeof(PreviewCommand))]
    [Command(Name = "dotnet giio", Description = "Create useful .gitignore files for your project using gitignore.io")]
    public class App
    {
        private int OnExecute(CommandLineApplication app, IConsole console)
        {
            app.ShowHelp();
            return 0;
        }
    }
}
