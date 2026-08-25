#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Apify.CLI.Commands;

internal static partial class StorageKeyValueStoresKeyValueStoreRecordGetAsBytesCommandApiCommand
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

    private static Option<bool?> Attachment { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--attachment",
        description: @"If `true` or `1`, the response will be served with `Content-Disposition: attachment` header,
causing web browsers to offer downloading HTML records instead of displaying them.
");

    private static Option<string?> Signature { get; } = new(
        name: @"--signature")
    {
        Description = @"Signature used for the access.",
    };

    public static Command Create()
    {
        var command = new Command(@"key-value-store-record-get-as-bytes", @"Get record
Gets a value stored in the key-value store under a specific key.

The response body has the same `Content-Encoding` header as it was set in
[Put record](#tag/Key-value-storesRecord/operation/keyValueStore_record_put).

If the request does not define the `Accept-Encoding` HTTP header with the
right encoding, the record will be decompressed.

Most HTTP clients support decompression by default. After using the HTTP
client with decompression support, the `Accept-Encoding` header is set by
the client and body is decompressed automatically.

Please note that for security reasons, Apify API can perform small modifications
to HTML documents before they are served via this endpoint. To fetch the raw HTML
content without any modifications, use the `attachment` query parameter.
");
                        command.Arguments.Add(StoreId);
                        command.Arguments.Add(RecordKey);
                        command.Options.Add(Attachment);
                        command.Options.Add(Signature);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var storeId = parseResult.GetRequiredValue(StoreId);
                        var recordKey = parseResult.GetRequiredValue(RecordKey);
                        var attachment = parseResult.GetValue(Attachment);
                        var signature = parseResult.GetValue(Signature);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.StorageKeyValueStores.KeyValueStoreRecordGetAsBytesAsync(
                                    storeId: storeId,
                                    recordKey: recordKey,
                                    attachment: attachment,
                                    signature: signature,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);

                                await CliRuntime.WriteBinaryAsync(parseResult, response, cancellationToken).ConfigureAwait(false);
            }, cancellationToken).ConfigureAwait(false));
        return command;
    }
}