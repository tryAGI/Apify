#nullable enable

using System.CommandLine;

namespace Apify.CLI.Commands;

internal static class StorageRequestQueuesRequestsLocksApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"storage-request-queues-requests-locks", @"Storage/Request queues/Requests locks endpoint commands.");
                         command.Subcommands.Add(StorageRequestQueuesRequestsLocksRequestQueueHeadGetCommandApiCommand.Create());
                         command.Subcommands.Add(StorageRequestQueuesRequestsLocksRequestQueueHeadLockPostCommandApiCommand.Create());
                         command.Subcommands.Add(StorageRequestQueuesRequestsLocksRequestQueueRequestLockDeleteCommandApiCommand.Create());
                         command.Subcommands.Add(StorageRequestQueuesRequestsLocksRequestQueueRequestLockPutCommandApiCommand.Create());
                         command.Subcommands.Add(StorageRequestQueuesRequestsLocksRequestQueueRequestsUnlockPostCommandApiCommand.Create());
        return command;
    }
}