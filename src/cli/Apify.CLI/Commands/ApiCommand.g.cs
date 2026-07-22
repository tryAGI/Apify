#nullable enable

using System.CommandLine;

namespace Apify.CLI.Commands;

internal static class ApiCommand
{
    public static Command Create()
    {
        var command = new Command("api", "Generated endpoint commands.");

                         command.Subcommands.Add(ActorBuildsApiGroupCommand.Create());
                         command.Subcommands.Add(ActorRunsApiGroupCommand.Create());
                         command.Subcommands.Add(ActorTasksApiGroupCommand.Create());
                         command.Subcommands.Add(ActorsApiGroupCommand.Create());
                         command.Subcommands.Add(ActorsActorBuildsApiGroupCommand.Create());
                         command.Subcommands.Add(ActorsActorRunsApiGroupCommand.Create());
                         command.Subcommands.Add(ActorsActorVersionsApiGroupCommand.Create());
                         command.Subcommands.Add(ActorsWebhookCollectionApiGroupCommand.Create());
                         command.Subcommands.Add(DefaultDatasetApiGroupCommand.Create());
                         command.Subcommands.Add(DefaultKeyValueStoreApiGroupCommand.Create());
                         command.Subcommands.Add(DefaultRequestQueueApiGroupCommand.Create());
                         command.Subcommands.Add(LastActorRunSAbortApiGroupCommand.Create());
                         command.Subcommands.Add(LastActorRunSDefaultDatasetApiGroupCommand.Create());
                         command.Subcommands.Add(LastActorRunSDefaultKeyValueStoreApiGroupCommand.Create());
                         command.Subcommands.Add(LastActorRunSDefaultRequestQueueApiGroupCommand.Create());
                         command.Subcommands.Add(LastActorRunSLogApiGroupCommand.Create());
                         command.Subcommands.Add(LastActorRunSMetamorphApiGroupCommand.Create());
                         command.Subcommands.Add(LastActorRunSRebootApiGroupCommand.Create());
                         command.Subcommands.Add(LastActorTaskRunSAbortApiGroupCommand.Create());
                         command.Subcommands.Add(LastActorTaskRunSDefaultDatasetApiGroupCommand.Create());
                         command.Subcommands.Add(LastActorTaskRunSDefaultKeyValueStoreApiGroupCommand.Create());
                         command.Subcommands.Add(LastActorTaskRunSDefaultRequestQueueApiGroupCommand.Create());
                         command.Subcommands.Add(LastActorTaskRunSLogApiGroupCommand.Create());
                         command.Subcommands.Add(LastActorTaskRunSMetamorphApiGroupCommand.Create());
                         command.Subcommands.Add(LastActorTaskRunSRebootApiGroupCommand.Create());
                         command.Subcommands.Add(LogsApiGroupCommand.Create());
                         command.Subcommands.Add(SchedulesApiGroupCommand.Create());
                         command.Subcommands.Add(StorageDatasetsApiGroupCommand.Create());
                         command.Subcommands.Add(StorageKeyValueStoresApiGroupCommand.Create());
                         command.Subcommands.Add(StorageRequestQueuesApiGroupCommand.Create());
                         command.Subcommands.Add(StorageRequestQueuesRequestsApiGroupCommand.Create());
                         command.Subcommands.Add(StorageRequestQueuesRequestsLocksApiGroupCommand.Create());
                         command.Subcommands.Add(StoreApiGroupCommand.Create());
                         command.Subcommands.Add(ToolsApiGroupCommand.Create());
                         command.Subcommands.Add(ToolsEncodingApiGroupCommand.Create());
                         command.Subcommands.Add(UsersApiGroupCommand.Create());
                         command.Subcommands.Add(UsersUsageApiGroupCommand.Create());
                         command.Subcommands.Add(WebhooksWebhookDispatchesApiGroupCommand.Create());
                         command.Subcommands.Add(WebhooksWebhooksApiGroupCommand.Create());
        return command;
    }
}