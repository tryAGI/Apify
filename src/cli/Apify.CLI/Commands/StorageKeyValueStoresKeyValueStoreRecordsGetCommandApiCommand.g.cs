#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Apify.CLI.Commands;

internal static partial class StorageKeyValueStoresKeyValueStoreRecordsGetCommandApiCommand
{
    private static Argument<string> StoreId { get; } = new(
        name: @"store-id")
    {
        Description = @"Key-value store ID or `username~store-name`.",
    };

    private static Option<string?> Collection { get; } = new(
        name: @"--collection")
    {
        Description = @"If specified, only records belonging to a specific collection from the key-value store schema. The key-value store need to have a schema defined for this parameter to work.
",
    };

    private static Option<string?> Prefix { get; } = new(
        name: @"--prefix")
    {
        Description = @"If specified, only records whose key starts with the given prefix are included in the archive.
",
    };

    private static Option<string?> Signature { get; } = new(
        name: @"--signature")
    {
        Description = @"Signature used for the access.",
    };

    public static Command Create()
    {
        var command = new Command(@"key-value-store-records-get", @"Download records
Downloads all records from the key-value store as a ZIP archive.
Each record is stored as a separate file in the archive, with the filename equal to the record key.

You can optionally filter the records by `collection` or `prefix` to download only a subset of the store.
");
                        command.Arguments.Add(StoreId);
                        command.Options.Add(Collection);
                        command.Options.Add(Prefix);
                        command.Options.Add(Signature);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var storeId = parseResult.GetRequiredValue(StoreId);
                        var collection = parseResult.GetValue(Collection);
                        var prefix = parseResult.GetValue(Prefix);
                        var signature = parseResult.GetValue(Signature);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.StorageKeyValueStores.KeyValueStoreRecordsGetAsync(
                                    storeId: storeId,
                                    collection: collection,
                                    prefix: prefix,
                                    signature: signature,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);

                                await CliRuntime.WriteBinaryAsync(parseResult, response, cancellationToken).ConfigureAwait(false);
            }, cancellationToken).ConfigureAwait(false));
        return command;
    }
}