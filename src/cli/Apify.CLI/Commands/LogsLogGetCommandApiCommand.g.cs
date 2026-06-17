#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Apify.CLI.Commands;

internal static partial class LogsLogGetCommandApiCommand
{
    private static Argument<string> BuildOrRunId { get; } = new(
        name: @"build-or-run-id")
    {
        Description = @"ID of the Actor build or run.",
    };

    private static Option<bool?> Stream { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--stream",
        description: @"If `true` or `1` then the logs will be streamed as long as the run or build is running.
");

    private static Option<bool?> Download { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--download",
        description: @"If `true` or `1` then the web browser will download the log file rather than open it in a tab.
");

    private static Option<bool?> Raw { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--raw",
        description: @"If `true` or `1`, the logs will be kept verbatim. By default, the API removes
ANSI escape codes from the logs, keeping only printable characters.
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
        var command = new Command(@"get", @"Get log
Retrieves logs for a specific Actor build or run.
");
                        command.Arguments.Add(BuildOrRunId);
                        command.Options.Add(Stream);
                        command.Options.Add(Download);
                        command.Options.Add(Raw);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var buildOrRunId = parseResult.GetRequiredValue(BuildOrRunId);
                        var stream = parseResult.GetValue(Stream);
                        var download = parseResult.GetValue(Download);
                        var raw = parseResult.GetValue(Raw);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Logs.LogGetAsync(
                                    buildOrRunId: buildOrRunId,
                                    stream: stream,
                                    download: download,
                                    raw: raw,
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