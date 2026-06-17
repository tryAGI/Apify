#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Apify.CLI.Commands;

internal static partial class ToolsToolsBrowserInfoDeleteCommandApiCommand
{
    private static Option<bool?> SkipHeaders { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--skip-headers",
        description: @"If `true` or `1`, the response omits the `headers` field.");

    private static Option<bool?> RawHeaders { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--raw-headers",
        description: @"If `true` or `1`, the response includes the `rawHeaders` field with the raw request headers.");

                    private static string FormatResponse(ParseResult parseResult, global::Apify.BrowserInfoResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Apify.BrowserInfoResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"browser-info-delete", @"Get browser info
Returns information about the HTTP request, including the client IP address,
country code, request headers, and body length.

This endpoint is designed for proxy testing. It accepts any HTTP method so you
can verify that your proxy correctly forwards requests of any type and that
client IP addresses are anonymized.
");
                        command.Options.Add(SkipHeaders);
                        command.Options.Add(RawHeaders);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var skipHeaders = parseResult.GetValue(SkipHeaders);
                        var rawHeaders = parseResult.GetValue(RawHeaders);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Tools.ToolsBrowserInfoDeleteAsync(
                                    skipHeaders: skipHeaders,
                                    rawHeaders: rawHeaders,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);


                                if (!await CliRuntime.TryWriteOutputDirectoryAsync(
                                        parseResult,
                                        response,
                                        global::Apify.SourceGenerationContext.Default,
                                        @"RawHeaders",
                                        cancellationToken).ConfigureAwait(false))
                                {
                                await CliRuntime.WriteResponseAsync(
                                    parseResult,
                                    response,
                                    global::Apify.SourceGenerationContext.Default,
                                    FormatResponse,
                                    cancellationToken).ConfigureAwait(false);
                                }
            }, cancellationToken).ConfigureAwait(false));
        return command;
    }
}