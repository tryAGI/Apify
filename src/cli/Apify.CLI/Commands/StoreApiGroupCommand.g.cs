#nullable enable

using System.CommandLine;

namespace Apify.CLI.Commands;

internal static partial class StoreApiGroupCommand
{
    static partial void CustomizeCommand(ref Command command);

    public static Command Create()
    {
        var command = new Command(@"store", @"Store endpoint commands.");
                         command.Subcommands.Add(StoreStoreGetCommandApiCommand.Create());
        CustomizeCommand(ref command);
        return command;
    }
}