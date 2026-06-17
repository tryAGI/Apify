#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Apify.CLI.Commands;

internal static partial class StorageRequestQueuesRequestsLocksRequestQueueRequestsUnlockPostCommandApiCommand
{
    private static Argument<string> QueueId { get; } = new(
        name: @"queue-id")
    {
        Description = @"Queue ID or `username~queue-name`.",
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

                    private static string FormatResponse(ParseResult parseResult, global::Apify.UnlockRequestsResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Apify.UnlockRequestsResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"request-queue-requests-unlock-post", @"Unlock requests
Unlocks requests in the queue that are currently locked by the client.

* If the client is within an Actor run, it unlocks all requests locked by that specific run plus all requests locked by the same clientKey.
* If the client is outside of an Actor run, it unlocks all requests locked using the same clientKey.
");
                        command.Arguments.Add(QueueId);
                        command.Options.Add(ClientKey);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var queueId = parseResult.GetRequiredValue(QueueId);
                        var clientKey = parseResult.GetValue(ClientKey);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.StorageRequestQueuesRequestsLocks.RequestQueueRequestsUnlockPostAsync(
                                    queueId: queueId,
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