#nullable enable

using System.CommandLine;

namespace Apify.CLI.Commands;

internal static partial class LastActorTaskRunSMetamorphApiGroupCommand
{
    static partial void CustomizeCommand(ref Command command);

    public static Command Create()
    {
        var command = new Command(@"last-actor-task-run-s-metamorph", @"Last Actor task run's metamorph endpoint commands.");
                         command.Subcommands.Add(LastActorTaskRunSMetamorphActorTaskRunsLastMetamorphPostCommandApiCommand.Create());
        CustomizeCommand(ref command);
        return command;
    }
}