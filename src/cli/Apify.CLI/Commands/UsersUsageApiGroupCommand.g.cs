#nullable enable

using System.CommandLine;

namespace Apify.CLI.Commands;

internal static partial class UsersUsageApiGroupCommand
{
    static partial void CustomizeCommand(ref Command command);

    public static Command Create()
    {
        var command = new Command(@"users-usage", @"Users/Usage endpoint commands.");
                         command.Subcommands.Add(UsersUsageUsersMeLimitsGetCommandApiCommand.Create());
                         command.Subcommands.Add(UsersUsageUsersMeLimitsPutCommandApiCommand.Create());
                         command.Subcommands.Add(UsersUsageUsersMeUsageMonthlyGetCommandApiCommand.Create());
        CustomizeCommand(ref command);
        return command;
    }
}