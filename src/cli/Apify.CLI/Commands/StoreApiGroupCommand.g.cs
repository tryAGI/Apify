#nullable enable

using System.CommandLine;

namespace Apify.CLI.Commands;

internal static class StoreApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"store", @"Store endpoint commands.");
                         command.Subcommands.Add(StoreStoreGetCommandApiCommand.Create());
        return command;
    }
}