#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Apify.CLI.Commands;

internal static partial class DefaultRequestQueueActorRunRequestQueueRequestGetCommandApiCommand
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

                    private static string FormatResponse(ParseResult parseResult, global::Apify.RequestResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Apify.RequestResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"actor-run-request-queue-request-get", @"Get request from default request queue
Returns a request from the default request queue of the Actor run.

This endpoint is a shortcut for getting the run's `defaultRequestQueueId` and then using the
[Get request](/api/v2/request-queue-request-get) endpoint.
");
                        command.Arguments.Add(RunId);
                        command.Arguments.Add(RequestId);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var runId = parseResult.GetRequiredValue(RunId);
                        var requestId = parseResult.GetRequiredValue(RequestId);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.DefaultRequestQueue.ActorRunRequestQueueRequestGetAsync(
                                    runId: runId,
                                    requestId: requestId,
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