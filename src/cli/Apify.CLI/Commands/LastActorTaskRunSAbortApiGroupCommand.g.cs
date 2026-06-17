#nullable enable

using System.CommandLine;

namespace Apify.CLI.Commands;

internal static class LastActorTaskRunSAbortApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"last-actor-task-run-s-abort", @"Last Actor task run's abort endpoint commands.");
                         command.Subcommands.Add(LastActorTaskRunSAbortActorTaskRunsLastAbortPostCommandApiCommand.Create());
        return command;
    }
}