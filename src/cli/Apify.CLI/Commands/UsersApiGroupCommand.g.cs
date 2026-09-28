#nullable enable

using System.CommandLine;

namespace Apify.CLI.Commands;

internal static partial class UsersApiGroupCommand
{
    static partial void CustomizeCommand(ref Command command);

    public static Command Create()
    {
        var command = new Command(@"users", @"Users endpoint commands.");
                         command.Subcommands.Add(UsersUserGetCommandApiCommand.Create());
                         command.Subcommands.Add(UsersUsersMeGetCommandApiCommand.Create());
        CustomizeCommand(ref command);
        return command;
    }
}