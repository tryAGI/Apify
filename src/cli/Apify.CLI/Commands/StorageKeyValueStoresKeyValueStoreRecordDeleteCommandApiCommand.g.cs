#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Apify.CLI.Commands;

internal static partial class StorageKeyValueStoresKeyValueStoreRecordDeleteCommandApiCommand
{
    private static Argument<string> StoreId { get; } = new(
        name: @"store-id")
    {
        Description = @"Key-value store ID or `username~store-name`.",
    };

    private static Argument<string> RecordKey { get; } = new(
        name: @"record-key")
    {
        Description = @"Key of the record.",
    };

    public static Command Create()
    {
        var command = new Command(@"key-value-store-record-delete", @"Delete record
Removes a record specified by a key from the key-value store.");
                        command.Arguments.Add(StoreId);
                        command.Arguments.Add(RecordKey);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var storeId = parseResult.GetRequiredValue(StoreId);
                        var recordKey = parseResult.GetRequiredValue(RecordKey);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                await client.StorageKeyValueStores.KeyValueStoreRecordDeleteAsync(
                                    storeId: storeId,
                                    recordKey: recordKey,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);

                                await CliRuntime.WriteSuccessAsync(parseResult, cancellationToken).ConfigureAwait(false);
            }, cancellationToken).ConfigureAwait(false));
        return command;
    }
}