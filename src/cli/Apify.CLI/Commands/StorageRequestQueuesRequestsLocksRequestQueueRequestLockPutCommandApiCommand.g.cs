#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Apify.CLI.Commands;

internal static partial class StorageRequestQueuesRequestsLocksRequestQueueRequestLockPutCommandApiCommand
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

    private static Option<double> LockSecs { get; } = new(
        name: @"--lock-secs")
    {
        Description = @"How long the requests will be locked for (in seconds).",
        Required = true,
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
end after lock expires.
",
    };

                    private static string FormatResponse(ParseResult parseResult, global::Apify.ProlongRequestLockResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
                    {
                        string? text = null;
                        CustomizeResponseText(parseResult, value, ref text);
                        if (!string.IsNullOrWhiteSpace(text))
                        {
                            return text;
                        }

                        var hints = new Dictionary<string, CliFormatHint>(StringComparer.OrdinalIgnoreCase)
                        {
                        };
                        CustomizeResponseFormatHints(hints);
                        return CliRuntime.FormatHumanReadable(value, context, truncateLongStrings, hints);
                    }

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Apify.ProlongRequestLockResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"request-queue-request-lock-put", @"Prolong request lock
Prolongs request lock. The request lock can be prolonged only by the client
that has locked it using [Get and lock head
operation](#/request-queue-head-lock-post).

The clientKey identifier is used for locking and unlocking requests.
You can delete or prolong the lock only for requests that were locked by the same client key or from the same Actor run.
");
                        command.Arguments.Add(QueueId);
                        command.Arguments.Add(RequestId);
                        command.Options.Add(LockSecs);
                        command.Options.Add(ClientKey);
                        command.Options.Add(Forefront);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var queueId = parseResult.GetRequiredValue(QueueId);
                        var requestId = parseResult.GetRequiredValue(RequestId);
                        var lockSecs = parseResult.GetRequiredValue(LockSecs);
                        var clientKey = parseResult.GetValue(ClientKey);
                        var forefront = parseResult.GetValue(Forefront);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.StorageRequestQueuesRequestsLocks.RequestQueueRequestLockPutAsync(
                                    queueId: queueId,
                                    requestId: requestId,
                                    lockSecs: lockSecs,
                                    clientKey: clientKey,
                                    forefront: forefront,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);


                                await CliRuntime.WriteResponseAsync(
                                    parseResult,
                                    response,
                                    global::Apify.SourceGenerationContext.Default,
                                    FormatResponse,
                                    cancellationToken).ConfigureAwait(false);
            }, cancellationToken).ConfigureAwait(false));
        return command;
    }
}