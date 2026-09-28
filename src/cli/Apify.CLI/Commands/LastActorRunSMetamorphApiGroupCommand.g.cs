#nullable enable

using System.CommandLine;

namespace Apify.CLI.Commands;

internal static partial class LastActorRunSMetamorphApiGroupCommand
{
    static partial void CustomizeCommand(ref Command command);

    public static Command Create()
    {
        var command = new Command(@"last-actor-run-s-metamorph", @"Last Actor run's metamorph endpoint commands.");
                         command.Subcommands.Add(LastActorRunSMetamorphActorRunsLastMetamorphPostCommandApiCommand.Create());
        CustomizeCommand(ref command);
        return command;
    }
}