#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Apify.CLI.Commands;

internal static partial class StorageRequestQueuesRequestsLocksRequestQueueHeadLockPostCommandApiCommand
{
    private static Argument<string> QueueId { get; } = new(
        name: @"queue-id")
    {
        Description = @"Queue ID or `username~queue-name`.",
    };

    private static Option<double> LockSecs { get; } = new(
        name: @"--lock-secs")
    {
        Description = @"How long the requests will be locked for (in seconds).",
        Required = true,
    };

    private static Option<double?> Limit { get; } = new(
        name: @"--limit")
    {
        Description = @"How many items from the queue should be returned.",
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

                    private static string FormatResponse(ParseResult parseResult, global::Apify.HeadAndLockResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Apify.HeadAndLockResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"request-queue-head-lock-post", @"Get head and lock
Returns the given number of first requests from the queue and locks them for
the given time.

If this endpoint locks the request, no other client or run will be able to get and
lock these requests.

The response contains the `hadMultipleClients` boolean field which indicates
that the queue was accessed by more than one client (with unique or empty
`clientKey`).
");
                        command.Arguments.Add(QueueId);
                        command.Options.Add(LockSecs);
                        command.Options.Add(Limit);
                        command.Options.Add(ClientKey);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var queueId = parseResult.GetRequiredValue(QueueId);
                        var lockSecs = parseResult.GetRequiredValue(LockSecs);
                        var limit = parseResult.GetValue(Limit);
                        var clientKey = parseResult.GetValue(ClientKey);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.StorageRequestQueuesRequestsLocks.RequestQueueHeadLockPostAsync(
                                    queueId: queueId,
                                    lockSecs: lockSecs,
                                    limit: limit,
                                    clientKey: clientKey,
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