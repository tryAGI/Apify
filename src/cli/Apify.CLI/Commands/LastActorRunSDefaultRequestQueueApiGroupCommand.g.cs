#nullable enable

using System.CommandLine;

namespace Apify.CLI.Commands;

internal static class LastActorRunSDefaultRequestQueueApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"last-actor-run-s-default-request-queue", @"Last Actor run's default request queue endpoint commands.");
                         command.Subcommands.Add(LastActorRunSDefaultRequestQueueActorRunsLastRequestQueueDeleteCommandApiCommand.Create());
                         command.Subcommands.Add(LastActorRunSDefaultRequestQueueActorRunsLastRequestQueueGetCommandApiCommand.Create());
                         command.Subcommands.Add(LastActorRunSDefaultRequestQueueActorRunsLastRequestQueueHeadGetCommandApiCommand.Create());
                         command.Subcommands.Add(LastActorRunSDefaultRequestQueueActorRunsLastRequestQueueHeadLockPostCommandApiCommand.Create());
                         command.Subcommands.Add(LastActorRunSDefaultRequestQueueActorRunsLastRequestQueuePutCommandApiCommand.Create());
                         command.Subcommands.Add(LastActorRunSDefaultRequestQueueActorRunsLastRequestQueueRequestDeleteCommandApiCommand.Create());
                         command.Subcommands.Add(LastActorRunSDefaultRequestQueueActorRunsLastRequestQueueRequestGetCommandApiCommand.Create());
                         command.Subcommands.Add(LastActorRunSDefaultRequestQueueActorRunsLastRequestQueueRequestLockDeleteCommandApiCommand.Create());
                         command.Subcommands.Add(LastActorRunSDefaultRequestQueueActorRunsLastRequestQueueRequestLockPutCommandApiCommand.Create());
                         command.Subcommands.Add(LastActorRunSDefaultRequestQueueActorRunsLastRequestQueueRequestPutCommandApiCommand.Create());
                         command.Subcommands.Add(LastActorRunSDefaultRequestQueueActorRunsLastRequestQueueRequestsBatchDeleteCommandApiCommand.Create());
                         command.Subcommands.Add(LastActorRunSDefaultRequestQueueActorRunsLastRequestQueueRequestsBatchPostCommandApiCommand.Create());
                         command.Subcommands.Add(LastActorRunSDefaultRequestQueueActorRunsLastRequestQueueRequestsGetCommandApiCommand.Create());
                         command.Subcommands.Add(LastActorRunSDefaultRequestQueueActorRunsLastRequestQueueRequestsPostCommandApiCommand.Create());
                         command.Subcommands.Add(LastActorRunSDefaultRequestQueueActorRunsLastRequestQueueRequestsUnlockPostCommandApiCommand.Create());
        return command;
    }
}