#nullable enable

using System.CommandLine;

namespace Apify.CLI.Commands;

internal static class ActorTasksApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"actor-tasks", @"Actor tasks endpoint commands.");
                         command.Subcommands.Add(ActorTasksActorTaskDeleteCommandApiCommand.Create());
                         command.Subcommands.Add(ActorTasksActorTaskGetCommandApiCommand.Create());
                         command.Subcommands.Add(ActorTasksActorTaskInputGetCommandApiCommand.Create());
                         command.Subcommands.Add(ActorTasksActorTaskInputPutCommandApiCommand.Create());
                         command.Subcommands.Add(ActorTasksActorTaskPutCommandApiCommand.Create());
                         command.Subcommands.Add(ActorTasksActorTaskRunSyncGetCommandApiCommand.Create());
                         command.Subcommands.Add(ActorTasksActorTaskRunSyncGetDatasetItemsGetCommandApiCommand.Create());
                         command.Subcommands.Add(ActorTasksActorTaskRunSyncGetDatasetItemsPostCommandApiCommand.Create());
                         command.Subcommands.Add(ActorTasksActorTaskRunSyncPostCommandApiCommand.Create());
                         command.Subcommands.Add(ActorTasksActorTaskRunsGetCommandApiCommand.Create());
                         command.Subcommands.Add(ActorTasksActorTaskRunsLastGetCommandApiCommand.Create());
                         command.Subcommands.Add(ActorTasksActorTaskRunsPostCommandApiCommand.Create());
                         command.Subcommands.Add(ActorTasksActorTaskWebhooksGetCommandApiCommand.Create());
                         command.Subcommands.Add(ActorTasksActorTasksGetCommandApiCommand.Create());
                         command.Subcommands.Add(ActorTasksActorTasksPostCommandApiCommand.Create());
        return command;
    }
}