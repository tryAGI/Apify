#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Apify.CLI.Commands;

internal static partial class StorageDatasetsDatasetGetCommandApiCommand
{
    private static Argument<string> DatasetId { get; } = new(
        name: @"dataset-id")
    {
        Description = @"Dataset ID or `username~dataset-name`.",
    };

                    private static string FormatResponse(ParseResult parseResult, global::Apify.DatasetResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Apify.DatasetResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"dataset-get", @"Get dataset
Returns dataset object for given dataset ID.

This does not return dataset items, only information about the storage itself.
To retrieve dataset items, use the [List dataset items](/api/v2/dataset-items-get) endpoint.

:::note

Keep in mind that attributes `itemCount` and `cleanItemCount` are not propagated right away after data are pushed into a dataset.

:::

There is a short period (up to 5 seconds) during which these counters may not match with exact counts in dataset items.
");
                        command.Arguments.Add(DatasetId);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var datasetId = parseResult.GetRequiredValue(DatasetId);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.StorageDatasets.DatasetGetAsync(
                                    datasetId: datasetId,
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