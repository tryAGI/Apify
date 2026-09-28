#nullable enable

using System.CommandLine;

namespace Apify.CLI.Commands;

internal static partial class LastActorTaskRunSRebootApiGroupCommand
{
    static partial void CustomizeCommand(ref Command command);

    public static Command Create()
    {
        var command = new Command(@"last-actor-task-run-s-reboot", @"Last Actor task run's reboot endpoint commands.");
                         command.Subcommands.Add(LastActorTaskRunSRebootActorTaskRunsLastRebootPostCommandApiCommand.Create());
        CustomizeCommand(ref command);
        return command;
    }
}