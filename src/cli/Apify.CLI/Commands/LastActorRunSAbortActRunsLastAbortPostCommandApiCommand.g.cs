#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Apify.CLI.Commands;

internal static partial class LastActorRunSAbortActRunsLastAbortPostCommandApiCommand
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
        var command = new Command(@"act-runs-last-abort-post", @"Abort Actor's last run
Aborts the last run of the specified Actor and returns an object that
contains all the details about the run.

This endpoint is a shortcut for [Abort run](#/reference/actor-runs/abort-run/abort-run)
on the Actor's last run. Only runs that are starting or running are aborted.
For runs with status `FINISHED`, `FAILED`, `ABORTING` and `TIMED-OUT` this call
does nothing.
");
                        command.Arguments.Add(ActorId);
                        command.Options.Add(Status);
                        command.Options.Add(Gracefully);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var actorId = parseResult.GetRequiredValue(ActorId);
                        var status = parseResult.GetValue(Status);
                        var gracefully = parseResult.GetValue(Gracefully);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.LastActorRunSAbort.ActRunsLastAbortPostAsync(
                                    actorId: actorId,
                                    status: status,
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