#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Apify.CLI.Commands;

internal static partial class StorageKeyValueStoresKeyValueStoreKeysGetCommandApiCommand
{
    private static Argument<string> StoreId { get; } = new(
        name: @"store-id")
    {
        Description = @"Key-value store ID or `username~store-name`.",
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
        var command = new Command(@"key-value-store-keys-get", @"Get list of keys
Returns a list of objects describing keys of a given key-value store, as
well as some information about the values (e.g. size).

This endpoint is paginated using `exclusiveStartKey` and `limit` parameters
- see [Pagination](/api/v2#using-key) for more details.
");
                        command.Arguments.Add(StoreId);
                        command.Options.Add(ExclusiveStartKey);
                        command.Options.Add(Limit);
                        command.Options.Add(Collection);
                        command.Options.Add(Prefix);
                        command.Options.Add(Signature);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var storeId = parseResult.GetRequiredValue(StoreId);
                        var exclusiveStartKey = parseResult.GetValue(ExclusiveStartKey);
                        var limit = parseResult.GetValue(Limit);
                        var collection = parseResult.GetValue(Collection);
                        var prefix = parseResult.GetValue(Prefix);
                        var signature = parseResult.GetValue(Signature);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.StorageKeyValueStores.KeyValueStoreKeysGetAsync(
                                    storeId: storeId,
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