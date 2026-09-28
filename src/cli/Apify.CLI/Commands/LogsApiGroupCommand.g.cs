#nullable enable

using System.CommandLine;

namespace Apify.CLI.Commands;

internal static partial class LogsApiGroupCommand
{
    static partial void CustomizeCommand(ref Command command);

    public static Command Create()
    {
        var command = new Command(@"logs", @"Logs endpoint commands.");
                         command.Subcommands.Add(LogsLogGetCommandApiCommand.Create());
        CustomizeCommand(ref command);
        return command;
    }
}