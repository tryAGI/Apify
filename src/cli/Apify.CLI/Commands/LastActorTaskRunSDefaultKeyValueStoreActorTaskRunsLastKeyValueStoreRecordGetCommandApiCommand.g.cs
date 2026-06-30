#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Apify.CLI.Commands;

internal static partial class LastActorTaskRunSDefaultKeyValueStoreActorTaskRunsLastKeyValueStoreRecordGetCommandApiCommand
{
    private static Argument<string> ActorTaskId { get; } = new(
        name: @"actor-task-id")
    {
        Description = @"Task ID or a tilde-separated owner's username and task's name.",
    };

    private static Argument<string> RecordKey { get; } = new(
        name: @"record-key")
    {
        Description = @"Key of the record.",
    };

    private static Option<string?> Status { get; } = new(
        name: @"--status")
    {
        Description = @"Filter for the run status.",
    };

    private static Option<global::Apify.RunOrigin?> Origin { get; } = new(
        name: @"--origin")
    {
        Description = @"Filter for the run origin, i.e. the means by which the run was started.",
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
        var command = new Command(@"actor-task-runs-last-key-value-store-record-get", @"Get last task run's default store's record
Gets a value stored under a specific key in the default key-value store of the last Actor task run.

This endpoint is a shortcut for getting the last task run's `defaultKeyValueStoreId` and then using the
[Get record](/api/v2/key-value-store-record-get) endpoint.
");
                        command.Arguments.Add(ActorTaskId);
                        command.Arguments.Add(RecordKey);
                        command.Options.Add(Status);
                        command.Options.Add(Origin);
                        command.Options.Add(Signature);
                        command.Options.Add(Attachment);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var actorTaskId = parseResult.GetRequiredValue(ActorTaskId);
                        var recordKey = parseResult.GetRequiredValue(RecordKey);
                        var status = parseResult.GetValue(Status);
                        var origin = parseResult.GetValue(Origin);
                        var signature = parseResult.GetValue(Signature);
                        var attachment = parseResult.GetValue(Attachment);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.LastActorTaskRunSDefaultKeyValueStore.ActorTaskRunsLastKeyValueStoreRecordGetAsync(
                                    actorTaskId: actorTaskId,
                                    recordKey: recordKey,
                                    status: status,
                                    origin: origin,
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