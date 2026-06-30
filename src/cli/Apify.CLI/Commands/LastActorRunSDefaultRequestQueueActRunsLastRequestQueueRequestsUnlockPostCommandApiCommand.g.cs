#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Apify.CLI.Commands;

internal static partial class LastActorRunSDefaultRequestQueueActRunsLastRequestQueueRequestsUnlockPostCommandApiCommand
{
    private static Argument<string> ActorId { get; } = new(
        name: @"actor-id")
    {
        Description = @"Actor ID or a tilde-separated owner's username and Actor name.",
    };

    private static Option<string?> Status { get; } = new(
        name: @"--status")
    {
        Description = @"Filter for the run status.",
    };

    private static Option<global::Apify.RunOrigin?> Origin { get; } = new(
        name: @"--origin")
    {
        Description = @"Filter for the run origin, i.e. the means by which the run was started.",
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
        var command = new Command(@"act-runs-last-request-queue-requests-unlock-post", @"Unlock requests in last run's default request queue
Unlocks requests in the default request queue of the last Actor run that are currently locked by the client.

This endpoint is a shortcut for getting the last run's `defaultRequestQueueId` and then using the
[Unlock requests](/api/v2/request-queue-requests-unlock-post) endpoint.
");
                        command.Arguments.Add(ActorId);
                        command.Options.Add(Status);
                        command.Options.Add(Origin);
                        command.Options.Add(ClientKey);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var actorId = parseResult.GetRequiredValue(ActorId);
                        var status = parseResult.GetValue(Status);
                        var origin = parseResult.GetValue(Origin);
                        var clientKey = parseResult.GetValue(ClientKey);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.LastActorRunSDefaultRequestQueue.ActRunsLastRequestQueueRequestsUnlockPostAsync(
                                    actorId: actorId,
                                    status: status,
                                    origin: origin,
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