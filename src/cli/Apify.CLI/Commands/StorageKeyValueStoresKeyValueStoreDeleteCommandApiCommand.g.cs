#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Apify.CLI.Commands;

internal static partial class StorageKeyValueStoresKeyValueStoreDeleteCommandApiCommand
{
    private static Argument<string> StoreId { get; } = new(
        name: @"store-id")
    {
        Description = @"Key-value store ID or `username~store-name`.",
    };

    public static Command Create()
    {
        var command = new Command(@"key-value-store-delete", @"Delete store
Deletes a key-value store.");
                        command.Arguments.Add(StoreId);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var storeId = parseResult.GetRequiredValue(StoreId);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                await client.StorageKeyValueStores.KeyValueStoreDeleteAsync(
                                    storeId: storeId,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);

                                await CliRuntime.WriteSuccessAsync(parseResult, cancellationToken).ConfigureAwait(false);
            }, cancellationToken).ConfigureAwait(false));
        return command;
    }
}