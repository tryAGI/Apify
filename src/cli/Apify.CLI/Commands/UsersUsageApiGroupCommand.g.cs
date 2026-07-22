#nullable enable

using System.CommandLine;

namespace Apify.CLI.Commands;

internal static class UsersUsageApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"users-usage", @"Users/Usage endpoint commands.");
                         command.Subcommands.Add(UsersUsageUsersMeLimitsGetCommandApiCommand.Create());
                         command.Subcommands.Add(UsersUsageUsersMeLimitsPutCommandApiCommand.Create());
                         command.Subcommands.Add(UsersUsageUsersMeUsageMonthlyGetCommandApiCommand.Create());
        return command;
    }
}