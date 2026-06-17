#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Apify.CLI.Commands;

internal static partial class ActorRunsActorRunMetamorphPostCommandApiCommand
{
    private static Argument<string> RunId { get; } = new(
        name: @"run-id")
    {
        Description = @"Actor run ID.",
    };

    private static Option<string> TargetActorId { get; } = new(
        name: @"--target-actor-id")
    {
        Description = @"ID of a target Actor that the run should be transformed into.",
        Required = true,
    };

    private static Option<string?> Build { get; } = new(
        name: @"--build")
    {
        Description = @"Optional build of the target Actor.

It can be either a build tag or build number. By default, the run uses
the build specified in the default run configuration for the target
Actor (typically `latest`).
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
        var command = new Command(@"metamorph-post", @"Metamorph run
Transforms an Actor run into a run of another Actor with a new input.

This is useful if you want to use another Actor to finish the work
of your current Actor run, without the need to create a completely new run
and waiting for its finish.

For the users of your Actors, the metamorph operation is transparent, they
will just see your Actor got the work done.

Internally, the system stops the Docker container corresponding to the Actor
run and starts a new container using a different Docker image.

All the default storages are preserved and the new input is stored under the
`INPUT-METAMORPH-1` key in the same default key-value store.

For more information, see the [Actor docs](https://docs.apify.com/platform/actors/development/programming-interface/metamorph).
");
                        command.Arguments.Add(RunId);
                        command.Options.Add(TargetActorId);
                        command.Options.Add(Build);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var runId = parseResult.GetRequiredValue(RunId);
                        var targetActorId = parseResult.GetRequiredValue(TargetActorId);
                        var build = parseResult.GetValue(Build);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.ActorRuns.ActorRunMetamorphPostAsync(
                                    runId: runId,
                                    targetActorId: targetActorId,
                                    build: build,
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