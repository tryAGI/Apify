#nullable enable

using System.CommandLine;

namespace Apify.CLI.Commands;

internal static class LastActorRunSAbortApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"last-actor-run-s-abort", @"Last Actor run's abort endpoint commands.");
                         command.Subcommands.Add(LastActorRunSAbortActorRunsLastAbortPostCommandApiCommand.Create());
        return command;
    }
}