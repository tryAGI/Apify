#nullable enable

using System.CommandLine;

namespace Apify.CLI.Commands;

internal static class LastActorRunSMetamorphApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"last-actor-run-s-metamorph", @"Last Actor run's metamorph endpoint commands.");
                         command.Subcommands.Add(LastActorRunSMetamorphActRunsLastMetamorphPostCommandApiCommand.Create());
        return command;
    }
}