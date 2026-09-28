#nullable enable

using System.CommandLine;

namespace Apify.CLI.Commands;

internal static partial class ToolsApiGroupCommand
{
    static partial void CustomizeCommand(ref Command command);

    public static Command Create()
    {
        var command = new Command(@"tools", @"Tools endpoint commands.");
                         command.Subcommands.Add(ToolsToolsBrowserInfoDeleteCommandApiCommand.Create());
                         command.Subcommands.Add(ToolsToolsBrowserInfoGetCommandApiCommand.Create());
                         command.Subcommands.Add(ToolsToolsBrowserInfoPostCommandApiCommand.Create());
                         command.Subcommands.Add(ToolsToolsBrowserInfoPutCommandApiCommand.Create());
        CustomizeCommand(ref command);
        return command;
    }
}