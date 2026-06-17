#nullable enable

using System.CommandLine;

namespace Apify.CLI.Commands;

internal static class StorageRequestQueuesApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"storage-request-queues", @"Storage/Request queues endpoint commands.");
                         command.Subcommands.Add(StorageRequestQueuesRequestQueueDeleteCommandApiCommand.Create());
                         command.Subcommands.Add(StorageRequestQueuesRequestQueueGetCommandApiCommand.Create());
                         command.Subcommands.Add(StorageRequestQueuesRequestQueuePutCommandApiCommand.Create());
                         command.Subcommands.Add(StorageRequestQueuesRequestQueueRequestsBatchDeleteCommandApiCommand.Create());
                         command.Subcommands.Add(StorageRequestQueuesRequestQueueRequestsBatchPostCommandApiCommand.Create());
                         command.Subcommands.Add(StorageRequestQueuesRequestQueuesGetCommandApiCommand.Create());
                         command.Subcommands.Add(StorageRequestQueuesRequestQueuesPostCommandApiCommand.Create());
        return command;
    }
}