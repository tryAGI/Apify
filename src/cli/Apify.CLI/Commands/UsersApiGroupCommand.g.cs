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
                         command.Subcommands.Add(UsersUsersMeLimitsGetCommandApiCommand.Create());
                         command.Subcommands.Add(UsersUsersMeLimitsPutCommandApiCommand.Create());
                         command.Subcommands.Add(UsersUsersMeUsageMonthlyGetCommandApiCommand.Create());
        return command;
    }
}