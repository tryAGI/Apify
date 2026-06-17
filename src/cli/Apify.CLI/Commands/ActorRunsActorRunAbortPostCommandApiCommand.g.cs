#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Apify.CLI.Commands;

internal static partial class ActorRunsActorRunAbortPostCommandApiCommand
{
    private static Argument<string> RunId { get; } = new(
        name: @"run-id")
    {
        Description = @"Actor run ID.",
    };

    private static Option<bool?> Gracefully { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--gracefully",
        description: @"If true passed, the Actor run will abort gracefully.
It will send `aborting` and `persistState` event into run and force-stop the run after 30 seconds.
It is helpful in cases where you plan to resurrect the run later.
");

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
        var command = new Command(@"abort-post", @"Abort run
Aborts an Actor run and returns an object that contains all the details
about the run.

Only runs that are starting or running are aborted. For runs with status
`FINISHED`, `FAILED`, `ABORTING` and `TIMED-OUT` this call does nothing.
");
                        command.Arguments.Add(RunId);
                        command.Options.Add(Gracefully);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var runId = parseResult.GetRequiredValue(RunId);
                        var gracefully = parseResult.GetValue(Gracefully);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.ActorRuns.ActorRunAbortPostAsync(
                                    runId: runId,
                                    gracefully: gracefully,
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