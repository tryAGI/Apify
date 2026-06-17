#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Apify.CLI.Commands;

internal static partial class ActorsActorBuildsActBuildDefaultGetCommandApiCommand
{
    private static Argument<string> ActorId { get; } = new(
        name: @"actor-id")
    {
        Description = @"Actor ID or a tilde-separated owner's username and Actor name.",
    };

    private static Option<double?> WaitForFinish { get; } = new(
        name: @"--wait-for-finish")
    {
        Description = @"The maximum number of seconds the server waits for the build to finish.
By default it is `0`, the maximum value is `60`. <!-- MAX_ACTOR_JOB_ASYNC_WAIT_SECS -->
If the build finishes in time then the returned build object will have a
terminal status (e.g. `SUCCEEDED`), otherwise it will have a transitional status (e.g. `RUNNING`).
",
    };

                    private static string FormatResponse(ParseResult parseResult, global::Apify.BuildResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Apify.BuildResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"act-build-default-get", @"Get default build
Get the default build for an Actor.

Use the optional `waitForFinish` parameter to synchronously wait for the build to finish.
This avoids the need for periodic polling when waiting for the build to complete.

This endpoint does not require an authentication token. Instead, calls are authenticated using the Actor's unique ID.
However, if you access the endpoint without a token, certain attributes (e.g., `usageUsd` and `usageTotalUsd`) will be hidden.
");
                        command.Arguments.Add(ActorId);
                        command.Options.Add(WaitForFinish);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var actorId = parseResult.GetRequiredValue(ActorId);
                        var waitForFinish = parseResult.GetValue(WaitForFinish);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.ActorsActorBuilds.ActBuildDefaultGetAsync(
                                    actorId: actorId,
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