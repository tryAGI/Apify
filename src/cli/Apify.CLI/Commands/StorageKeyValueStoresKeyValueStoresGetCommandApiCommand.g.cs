#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Apify.CLI.Commands;

internal static partial class StorageKeyValueStoresKeyValueStoresGetCommandApiCommand
{
    private static Option<double?> Offset { get; } = new(
        name: @"--offset")
    {
        Description = @"Number of items that should be skipped at the start. The default value is `0`.
",
    };

    private static Option<double?> Limit { get; } = new(
        name: @"--limit")
    {
        Description = @"Maximum number of items to return. The default value as well as the maximum is `1000`.
",
    };

    private static Option<bool?> Desc { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--desc",
        description: @"If `true` or `1` then the objects are sorted by the `createdAt` field in
descending order. By default, they are sorted in ascending order.
");

    private static Option<bool?> Unnamed { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--unnamed",
        description: @"If `true` or `1` then all the storages are returned. By default, only
named storages are returned.
");

    private static Option<global::Apify.StorageOwnership?> Ownership { get; } = new(
        name: @"--ownership")
    {
        Description = @"Filter by ownership. If this parameter is omitted, all accessible key-value stores are returned.

- `ownedByMe`: Return only key-value stores owned by the user.
- `sharedWithMe`: Return only key-value stores shared with the user by other users.
",
    };

                    private static string FormatResponse(ParseResult parseResult, global::Apify.ListOfKeyValueStoresResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Apify.ListOfKeyValueStoresResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"key-value-stores-get", @"Get list of key-value stores
Gets the list of key-value stores owned by the user.

The response is a list of objects, where each objects contains a basic
information about a single key-value store.

The endpoint supports pagination using the `limit` and `offset` parameters
and it will not return more than 1000 array elements.

By default, the records are sorted by the `createdAt` field in ascending
order, therefore you can use pagination to incrementally fetch all key-value stores
while new ones are still being created. To sort the records in descending order, use
the `desc=1` parameter.
");
                        command.Options.Add(Offset);
                        command.Options.Add(Limit);
                        command.Options.Add(Desc);
                        command.Options.Add(Unnamed);
                        command.Options.Add(Ownership);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var offset = parseResult.GetValue(Offset);
                        var limit = parseResult.GetValue(Limit);
                        var desc = parseResult.GetValue(Desc);
                        var unnamed = parseResult.GetValue(Unnamed);
                        var ownership = parseResult.GetValue(Ownership);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.StorageKeyValueStores.KeyValueStoresGetAsync(
                                    offset: offset,
                                    limit: limit,
                                    desc: desc,
                                    unnamed: unnamed,
                                    ownership: ownership,
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