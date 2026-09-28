#nullable enable

using System.CommandLine;

namespace Apify.CLI.Commands;

internal static partial class LastActorRunSAbortApiGroupCommand
{
    static partial void CustomizeCommand(ref Command command);

    public static Command Create()
    {
        var command = new Command(@"last-actor-run-s-abort", @"Last Actor run's abort endpoint commands.");
                         command.Subcommands.Add(LastActorRunSAbortActorRunsLastAbortPostCommandApiCommand.Create());
        CustomizeCommand(ref command);
        return command;
    }
}