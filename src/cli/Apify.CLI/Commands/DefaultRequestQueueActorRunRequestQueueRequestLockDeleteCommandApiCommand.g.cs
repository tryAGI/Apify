#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Apify.CLI.Commands;

internal static partial class DefaultRequestQueueActorRunRequestQueueRequestLockDeleteCommandApiCommand
{
    private static Argument<string> RunId { get; } = new(
        name: @"run-id")
    {
        Description = @"Actor run ID.",
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
        var command = new Command(@"actor-run-request-queue-request-lock-delete", @"Delete lock on request in default request queue
Deletes a request lock in the default request queue of the Actor run.

This endpoint is a shortcut for getting the run's `defaultRequestQueueId` and then using the
[Delete request lock](/api/v2/request-queue-request-lock-delete) endpoint.
");
                        command.Arguments.Add(RunId);
                        command.Arguments.Add(RequestId);
                        command.Options.Add(ClientKey);
                        command.Options.Add(Forefront);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var runId = parseResult.GetRequiredValue(RunId);
                        var requestId = parseResult.GetRequiredValue(RequestId);
                        var clientKey = parseResult.GetValue(ClientKey);
                        var forefront = parseResult.GetValue(Forefront);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                await client.DefaultRequestQueue.ActorRunRequestQueueRequestLockDeleteAsync(
                                    runId: runId,
                                    requestId: requestId,
                                    clientKey: clientKey,
                                    forefront: forefront,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);

                                await CliRuntime.WriteSuccessAsync(parseResult, cancellationToken).ConfigureAwait(false);
            }, cancellationToken).ConfigureAwait(false));
        return command;
    }
}