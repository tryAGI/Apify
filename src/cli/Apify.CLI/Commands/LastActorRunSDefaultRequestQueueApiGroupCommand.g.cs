#nullable enable

using System.CommandLine;

namespace Apify.CLI.Commands;

internal static class LastActorRunSDefaultRequestQueueApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"last-actor-run-s-default-request-queue", @"Last Actor run's default request queue endpoint commands.");
                         command.Subcommands.Add(LastActorRunSDefaultRequestQueueActRunsLastRequestQueueDeleteCommandApiCommand.Create());
                         command.Subcommands.Add(LastActorRunSDefaultRequestQueueActRunsLastRequestQueueGetCommandApiCommand.Create());
                         command.Subcommands.Add(LastActorRunSDefaultRequestQueueActRunsLastRequestQueueHeadGetCommandApiCommand.Create());
                         command.Subcommands.Add(LastActorRunSDefaultRequestQueueActRunsLastRequestQueueHeadLockPostCommandApiCommand.Create());
                         command.Subcommands.Add(LastActorRunSDefaultRequestQueueActRunsLastRequestQueuePutCommandApiCommand.Create());
                         command.Subcommands.Add(LastActorRunSDefaultRequestQueueActRunsLastRequestQueueRequestDeleteCommandApiCommand.Create());
                         command.Subcommands.Add(LastActorRunSDefaultRequestQueueActRunsLastRequestQueueRequestGetCommandApiCommand.Create());
                         command.Subcommands.Add(LastActorRunSDefaultRequestQueueActRunsLastRequestQueueRequestLockDeleteCommandApiCommand.Create());
                         command.Subcommands.Add(LastActorRunSDefaultRequestQueueActRunsLastRequestQueueRequestLockPutCommandApiCommand.Create());
                         command.Subcommands.Add(LastActorRunSDefaultRequestQueueActRunsLastRequestQueueRequestPutCommandApiCommand.Create());
                         command.Subcommands.Add(LastActorRunSDefaultRequestQueueActRunsLastRequestQueueRequestsBatchDeleteCommandApiCommand.Create());
                         command.Subcommands.Add(LastActorRunSDefaultRequestQueueActRunsLastRequestQueueRequestsBatchPostCommandApiCommand.Create());
                         command.Subcommands.Add(LastActorRunSDefaultRequestQueueActRunsLastRequestQueueRequestsGetCommandApiCommand.Create());
                         command.Subcommands.Add(LastActorRunSDefaultRequestQueueActRunsLastRequestQueueRequestsPostCommandApiCommand.Create());
                         command.Subcommands.Add(LastActorRunSDefaultRequestQueueActRunsLastRequestQueueRequestsUnlockPostCommandApiCommand.Create());
        return command;
    }
}