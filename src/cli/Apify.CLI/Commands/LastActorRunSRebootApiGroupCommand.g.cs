#nullable enable

using System.CommandLine;

namespace Apify.CLI.Commands;

internal static partial class LastActorRunSRebootApiGroupCommand
{
    static partial void CustomizeCommand(ref Command command);

    public static Command Create()
    {
        var command = new Command(@"last-actor-run-s-reboot", @"Last Actor run's reboot endpoint commands.");
                         command.Subcommands.Add(LastActorRunSRebootActorRunsLastRebootPostCommandApiCommand.Create());
        CustomizeCommand(ref command);
        return command;
    }
}