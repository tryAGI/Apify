#nullable enable

using System.CommandLine;

namespace Apify.CLI.Commands;

internal static partial class ActorsActorRunsApiGroupCommand
{
    static partial void CustomizeCommand(ref Command command);

    public static Command Create()
    {
        var command = new Command(@"actors-actor-runs", @"Actors/Actor runs endpoint commands.");
                         command.Subcommands.Add(ActorsActorRunsActorRunResurrectPostCommandApiCommand.Create());
                         command.Subcommands.Add(ActorsActorRunsActorRunSyncGetCommandApiCommand.Create());
                         command.Subcommands.Add(ActorsActorRunsActorRunSyncGetDatasetItemsGetCommandApiCommand.Create());
                         command.Subcommands.Add(ActorsActorRunsActorRunSyncGetDatasetItemsPostCommandApiCommand.Create());
                         command.Subcommands.Add(ActorsActorRunsActorRunSyncPostCommandApiCommand.Create());
                         command.Subcommands.Add(ActorsActorRunsActorRunsLastGetCommandApiCommand.Create());
                         command.Subcommands.Add(ActorsActorRunsActorsRunsGetCommandApiCommand.Create());
                         command.Subcommands.Add(ActorsActorRunsActorsRunsPostCommandApiCommand.Create());
        CustomizeCommand(ref command);
        return command;
    }
}