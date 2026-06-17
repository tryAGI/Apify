#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Apify.CLI.Commands;

internal static partial class ActorRunsActorRunGetCommandApiCommand
{
    private static Argument<string> RunId { get; } = new(
        name: @"run-id")
    {
        Description = @"Actor run ID.",
    };

    private static Option<double?> WaitForFinish { get; } = new(
        name: @"--wait-for-finish")
    {
        Description = @"The maximum number of seconds the server waits for the run to finish. By
default it is `0`, the maximum value is `60`. <!-- MAX_ACTOR_JOB_ASYNC_WAIT_SECS -->
If the run finishes in time then the returned run object will have a terminal status (e.g. `SUCCEEDED`),
otherwise it will have a transitional status (e.g. `RUNNING`).
",
    };

                    private static string FormatResponse(ParseResult parseResult, global::Apify.RunResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Apify.RunResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"get", @"Get run
This is not a single endpoint, but an entire group of endpoints that lets
you retrieve the run or any of its default storages.

##### Convenience endpoints for Actor run default storages

* [Dataset](/api/v2/default-dataset)

* [Key-value store](/api/v2/default-key-value-store)

* [Request queue](/api/v2/default-request-queue)

Gets an object that contains all the details about a
specific run of an Actor.

By passing the optional `waitForFinish` parameter the API endpoint will synchronously wait
for the run to finish. This is useful to avoid periodic polling when waiting for Actor run to complete.
Note that the first response after completion can still show preliminary `stats`, costs, and event counts.
For stable figures, wait about 10 seconds and call the endpoint again.

This endpoint does not require the authentication token. Instead, calls are authenticated using a hard-to-guess ID of the run. However,
if you access the endpoint without the token, certain attributes, such as `usageUsd` and `usageTotalUsd`, will be hidden.
");
                        command.Arguments.Add(RunId);
                        command.Options.Add(WaitForFinish);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var runId = parseResult.GetRequiredValue(RunId);
                        var waitForFinish = parseResult.GetValue(WaitForFinish);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.ActorRuns.ActorRunGetAsync(
                                    runId: runId,
                                    waitForFinish: waitForFinish,
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