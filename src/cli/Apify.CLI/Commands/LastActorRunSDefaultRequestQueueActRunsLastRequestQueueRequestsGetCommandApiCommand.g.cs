#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Apify.CLI.Commands;

internal static partial class LastActorRunSDefaultRequestQueueActRunsLastRequestQueueRequestsGetCommandApiCommand
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

    private static Option<string?> ExclusiveStartId { get; } = new(
        name: @"--exclusive-start-id")
    {
        Description = @"All requests up to this one (including) are skipped from the result. (Deprecated, use `cursor` instead.)",
    };

    private static Option<double?> Limit { get; } = new(
        name: @"--limit")
    {
        Description = @"Number of keys to be returned. Maximum value is `10000`.",
    };

    private static Option<string?> Cursor { get; } = new(
        name: @"--cursor")
    {
        Description = @"A cursor string for pagination, returned in the previous response as `nextCursor`. Use this to retrieve the next page of requests.",
    };

    private static Option<global::System.Collections.Generic.IList<global::Apify.ActRunsLastRequestQueueRequestsGetFilterItem>?> Filter { get; } = new(
        name: @"--filter")
    {
        Description = @"Filter requests by their state. Possible values are `locked` and `pending`. You can combine multiple values separated by commas, which will mean the union of these filters – requests matching any of the specified states will be returned. (Not compatible with deprecated `exclusiveStartId` parameter.)",
    };

                    private static string FormatResponse(ParseResult parseResult, global::Apify.ListOfRequestsResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Apify.ListOfRequestsResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"act-runs-last-request-queue-requests-get", @"List last run's default request queue's requests
Returns a list of requests from the default request queue of the last Actor run.

This endpoint is a shortcut for getting the last run's `defaultRequestQueueId` and then using the
[List requests](/api/v2/request-queue-requests-get) endpoint.
");
                        command.Arguments.Add(ActorId);
                        command.Options.Add(Status);
                        command.Options.Add(ClientKey);
                        command.Options.Add(ExclusiveStartId);
                        command.Options.Add(Limit);
                        command.Options.Add(Cursor);
                        command.Options.Add(Filter);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var actorId = parseResult.GetRequiredValue(ActorId);
                        var status = parseResult.GetValue(Status);
                        var clientKey = parseResult.GetValue(ClientKey);
                        var exclusiveStartId = parseResult.GetValue(ExclusiveStartId);
                        var limit = parseResult.GetValue(Limit);
                        var cursor = parseResult.GetValue(Cursor);
                        var filter = parseResult.GetValue(Filter);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.LastActorRunSDefaultRequestQueue.ActRunsLastRequestQueueRequestsGetAsync(
                                    actorId: actorId,
                                    status: status,
                                    clientKey: clientKey,
                                    exclusiveStartId: exclusiveStartId,
                                    limit: limit,
                                    cursor: cursor,
                                    filter: filter,
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