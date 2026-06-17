#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Apify.CLI.Commands;

internal static partial class ActorBuildsActorBuildGetCommandApiCommand
{
    private static Argument<string> BuildId { get; } = new(
        name: @"build-id")
    {
        Description = @"ID of the build, found in the build's Info tab.",
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
        var command = new Command(@"get", @"Get build
Gets an object that contains all the details about a specific build of an
Actor.

By passing the optional `waitForFinish` parameter the API endpoint will
synchronously wait for the build to finish. This is useful to avoid periodic
polling when waiting for an Actor build to finish.

This endpoint does not require the authentication token. Instead, calls are authenticated using a hard-to-guess ID of the build. However,
if you access the endpoint without the token, certain attributes, such as `usageUsd` and `usageTotalUsd`, will be hidden.
");
                        command.Arguments.Add(BuildId);
                        command.Options.Add(WaitForFinish);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var buildId = parseResult.GetRequiredValue(BuildId);
                        var waitForFinish = parseResult.GetValue(WaitForFinish);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.ActorBuilds.ActorBuildGetAsync(
                                    buildId: buildId,
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