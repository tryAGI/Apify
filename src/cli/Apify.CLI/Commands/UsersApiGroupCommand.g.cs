#nullable enable

using System.CommandLine;

namespace Apify.CLI.Commands;

internal static class UsersApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"users", @"Users endpoint commands.");
                         command.Subcommands.Add(UsersUserGetCommandApiCommand.Create());
                         command.Subcommands.Add(UsersUsersMeGetCommandApiCommand.Create());
        return command;
    }
}