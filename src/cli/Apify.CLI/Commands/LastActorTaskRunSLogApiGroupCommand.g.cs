#nullable enable

using System.CommandLine;

namespace Apify.CLI.Commands;

internal static class LastActorTaskRunSLogApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"last-actor-task-run-s-log", @"Last Actor task run's log endpoint commands.");
                         command.Subcommands.Add(LastActorTaskRunSLogActorTaskLastLogGetCommandApiCommand.Create());
        return command;
    }
}