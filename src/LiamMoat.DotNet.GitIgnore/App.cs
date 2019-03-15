using System.Reflection;
using LiamMoat.DotNet.GitIgnore.Commands;
using McMaster.Extensions.CommandLineUtils;

namespace LiamMoat.DotNet.GitIgnore
{
    [HelpOption]
    [Subcommand(typeof(ListCommand))]
    [Subcommand(typeof(GenerateCommand))]
    [Subcommand(typeof(PreviewCommand))]
    [VersionOptionFromMember(MemberName = nameof(GetVersion))]
    [Command(Name = "dotnet giio", Description = "Create useful .gitignore files for your project using gitignore.io")]
    public class App
    {
        private int OnExecute(CommandLineApplication app, IConsole console)
        {
            app.ShowHelp();
            return 0;
        }

        public static string GetVersion()
        {
            var version = Assembly.GetEntryAssembly().GetName().Version;
            return $"{version.Major}.{version.Minor}.{version.Build}";
        }
    }
}
