#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Apify.CLI.Commands;

internal static partial class StorageRequestQueuesRequestsLocksRequestQueueRequestLockDeleteCommandApiCommand
{
    private static Argument<string> QueueId { get; } = new(
        name: @"queue-id")
    {
        Description = @"Queue ID or `username~queue-name`.",
    };

    private static Argument<string> RequestId { get; } = new(
        name: @"request-id")
    {
        Description = @"Request ID.",
    };

    private static Option<string?> ClientKey { get; } = new(
        name: @"--client-key")
    {
        Description = @"A unique identifier of the client accessing the request queue. It must
be a string between 1 and 32 characters long. This identifier is used to
determine whether the queue was accessed by multiple clients. If
`clientKey` is not provided,
the system considers this API call to come from a new client. For
details, see the `hadMultipleClients` field returned by the [Get
head](#/reference/request-queues/queue-head) operation.
",
    };

    private static Option<string?> Forefront { get; } = new(
        name: @"--forefront")
    {
        Description = @"Determines if request should be added to the head of the queue or to the
end after lock was removed.
",
    };

    public static Command Create()
    {
        var command = new Command(@"request-queue-request-lock-delete", @"Delete request lock
Deletes a request lock. The request lock can be deleted only by the client
that has locked it using [Get and lock head
operation](#/request-queue-head-lock-post).

The clientKey identifier is used for locking and unlocking requests.
You can delete or prolong the lock only for requests that were locked by the same client key or from the same Actor run.
");
                        command.Arguments.Add(QueueId);
                        command.Arguments.Add(RequestId);
                        command.Options.Add(ClientKey);
                        command.Options.Add(Forefront);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var queueId = parseResult.GetRequiredValue(QueueId);
                        var requestId = parseResult.GetRequiredValue(RequestId);
                        var clientKey = parseResult.GetValue(ClientKey);
                        var forefront = parseResult.GetValue(Forefront);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                await client.StorageRequestQueuesRequestsLocks.RequestQueueRequestLockDeleteAsync(
                                    queueId: queueId,
                                    requestId: requestId,
                                    clientKey: clientKey,
                                    forefront: forefront,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);

                                await CliRuntime.WriteSuccessAsync(parseResult, cancellationToken).ConfigureAwait(false);
            }, cancellationToken).ConfigureAwait(false));
        return command;
    }
}