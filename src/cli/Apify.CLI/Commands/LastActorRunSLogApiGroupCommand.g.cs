#nullable enable

using System.CommandLine;

namespace Apify.CLI.Commands;

internal static class LastActorRunSLogApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"last-actor-run-s-log", @"Last Actor run's log endpoint commands.");
                         command.Subcommands.Add(LastActorRunSLogActRunsLastLogGetCommandApiCommand.Create());
        return command;
    }
}