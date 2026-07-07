#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Apify.CLI.Commands;

internal static partial class ActorRunsPostChargeRunCommandApiCommand
{
    private static Argument<string> RunId { get; } = new(
        name: @"run-id")
    {
        Description = @"Actor run ID.",
    };

    private static Option<string?> IdempotencyKey { get; } = new(
        name: @"--idempotency-key")
    {
        Description = @"Always pass a unique idempotency key (any unique string) for each charge to avoid double charging in case of retries or network errors.",
    };

    private static Option<string> EventName { get; } = new(
        name: @"--event-name")
    {
        Description = @"",
        Required = true,
    };

    private static Option<int> Count { get; } = new(
        name: @"--count")
    {
        Description = @"",
        Required = true,
    };

                    private static string FormatResponse(ParseResult parseResult, global::Apify.PostChargeRunResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Apify.PostChargeRunResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"post-charge-run", @"Charge events in run
Charge for events in the run of your [pay per event Actor](https://docs.apify.com/platform/actors/running/actors-in-store#pay-per-event).
The event you are charging for must be one of the configured events in your Actor. If the Actor is not set up as pay per event, or if the event is not configured,
the endpoint will return an error. The endpoint must be called from the Actor run itself, with the same API token that the run was started with.

:::info Learn more about pay-per-event pricing

For more details about pay-per-event (PPE) pricing, refer to our [PPE documentation](/actors/publishing/monetize/pay-per-event).

:::
");
                        command.Arguments.Add(RunId);
                        command.Options.Add(IdempotencyKey);
                        command.Options.Add(EventName);
                        command.Options.Add(Count);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var runId = parseResult.GetRequiredValue(RunId);
                        var idempotencyKey = parseResult.GetValue(IdempotencyKey);
                        var eventName = parseResult.GetRequiredValue(EventName);
                        var count = parseResult.GetRequiredValue(Count);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.ActorRuns.PostChargeRunAsync(
                                    runId: runId,
                                    idempotencyKey: idempotencyKey,
                                    eventName: eventName,
                                    count: count,
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