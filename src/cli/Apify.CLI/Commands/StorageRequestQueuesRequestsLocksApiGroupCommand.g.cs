#nullable enable

using System.CommandLine;

namespace Apify.CLI.Commands;

internal static partial class StorageRequestQueuesRequestsLocksApiGroupCommand
{
    static partial void CustomizeCommand(ref Command command);

    public static Command Create()
    {
        var command = new Command(@"storage-request-queues-requests-locks", @"Storage/Request queues/Requests locks endpoint commands.");
                         command.Subcommands.Add(StorageRequestQueuesRequestsLocksRequestQueueHeadGetCommandApiCommand.Create());
                         command.Subcommands.Add(StorageRequestQueuesRequestsLocksRequestQueueHeadLockPostCommandApiCommand.Create());
                         command.Subcommands.Add(StorageRequestQueuesRequestsLocksRequestQueueRequestLockDeleteCommandApiCommand.Create());
                         command.Subcommands.Add(StorageRequestQueuesRequestsLocksRequestQueueRequestLockPutCommandApiCommand.Create());
                         command.Subcommands.Add(StorageRequestQueuesRequestsLocksRequestQueueRequestsUnlockPostCommandApiCommand.Create());
        CustomizeCommand(ref command);
        return command;
    }
}