#nullable enable

using System.CommandLine;

namespace Apify.CLI.Commands;

internal static class LastActorTaskRunSMetamorphApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"last-actor-task-run-s-metamorph", @"Last Actor task run's metamorph endpoint commands.");
                         command.Subcommands.Add(LastActorTaskRunSMetamorphActorTaskRunsLastMetamorphPostCommandApiCommand.Create());
        return command;
    }
}