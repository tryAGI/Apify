#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Apify.CLI.Commands;

internal static partial class ActorBuildsActorBuildLogGetCommandApiCommand
{
    private static Argument<string> BuildId { get; } = new(
        name: @"build-id")
    {
        Description = @"ID of the build, found in the build's Info tab.",
    };

    private static Option<bool?> Stream { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--stream",
        description: @"If `true` or `1` then the logs will be streamed as long as the run or build is running.
");

    private static Option<bool?> Download { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--download",
        description: @"If `true` or `1` then the web browser will download the log file rather than open it in a tab.
");

                    private static string FormatResponse(ParseResult parseResult, string value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, string value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"log-get", @"Get build's Log
Retrieves Actor build's logs.

This endpoint is a shortcut for getting the build's log. Same as [Get log](/api/v2/log-get) endpoint.
");
                        command.Arguments.Add(BuildId);
                        command.Options.Add(Stream);
                        command.Options.Add(Download);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var buildId = parseResult.GetRequiredValue(BuildId);
                        var stream = parseResult.GetValue(Stream);
                        var download = parseResult.GetValue(Download);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.ActorBuilds.ActorBuildLogGetAsync(
                                    buildId: buildId,
                                    stream: stream,
                                    download: download,
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