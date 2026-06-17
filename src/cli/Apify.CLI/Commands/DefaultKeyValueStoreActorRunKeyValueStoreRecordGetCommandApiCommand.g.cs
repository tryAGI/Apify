#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Apify.CLI.Commands;

internal static partial class DefaultKeyValueStoreActorRunKeyValueStoreRecordGetCommandApiCommand
{
    private static Argument<string> RunId { get; } = new(
        name: @"run-id")
    {
        Description = @"Actor run ID.",
    };

    private static Argument<string> RecordKey { get; } = new(
        name: @"record-key")
    {
        Description = @"Key of the record.",
    };

    private static Option<string?> Signature { get; } = new(
        name: @"--signature")
    {
        Description = @"Signature used for the access.",
    };

    private static Option<bool?> Attachment { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--attachment",
        description: @"If `true` or `1`, the response will be served with `Content-Disposition: attachment` header,
causing web browsers to offer downloading HTML records instead of displaying them.
");

                    private static string FormatResponse(ParseResult parseResult, global::Apify.RecordResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Apify.RecordResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"actor-run-key-value-store-record-get", @"Get default store's record
Gets a value stored under a specific key in the default key-value store of the Actor run.

This endpoint is a shortcut for getting the run's `defaultKeyValueStoreId` and then using the
[Get record](/api/v2/key-value-store-record-get) endpoint.
");
                        command.Arguments.Add(RunId);
                        command.Arguments.Add(RecordKey);
                        command.Options.Add(Signature);
                        command.Options.Add(Attachment);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var runId = parseResult.GetRequiredValue(RunId);
                        var recordKey = parseResult.GetRequiredValue(RecordKey);
                        var signature = parseResult.GetValue(Signature);
                        var attachment = parseResult.GetValue(Attachment);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.DefaultKeyValueStore.ActorRunKeyValueStoreRecordGetAsync(
                                    runId: runId,
                                    recordKey: recordKey,
                                    signature: signature,
                                    attachment: attachment,
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