#nullable enable

using System.CommandLine;

namespace Apify.CLI.Commands;

internal static class ToolsApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"tools", @"Tools endpoint commands.");
                         command.Subcommands.Add(ToolsToolsBrowserInfoDeleteCommandApiCommand.Create());
                         command.Subcommands.Add(ToolsToolsBrowserInfoGetCommandApiCommand.Create());
                         command.Subcommands.Add(ToolsToolsBrowserInfoPostCommandApiCommand.Create());
                         command.Subcommands.Add(ToolsToolsBrowserInfoPutCommandApiCommand.Create());
        return command;
    }
}