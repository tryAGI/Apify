#nullable enable

using System.CommandLine;

namespace Apify.CLI.Commands;

internal static class StorageRequestQueuesRequestsApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"storage-request-queues-requests", @"Storage/Request queues/Requests endpoint commands.");
                         command.Subcommands.Add(StorageRequestQueuesRequestsRequestQueueRequestDeleteCommandApiCommand.Create());
                         command.Subcommands.Add(StorageRequestQueuesRequestsRequestQueueRequestGetCommandApiCommand.Create());
                         command.Subcommands.Add(StorageRequestQueuesRequestsRequestQueueRequestPutCommandApiCommand.Create());
                         command.Subcommands.Add(StorageRequestQueuesRequestsRequestQueueRequestsGetCommandApiCommand.Create());
                         command.Subcommands.Add(StorageRequestQueuesRequestsRequestQueueRequestsPostCommandApiCommand.Create());
        return command;
    }
}