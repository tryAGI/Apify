#nullable enable

using System.CommandLine;

namespace Apify.CLI.Commands;

internal static partial class LastActorTaskRunSLogApiGroupCommand
{
    static partial void CustomizeCommand(ref Command command);

    public static Command Create()
    {
        var command = new Command(@"last-actor-task-run-s-log", @"Last Actor task run's log endpoint commands.");
                         command.Subcommands.Add(LastActorTaskRunSLogActorTaskLastLogGetCommandApiCommand.Create());
        CustomizeCommand(ref command);
        return command;
    }
}