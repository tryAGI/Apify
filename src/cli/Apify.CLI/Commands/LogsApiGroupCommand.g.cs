#nullable enable

using System.CommandLine;

namespace Apify.CLI.Commands;

internal static class LogsApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"logs", @"Logs endpoint commands.");
                         command.Subcommands.Add(LogsLogGetCommandApiCommand.Create());
        return command;
    }
}