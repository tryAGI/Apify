#nullable enable

using System.CommandLine;

namespace Apify.CLI.Commands;

internal static partial class LastActorRunSLogApiGroupCommand
{
    static partial void CustomizeCommand(ref Command command);

    public static Command Create()
    {
        var command = new Command(@"last-actor-run-s-log", @"Last Actor run's log endpoint commands.");
                         command.Subcommands.Add(LastActorRunSLogActorRunsLastLogGetCommandApiCommand.Create());
        CustomizeCommand(ref command);
        return command;
    }
}