#nullable enable

using System.CommandLine;

namespace Apify.CLI.Commands;

internal static class ActorsActorRunsApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"actors-actor-runs", @"Actors/Actor runs endpoint commands.");
                         command.Subcommands.Add(ActorsActorRunsActRunResurrectPostCommandApiCommand.Create());
                         command.Subcommands.Add(ActorsActorRunsActRunSyncGetCommandApiCommand.Create());
                         command.Subcommands.Add(ActorsActorRunsActRunSyncGetDatasetItemsGetCommandApiCommand.Create());
                         command.Subcommands.Add(ActorsActorRunsActRunSyncGetDatasetItemsPostCommandApiCommand.Create());
                         command.Subcommands.Add(ActorsActorRunsActRunSyncPostCommandApiCommand.Create());
                         command.Subcommands.Add(ActorsActorRunsActRunsGetCommandApiCommand.Create());
                         command.Subcommands.Add(ActorsActorRunsActRunsLastGetCommandApiCommand.Create());
                         command.Subcommands.Add(ActorsActorRunsActRunsPostCommandApiCommand.Create());
        return command;
    }
}