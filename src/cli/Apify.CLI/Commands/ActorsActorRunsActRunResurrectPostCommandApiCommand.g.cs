#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Apify.CLI.Commands;

internal static partial class ActorsActorRunsActRunResurrectPostCommandApiCommand
{
    private static Argument<string> ActorId { get; } = new(
        name: @"actor-id")
    {
        Description = @"Actor ID or a tilde-separated owner's username and Actor name.",
    };

    private static Argument<string> RunId { get; } = new(
        name: @"run-id")
    {
        Description = @"Actor run ID.",
    };

    private static Option<string?> Build { get; } = new(
        name: @"--build")
    {
        Description = @"Specifies the Actor build to run. It can be either a build tag or build number.
By default, the run is resurrected with the same build it originally used. Specifically,
if a run was first started with the `latest` tag, which resolves to version `0.0.3` at the
time, a run resurrected without this parameter will continue running with `0.0.3`, even if
`latest` already points to a newer build.
",
    };

    private static Option<double?> Timeout { get; } = new(
        name: @"--timeout")
    {
        Description = @"Optional timeout for the run, in seconds. By default, the run uses the timeout
specified in the run that is being resurrected.
",
    };

    private static Option<double?> Memory { get; } = new(
        name: @"--memory")
    {
        Description = @"Memory limit for the run, in megabytes. The amount of memory can be set to a power of 2
with a minimum of 128. By default, the run uses the memory limit specified in the run
that is being resurrected.
",
    };

    private static Option<bool?> RestartOnError { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--restart-on-error",
        description: @"Determines whether the resurrected run will be restarted if it fails.
By default, the resurrected run uses the same setting as before.
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
        var command = new Command(@"act-run-resurrect-post", @"Resurrect run
**[DEPRECATED]** API endpoints related to run of the Actor were moved under
new namespace [`actor-runs`](#/reference/actor-runs).Resurrects a finished
Actor run and returns an object that contains all the details about the
resurrected run.

Only finished runs, i.e. runs with status `FINISHED`, `FAILED`, `ABORTED`
and `TIMED-OUT` can be resurrected.
Run status will be updated to RUNNING and its container will be restarted
with the same storages
(the same behaviour as when the run gets migrated to the new server).

For more information, see the [Actor
docs](https://docs.apify.com/platform/actors/running/runs-and-builds#resurrection-of-finished-run).
");
                        command.Arguments.Add(ActorId);
                        command.Arguments.Add(RunId);
                        command.Options.Add(Build);
                        command.Options.Add(Timeout);
                        command.Options.Add(Memory);
                        command.Options.Add(RestartOnError);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var actorId = parseResult.GetRequiredValue(ActorId);
                        var runId = parseResult.GetRequiredValue(RunId);
                        var build = parseResult.GetValue(Build);
                        var timeout = parseResult.GetValue(Timeout);
                        var memory = parseResult.GetValue(Memory);
                        var restartOnError = parseResult.GetValue(RestartOnError);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.ActorsActorRuns.ActRunResurrectPostAsync(
                                    actorId: actorId,
                                    runId: runId,
                                    build: build,
                                    timeout: timeout,
                                    memory: memory,
                                    restartOnError: restartOnError,
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