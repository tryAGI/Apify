#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Apify.CLI.Commands;

internal static partial class LastActorRunSDefaultKeyValueStoreActorRunsLastKeyValueStoreKeysGetCommandApiCommand
{
    private static Argument<string> ActorId { get; } = new(
        name: @"actor-id")
    {
        Description = @"Actor ID or the username of the Actor owner and the Actor name, separated by a tilde (`~`).",
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

    private static Option<string?> ExclusiveStartKey { get; } = new(
        name: @"--exclusive-start-key")
    {
        Description = @"All keys up to this one (including) are skipped from the result.",
    };

    private static Option<double?> Limit { get; } = new(
        name: @"--limit")
    {
        Description = @"Number of keys to be returned.",
    };

    private static Option<string?> Collection { get; } = new(
        name: @"--collection")
    {
        Description = @"Limit the results to keys that belong to a specific collection from the key-value store schema. The key-value store need to have a schema defined for this parameter to work.",
    };

    private static Option<string?> Prefix { get; } = new(
        name: @"--prefix")
    {
        Description = @"Limit the results to keys that start with a specific prefix.",
    };

    private static Option<string?> Signature { get; } = new(
        name: @"--signature")
    {
        Description = @"Signature used for the access.",
    };

                    private static string FormatResponse(ParseResult parseResult, global::Apify.ListOfKeysResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Apify.ListOfKeysResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"actor-runs-last-key-value-store-keys-get", @"Get last run's default store's list of keys
Returns a list of keys for the default key-value store of the last Actor run.

This endpoint is a shortcut for getting the last run's `defaultKeyValueStoreId` and then using the
[Get list of keys](/api/v2/key-value-store-keys-get) endpoint.
");
                        command.Arguments.Add(ActorId);
                        command.Options.Add(Status);
                        command.Options.Add(Origin);
                        command.Options.Add(ExclusiveStartKey);
                        command.Options.Add(Limit);
                        command.Options.Add(Collection);
                        command.Options.Add(Prefix);
                        command.Options.Add(Signature);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var actorId = parseResult.GetRequiredValue(ActorId);
                        var status = parseResult.GetValue(Status);
                        var origin = parseResult.GetValue(Origin);
                        var exclusiveStartKey = parseResult.GetValue(ExclusiveStartKey);
                        var limit = parseResult.GetValue(Limit);
                        var collection = parseResult.GetValue(Collection);
                        var prefix = parseResult.GetValue(Prefix);
                        var signature = parseResult.GetValue(Signature);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.LastActorRunSDefaultKeyValueStore.ActorRunsLastKeyValueStoreKeysGetAsync(
                                    actorId: actorId,
                                    status: status,
                                    origin: origin,
                                    exclusiveStartKey: exclusiveStartKey,
                                    limit: limit,
                                    collection: collection,
                                    prefix: prefix,
                                    signature: signature,
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