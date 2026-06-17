#nullable enable

using System.CommandLine;

namespace Apify.CLI.Commands;

internal static class LastActorTaskRunSDefaultRequestQueueApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"last-actor-task-run-s-default-request-queue", @"Last Actor task run's default request queue endpoint commands.");
                         command.Subcommands.Add(LastActorTaskRunSDefaultRequestQueueActorTaskRunsLastRequestQueueDeleteCommandApiCommand.Create());
                         command.Subcommands.Add(LastActorTaskRunSDefaultRequestQueueActorTaskRunsLastRequestQueueGetCommandApiCommand.Create());
                         command.Subcommands.Add(LastActorTaskRunSDefaultRequestQueueActorTaskRunsLastRequestQueueHeadGetCommandApiCommand.Create());
                         command.Subcommands.Add(LastActorTaskRunSDefaultRequestQueueActorTaskRunsLastRequestQueueHeadLockPostCommandApiCommand.Create());
                         command.Subcommands.Add(LastActorTaskRunSDefaultRequestQueueActorTaskRunsLastRequestQueuePutCommandApiCommand.Create());
                         command.Subcommands.Add(LastActorTaskRunSDefaultRequestQueueActorTaskRunsLastRequestQueueRequestDeleteCommandApiCommand.Create());
                         command.Subcommands.Add(LastActorTaskRunSDefaultRequestQueueActorTaskRunsLastRequestQueueRequestGetCommandApiCommand.Create());
                         command.Subcommands.Add(LastActorTaskRunSDefaultRequestQueueActorTaskRunsLastRequestQueueRequestLockDeleteCommandApiCommand.Create());
                         command.Subcommands.Add(LastActorTaskRunSDefaultRequestQueueActorTaskRunsLastRequestQueueRequestLockPutCommandApiCommand.Create());
                         command.Subcommands.Add(LastActorTaskRunSDefaultRequestQueueActorTaskRunsLastRequestQueueRequestPutCommandApiCommand.Create());
                         command.Subcommands.Add(LastActorTaskRunSDefaultRequestQueueActorTaskRunsLastRequestQueueRequestsBatchDeleteCommandApiCommand.Create());
                         command.Subcommands.Add(LastActorTaskRunSDefaultRequestQueueActorTaskRunsLastRequestQueueRequestsBatchPostCommandApiCommand.Create());
                         command.Subcommands.Add(LastActorTaskRunSDefaultRequestQueueActorTaskRunsLastRequestQueueRequestsGetCommandApiCommand.Create());
                         command.Subcommands.Add(LastActorTaskRunSDefaultRequestQueueActorTaskRunsLastRequestQueueRequestsPostCommandApiCommand.Create());
                         command.Subcommands.Add(LastActorTaskRunSDefaultRequestQueueActorTaskRunsLastRequestQueueRequestsUnlockPostCommandApiCommand.Create());
        return command;
    }
}