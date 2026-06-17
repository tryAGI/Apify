#nullable enable

using System.CommandLine;

namespace Apify.CLI.Commands;

internal static class DefaultRequestQueueApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"default-request-queue", @"Default request queue endpoint commands.");
                         command.Subcommands.Add(DefaultRequestQueueActorRunRequestQueueDeleteCommandApiCommand.Create());
                         command.Subcommands.Add(DefaultRequestQueueActorRunRequestQueueGetCommandApiCommand.Create());
                         command.Subcommands.Add(DefaultRequestQueueActorRunRequestQueueHeadGetCommandApiCommand.Create());
                         command.Subcommands.Add(DefaultRequestQueueActorRunRequestQueueHeadLockPostCommandApiCommand.Create());
                         command.Subcommands.Add(DefaultRequestQueueActorRunRequestQueuePutCommandApiCommand.Create());
                         command.Subcommands.Add(DefaultRequestQueueActorRunRequestQueueRequestDeleteCommandApiCommand.Create());
                         command.Subcommands.Add(DefaultRequestQueueActorRunRequestQueueRequestGetCommandApiCommand.Create());
                         command.Subcommands.Add(DefaultRequestQueueActorRunRequestQueueRequestLockDeleteCommandApiCommand.Create());
                         command.Subcommands.Add(DefaultRequestQueueActorRunRequestQueueRequestLockPutCommandApiCommand.Create());
                         command.Subcommands.Add(DefaultRequestQueueActorRunRequestQueueRequestPutCommandApiCommand.Create());
                         command.Subcommands.Add(DefaultRequestQueueActorRunRequestQueueRequestsBatchDeleteCommandApiCommand.Create());
                         command.Subcommands.Add(DefaultRequestQueueActorRunRequestQueueRequestsBatchPostCommandApiCommand.Create());
                         command.Subcommands.Add(DefaultRequestQueueActorRunRequestQueueRequestsGetCommandApiCommand.Create());
                         command.Subcommands.Add(DefaultRequestQueueActorRunRequestQueueRequestsPostCommandApiCommand.Create());
                         command.Subcommands.Add(DefaultRequestQueueActorRunRequestQueueRequestsUnlockPostCommandApiCommand.Create());
        return command;
    }
}