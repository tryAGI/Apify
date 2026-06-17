#nullable enable

using System.CommandLine;

namespace Apify.CLI.Commands;

internal static class LastActorRunSRebootApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"last-actor-run-s-reboot", @"Last Actor run's reboot endpoint commands.");
                         command.Subcommands.Add(LastActorRunSRebootActRunsLastRebootPostCommandApiCommand.Create());
        return command;
    }
}